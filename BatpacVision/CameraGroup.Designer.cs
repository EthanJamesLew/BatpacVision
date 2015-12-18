namespace BatPac.NET
{
    partial class CameraGroup
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
            this.AddCamera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCamera
            // 
            this.AddCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCamera.Location = new System.Drawing.Point(1045, 505);
            this.AddCamera.Name = "AddCamera";
            this.AddCamera.Size = new System.Drawing.Size(75, 23);
            this.AddCamera.TabIndex = 1;
            this.AddCamera.Text = "+";
            this.AddCamera.UseVisualStyleBackColor = true;
            this.AddCamera.Click += new System.EventHandler(this.AddCamera_Click);
            // 
            // CameraGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1132, 540);
            this.Controls.Add(this.AddCamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CameraGroup";
            this.Text = "CameraGroup";
            this.Load += new System.EventHandler(this.CameraGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddCamera;
    }
}