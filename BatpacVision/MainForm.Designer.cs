namespace BatPac.NET
{
    partial class MainForm
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
            this.CameraTabs = new System.Windows.Forms.TabControl();
            this.CameraGrp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CameraTabs
            // 
            this.CameraTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.CameraTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraTabs.Location = new System.Drawing.Point(12, 38);
            this.CameraTabs.Name = "CameraTabs";
            this.CameraTabs.SelectedIndex = 0;
            this.CameraTabs.Size = new System.Drawing.Size(1159, 711);
            this.CameraTabs.TabIndex = 0;
            this.CameraTabs.SelectedIndexChanged += new System.EventHandler(this.CameraTabs_SelectedIndexChanged);
            // 
            // CameraGrp
            // 
            this.CameraGrp.Location = new System.Drawing.Point(13, 13);
            this.CameraGrp.Name = "CameraGrp";
            this.CameraGrp.Size = new System.Drawing.Size(133, 23);
            this.CameraGrp.TabIndex = 1;
            this.CameraGrp.Text = "Add Camera Group";
            this.CameraGrp.UseVisualStyleBackColor = true;
            this.CameraGrp.Click += new System.EventHandler(this.CameraGrp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.CameraGrp);
            this.Controls.Add(this.CameraTabs);
            this.Name = "MainForm";
            this.Text = "Batpac Vision 1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CameraTabs;
        private System.Windows.Forms.Button CameraGrp;
    }
}