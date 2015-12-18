namespace BatPac.NET
{
    partial class TuneObjectFilterForm
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
            this.blueSlider = new AForge.Controls.ColorSlider();
            this.greenSlider = new AForge.Controls.ColorSlider();
            this.redSlider = new AForge.Controls.ColorSlider();
            this.lblBlueRange = new System.Windows.Forms.Label();
            this.lblGreenRange = new System.Windows.Forms.Label();
            this.lblRedRange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blueSlider
            // 
            this.blueSlider.EndColor = System.Drawing.Color.Blue;
            this.blueSlider.Location = new System.Drawing.Point(85, 70);
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(270, 25);
            this.blueSlider.TabIndex = 11;
            this.blueSlider.Text = "colorSlider3";
            this.blueSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.blueSlider.ValuesChanged += new System.EventHandler(this.blueSlider_ValuesChanged);
            // 
            // greenSlider
            // 
            this.greenSlider.EndColor = System.Drawing.Color.Lime;
            this.greenSlider.Location = new System.Drawing.Point(85, 45);
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(270, 25);
            this.greenSlider.TabIndex = 10;
            this.greenSlider.Text = "colorSlider2";
            this.greenSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.greenSlider.ValuesChanged += new System.EventHandler(this.greenSlider_ValuesChanged);
            // 
            // redSlider
            // 
            this.redSlider.EndColor = System.Drawing.Color.Red;
            this.redSlider.Location = new System.Drawing.Point(85, 20);
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(270, 25);
            this.redSlider.TabIndex = 9;
            this.redSlider.Text = "colorSlider1";
            this.redSlider.Type = AForge.Controls.ColorSlider.ColorSliderType.InnerGradient;
            this.redSlider.ValuesChanged += new System.EventHandler(this.redSlider_ValuesChanged);
            // 
            // lblBlueRange
            // 
            this.lblBlueRange.AutoSize = true;
            this.lblBlueRange.Location = new System.Drawing.Point(10, 70);
            this.lblBlueRange.Name = "lblBlueRange";
            this.lblBlueRange.Size = new System.Drawing.Size(61, 13);
            this.lblBlueRange.TabIndex = 8;
            this.lblBlueRange.Text = "Blue range:";
            // 
            // lblGreenRange
            // 
            this.lblGreenRange.AutoSize = true;
            this.lblGreenRange.Location = new System.Drawing.Point(10, 45);
            this.lblGreenRange.Name = "lblGreenRange";
            this.lblGreenRange.Size = new System.Drawing.Size(69, 13);
            this.lblGreenRange.TabIndex = 7;
            this.lblGreenRange.Text = "Green range:";
            // 
            // lblRedRange
            // 
            this.lblRedRange.AutoSize = true;
            this.lblRedRange.Location = new System.Drawing.Point(10, 20);
            this.lblRedRange.Name = "lblRedRange";
            this.lblRedRange.Size = new System.Drawing.Size(60, 13);
            this.lblRedRange.TabIndex = 6;
            this.lblRedRange.Text = "Red range:";
            // 
            // TuneObjectFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 96);
            this.Controls.Add(this.blueSlider);
            this.Controls.Add(this.greenSlider);
            this.Controls.Add(this.redSlider);
            this.Controls.Add(this.lblBlueRange);
            this.Controls.Add(this.lblGreenRange);
            this.Controls.Add(this.lblRedRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TuneObjectFilterForm";
            this.ShowInTaskbar = false;
            this.Text = "Tune Object Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TuneObjectFilterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.ColorSlider blueSlider;
        private AForge.Controls.ColorSlider greenSlider;
        private AForge.Controls.ColorSlider redSlider;
        private System.Windows.Forms.Label lblBlueRange;
        private System.Windows.Forms.Label lblGreenRange;
        private System.Windows.Forms.Label lblRedRange;
    }
}