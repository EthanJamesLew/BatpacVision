using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BatPac.NET
{
    public partial class MainForm : Form
    {
        public static string CurrentTabName = "Webcam";

        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void CameraGrp_Click(object sender, EventArgs e)
        {
            CameraGroup myForm = new CameraGroup();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;

            BatpacVision.TabName Form2 = new BatpacVision.TabName();
            
            Form2.ShowDialog();
            Form2.Location = new Point(Cursor.Position.X, Cursor.Position.Y);

            TabPage myTabPage = new TabPage(CurrentTabName);
            CameraTabs.TabPages.Add(myTabPage);

            myTabPage.Controls.Add(myForm);
            myForm.Dock = System.Windows.Forms.DockStyle.Fill;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        private void CameraTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                CameraTabs.TabPages.Remove(CameraTabs.SelectedTab);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
