namespace BatPac.NET
{
    partial class CameraDialogue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.btnRefreshCameraDevices = new System.Windows.Forms.Button();
            this.btnStartStopCamera = new System.Windows.Forms.Button();
            this.cmbVideoDevices = new System.Windows.Forms.ComboBox();
            this.lblVideoDevices = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.ipCollector = new System.Windows.Forms.TextBox();
            this.gbObjectDetection = new System.Windows.Forms.GroupBox();
            this.chkShowDetectedObjects = new System.Windows.Forms.CheckBox();
            this.btnTuneObjectFilter = new System.Windows.Forms.Button();
            this.chkObjectDetection = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.picButton = new System.Windows.Forms.Button();
            this.gbControl.SuspendLayout();
            this.gbObjectDetection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(2, 3);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(650, 491);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            this.videoSourcePlayer.Click += new System.EventHandler(this.videoSourcePlayer_Click);
            // 
            // btnRefreshCameraDevices
            // 
            this.btnRefreshCameraDevices.Location = new System.Drawing.Point(15, 91);
            this.btnRefreshCameraDevices.Name = "btnRefreshCameraDevices";
            this.btnRefreshCameraDevices.Size = new System.Drawing.Size(189, 35);
            this.btnRefreshCameraDevices.TabIndex = 1;
            this.btnRefreshCameraDevices.Text = "Refresh Camera Devices";
            this.btnRefreshCameraDevices.UseVisualStyleBackColor = true;
            this.btnRefreshCameraDevices.Click += new System.EventHandler(this.btnRefreshCameraDevices_Click);
            // 
            // btnStartStopCamera
            // 
            this.btnStartStopCamera.Location = new System.Drawing.Point(15, 132);
            this.btnStartStopCamera.Name = "btnStartStopCamera";
            this.btnStartStopCamera.Size = new System.Drawing.Size(189, 35);
            this.btnStartStopCamera.TabIndex = 2;
            this.btnStartStopCamera.Text = "Start";
            this.btnStartStopCamera.UseVisualStyleBackColor = true;
            this.btnStartStopCamera.Click += new System.EventHandler(this.btnStartStopCamera_Click);
            // 
            // cmbVideoDevices
            // 
            this.cmbVideoDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoDevices.FormattingEnabled = true;
            this.cmbVideoDevices.Location = new System.Drawing.Point(14, 64);
            this.cmbVideoDevices.Name = "cmbVideoDevices";
            this.cmbVideoDevices.Size = new System.Drawing.Size(190, 21);
            this.cmbVideoDevices.TabIndex = 4;
            this.cmbVideoDevices.SelectedIndexChanged += new System.EventHandler(this.cmbVideoDevices_SelectedIndexChanged);
            // 
            // lblVideoDevices
            // 
            this.lblVideoDevices.AutoSize = true;
            this.lblVideoDevices.Location = new System.Drawing.Point(12, 22);
            this.lblVideoDevices.Name = "lblVideoDevices";
            this.lblVideoDevices.Size = new System.Drawing.Size(70, 13);
            this.lblVideoDevices.TabIndex = 5;
            this.lblVideoDevices.Text = "Video Stream";
            this.lblVideoDevices.Click += new System.EventHandler(this.lblVideoDevices_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.ipCollector);
            this.gbControl.Controls.Add(this.cmbVideoDevices);
            this.gbControl.Controls.Add(this.lblVideoDevices);
            this.gbControl.Controls.Add(this.btnStartStopCamera);
            this.gbControl.Controls.Add(this.btnRefreshCameraDevices);
            this.gbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gbControl.Location = new System.Drawing.Point(658, 12);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(218, 200);
            this.gbControl.TabIndex = 6;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Control";
            // 
            // ipCollector
            // 
            this.ipCollector.Location = new System.Drawing.Point(15, 38);
            this.ipCollector.Name = "ipCollector";
            this.ipCollector.Size = new System.Drawing.Size(189, 20);
            this.ipCollector.TabIndex = 6;
            this.ipCollector.TextChanged += new System.EventHandler(this.ipCollector_TextChanged);
            // 
            // gbObjectDetection
            // 
            this.gbObjectDetection.Controls.Add(this.chkShowDetectedObjects);
            this.gbObjectDetection.Controls.Add(this.btnTuneObjectFilter);
            this.gbObjectDetection.Location = new System.Drawing.Point(658, 366);
            this.gbObjectDetection.Name = "gbObjectDetection";
            this.gbObjectDetection.Size = new System.Drawing.Size(218, 129);
            this.gbObjectDetection.TabIndex = 7;
            this.gbObjectDetection.TabStop = false;
            this.gbObjectDetection.Text = "Object Detection";
            this.gbObjectDetection.Enter += new System.EventHandler(this.gbObjectDetection_Enter);
            // 
            // chkShowDetectedObjects
            // 
            this.chkShowDetectedObjects.AutoSize = true;
            this.chkShowDetectedObjects.Location = new System.Drawing.Point(45, 39);
            this.chkShowDetectedObjects.Name = "chkShowDetectedObjects";
            this.chkShowDetectedObjects.Size = new System.Drawing.Size(139, 17);
            this.chkShowDetectedObjects.TabIndex = 3;
            this.chkShowDetectedObjects.Text = "Show Detected Objects";
            this.chkShowDetectedObjects.UseVisualStyleBackColor = true;
            this.chkShowDetectedObjects.CheckedChanged += new System.EventHandler(this.chkShowDetectedObjects_CheckedChanged);
            // 
            // btnTuneObjectFilter
            // 
            this.btnTuneObjectFilter.Location = new System.Drawing.Point(16, 78);
            this.btnTuneObjectFilter.Name = "btnTuneObjectFilter";
            this.btnTuneObjectFilter.Size = new System.Drawing.Size(189, 35);
            this.btnTuneObjectFilter.TabIndex = 0;
            this.btnTuneObjectFilter.Text = "Tune Object Filter";
            this.btnTuneObjectFilter.UseVisualStyleBackColor = true;
            this.btnTuneObjectFilter.Click += new System.EventHandler(this.btnTuneObjectFilter_Click);
            // 
            // chkObjectDetection
            // 
            this.chkObjectDetection.AutoSize = true;
            this.chkObjectDetection.Location = new System.Drawing.Point(658, 334);
            this.chkObjectDetection.Name = "chkObjectDetection";
            this.chkObjectDetection.Size = new System.Drawing.Size(148, 17);
            this.chkObjectDetection.TabIndex = 2;
            this.chkObjectDetection.Text = "Turn On Object Detection";
            this.chkObjectDetection.UseVisualStyleBackColor = true;
            this.chkObjectDetection.CheckedChanged += new System.EventHandler(this.chkObjectDetection_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.picButton);
            this.groupBox1.Location = new System.Drawing.Point(658, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Capture";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Record Footage";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // picButton
            // 
            this.picButton.Location = new System.Drawing.Point(29, 28);
            this.picButton.Name = "picButton";
            this.picButton.Size = new System.Drawing.Size(141, 23);
            this.picButton.TabIndex = 0;
            this.picButton.Text = "Take Picture";
            this.picButton.UseVisualStyleBackColor = true;
            this.picButton.Click += new System.EventHandler(this.picButton_Click);
            // 
            // CameraDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbObjectDetection);
            this.Controls.Add(this.chkObjectDetection);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.videoSourcePlayer);
            this.MaximizeBox = false;
            this.Name = "CameraDialogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbObjectDetection.ResumeLayout(false);
            this.gbObjectDetection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button btnRefreshCameraDevices;
        private System.Windows.Forms.Button btnStartStopCamera;
        private System.Windows.Forms.ComboBox cmbVideoDevices;
        private System.Windows.Forms.Label lblVideoDevices;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.GroupBox gbObjectDetection;
        private System.Windows.Forms.CheckBox chkShowDetectedObjects;
        private System.Windows.Forms.CheckBox chkObjectDetection;
        private System.Windows.Forms.Button btnTuneObjectFilter;
        private System.Windows.Forms.TextBox ipCollector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button picButton;
    }
}

