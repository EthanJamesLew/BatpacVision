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
    public partial class CameraGroup : Form
    {
        public CameraGroup()
        {
            InitializeComponent();
        }

        private void AddCamera_Click(object sender, EventArgs e)
        {
            CameraDialogue form = new CameraDialogue();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void cameraFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CameraGroup_Load(object sender, EventArgs e)
        {

        }

        
    }
}
