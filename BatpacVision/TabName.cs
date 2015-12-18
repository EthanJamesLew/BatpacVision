using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatpacVision
{
    public partial class TabName : Form
    {
        // add this code after the class' default constructor


        public TabName()
              // : this()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            //var _point = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y);
            //Top = _point.Y;
            //Left = _point.X;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                BatPac.NET.MainForm.CurrentTabName = textBox1.Text;
            }
            else
            {
                BatPac.NET.MainForm.CurrentTabName = "Default";
            }
            this.Close();
        }
    }
}
