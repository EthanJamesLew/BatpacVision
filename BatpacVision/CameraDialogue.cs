using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;

using System.Drawing.Imaging;

namespace BatPac.NET
{
    public partial class CameraDialogue : Form
    {
        #region Global Variables
        // List of video devices
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private MJPEGStream mjpegStream;

        // Form to tune object detection filter
        private TuneObjectFilterForm tuneObjectFilterForm;

        private ColorFiltering colorFilter = new ColorFiltering();
        private GrayscaleBT709 grayFilter = new GrayscaleBT709();

        private BlobCounter blobCounter = new BlobCounter();

        #endregion Global Variables

        #region Constructor
        public CameraDialogue()
        {
            InitializeComponent();

            //colorFilter.Red = new IntRange(0, 255);    
            //colorFilter.Green = new IntRange(0, 255);   
            //colorFilter.Blue = new IntRange(0, 255); 

            // configure blob counters
            blobCounter.MinWidth = 25;
            blobCounter.MinHeight = 25;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;

            EnableConnectionControls(true);

            gbObjectDetection.Hide();
        }

        #endregion Constructor

        #region Methods
        private void EnableConnectionControls(bool enable)
        {
            cmbVideoDevices.Enabled = enable;
            btnRefreshCameraDevices.Enabled = enable;
            gbObjectDetection.Enabled = !enable;
        }

        private void ConnectCamera()
        {
            if (mjpegStream != null)
            {
                videoSourcePlayer.VideoSource = mjpegStream;
                videoSourcePlayer.Start();
            }
            else
            {
                if (videoSource != null)
                {
                    videoSourcePlayer.VideoSource = videoSource;
                    videoSourcePlayer.Start();
                }
            }
            
        }

        private void DisconnectCamera()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                // Stop video device
                videoSourcePlayer.SignalToStop();
                videoSourcePlayer.WaitForStop();
                videoSourcePlayer.VideoSource = null;
            }
        }

        private void RefreshVideoDevices()
        {
            cmbVideoDevices.Items.Clear();

            // Enumerate video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count != 0)
            {
                // Add all devices to combobox
                foreach (FilterInfo device in videoDevices)
                {
                    cmbVideoDevices.Items.Add(device.Name);
                }
            }
            else
            {
                cmbVideoDevices.Items.Add("No DirectShow devices found");
            }

            cmbVideoDevices.SelectedIndex = 0;
        }

        private void ProcessImage(Bitmap image)
        {
            Bitmap objectImage = colorFilter.Apply(image);
            // Lock image
            BitmapData objectData = objectImage.LockBits(new Rectangle(0, 0, image.Width, image.Height),
                                                            ImageLockMode.ReadOnly, image.PixelFormat);
            // Grayscaling
            UnmanagedImage grayImage = grayFilter.Apply(new UnmanagedImage(objectData));

            objectImage.UnlockBits(objectData);
            blobCounter.ProcessImage(grayImage);

            Rectangle[] rects = blobCounter.GetObjectsRectangles();

            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];
                // Draw rectangle around derected object
                Graphics g = Graphics.FromImage(image);

                //System.Drawing.Point centerOfMass = new System.Drawing.Point(objectRect.X + objectRect.Width / 2,
                //                                        objectRect.Y + objectRect.Height / 2);

                //using (Pen pen = new Pen(Color.FromArgb(255, 128, 0), 5))   // Orange color pen
                //using (Pen pen = new Pen(Color.FromArgb(int.Parse(tuneObjectFilterForm.RedRange.Length.ToString()),
                //int.Parse(tuneObjectFilterForm.GreenRange.Length.ToString()),
                //int.Parse(tuneObjectFilterForm.BlueRange.Length.ToString())), 5))
                using (Pen pen = new Pen(Color.Red, 5))
                {
                    g.DrawRectangle(pen, objectRect);
                    //g.DrawEllipse(pen, centerOfMass.X, centerOfMass.Y, 5, 5);
                }
                g.Dispose();
            }
        }

        #endregion Methods

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshVideoDevices();
        }

        private void MainForm_Clicked(object sender, EventArgs e)
        {
            this.BringToFront();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectCamera();
        }

        private void btnStartStopCamera_Click(object sender, EventArgs e)
        {
            if (btnStartStopCamera.Text == "Start")
            {
                ConnectCamera();
                btnStartStopCamera.Text = "Stop";

                EnableConnectionControls(false);
            }
            else
            {
                DisconnectCamera();
                btnStartStopCamera.Text = "Start";
                EnableConnectionControls(true);
            }
        }

        private void cmbVideoDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[cmbVideoDevices.SelectedIndex].MonikerString);
            }
        }

        private void btnRefreshCameraDevices_Click(object sender, EventArgs e)
        {
            RefreshVideoDevices();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTuneObjectFilter_Click(object sender, EventArgs e)
        {
            if (tuneObjectFilterForm == null)
            {
                tuneObjectFilterForm = new TuneObjectFilterForm();
                tuneObjectFilterForm.OnFilterUpdate += new EventHandler(tuneObjectFilterForm_OnFilterUpdate);

                tuneObjectFilterForm.RedRange = colorFilter.Red;
                tuneObjectFilterForm.GreenRange = colorFilter.Green;
                tuneObjectFilterForm.BlueRange = colorFilter.Blue;
            }
            tuneObjectFilterForm.Show();
        }

        private void tuneObjectFilterForm_OnFilterUpdate(object sender, EventArgs e)
        {
            colorFilter.Red = tuneObjectFilterForm.RedRange;
            colorFilter.Green = tuneObjectFilterForm.GreenRange;
            colorFilter.Blue = tuneObjectFilterForm.BlueRange;
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            bool showOnlyObjects = chkShowDetectedObjects.Checked;

            Bitmap objectImage = null;

            // Color filtering
            if (showOnlyObjects)
            {
                objectImage = image;
                colorFilter.ApplyInPlace(image);
            }
            else
            {
                objectImage = colorFilter.Apply(image);
            }

            if (chkObjectDetection.Checked)
            {
                ProcessImage(image);
            }
        }

        #endregion Events

        private void chkObjectDetection_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjectDetection.Checked == true)
            {
                gbObjectDetection.Show();
            }
            else
            {
                gbObjectDetection.Hide();
            }
        }

        private void gbObjectDetection_Enter(object sender, EventArgs e)
        {
            
        }

        private void chkShowDetectedObjects_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblVideoDevices_Click(object sender, EventArgs e)
        {

        }

        private void video_NewFrame(object sender,
                NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = eventArgs.Frame;
            
        }
        private void ipCollector_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mjpegStream = new MJPEGStream(ipCollector.Text);
                mjpegStream.NewFrame += new NewFrameEventHandler(video_NewFrame);
                mjpegStream.Start();
            }
            catch
            {

            }
        }

        private void videoSourcePlayer_Click(object sender, EventArgs e)
        {

        }

        private void picButton_Click(object sender, EventArgs e)
        {
            
                //Save First
                Bitmap varBmp = new Bitmap(videoSourcePlayer.GetCurrentVideoFrame());
            //Bitmap newBitmap = new Bitmap(varBmp);
                string name = DateTime.Now.ToString("MM_dd_yyyy-h_mm_ss_tt") + ".png";
                varBmp.Save(name, ImageFormat.Png);
                //Now Dispose to free the memory
                varBmp.Dispose();
                //varBmp = null;

        }
    } // class
} // namespace
