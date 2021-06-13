
namespace AmbientLightForPC.Desktop.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.tkbBrightness = new System.Windows.Forms.TrackBar();
            this.cmbBrightnessController = new System.Windows.Forms.ComboBox();
            this.numBrightness = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.tkbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbBrightness
            // 
            this.tkbBrightness.Location = new System.Drawing.Point(12, 98);
            this.tkbBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tkbBrightness.Maximum = 255;
            this.tkbBrightness.Name = "tkbBrightness";
            this.tkbBrightness.Size = new System.Drawing.Size(328, 56);
            this.tkbBrightness.TabIndex = 0;
            this.tkbBrightness.Scroll += new System.EventHandler(this.tkbBrightness_Scroll);
            // 
            // cmbBrightnessController
            // 
            this.cmbBrightnessController.FormattingEnabled = true;
            this.cmbBrightnessController.Location = new System.Drawing.Point(12, 10);
            this.cmbBrightnessController.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBrightnessController.Name = "cmbBrightnessController";
            this.cmbBrightnessController.Size = new System.Drawing.Size(283, 24);
            this.cmbBrightnessController.TabIndex = 1;
            this.cmbBrightnessController.SelectedIndexChanged += new System.EventHandler(this.cmbBrightnessController_SelectedIndexChanged);
            // 
            // numBrightness
            // 
            this.numBrightness.Location = new System.Drawing.Point(371, 107);
            this.numBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBrightness.Maximum = new decimal(new int[] {255, 0, 0, 0});
            this.numBrightness.Name = "numBrightness";
            this.numBrightness.Size = new System.Drawing.Size(150, 22);
            this.numBrightness.TabIndex = 2;
            this.numBrightness.ValueChanged += new System.EventHandler(this.numBrightness_ValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(479, 213);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.numBrightness);
            this.Controls.Add(this.cmbBrightnessController);
            this.Controls.Add(this.tkbBrightness);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.tkbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TrackBar tkbBrightness;
        private System.Windows.Forms.ComboBox cmbBrightnessController;
        private System.Windows.Forms.NumericUpDown numBrightness;
        private System.Windows.Forms.Button btnApply;
    }
}

