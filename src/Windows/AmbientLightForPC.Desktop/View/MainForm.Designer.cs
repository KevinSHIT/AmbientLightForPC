
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
        /// Required method for Designer support - do fnot modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tkbBrightness = new System.Windows.Forms.TrackBar();
            this.cmbBrightnessController = new System.Windows.Forms.ComboBox();
            this.numBrightness = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.ckbAutoApply = new System.Windows.Forms.CheckBox();
            this.ckbOverNormal = new System.Windows.Forms.CheckBox();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.lblControllerInfo = new System.Windows.Forms.Label();
            this.ntfMain = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightness)).BeginInit();
            this.gpbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tkbBrightness
            // 
            this.tkbBrightness.Location = new System.Drawing.Point(12, 54);
            this.tkbBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tkbBrightness.Maximum = 100;
            this.tkbBrightness.Name = "tkbBrightness";
            this.tkbBrightness.Size = new System.Drawing.Size(328, 56);
            this.tkbBrightness.TabIndex = 0;
            this.tkbBrightness.Scroll += new System.EventHandler(this.tkbBrightness_Scroll);
            // 
            // cmbBrightnessController
            // 
            this.cmbBrightnessController.FormattingEnabled = true;
            this.cmbBrightnessController.Location = new System.Drawing.Point(12, 12);
            this.cmbBrightnessController.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBrightnessController.Name = "cmbBrightnessController";
            this.cmbBrightnessController.Size = new System.Drawing.Size(460, 28);
            this.cmbBrightnessController.TabIndex = 1;
            this.cmbBrightnessController.SelectedIndexChanged += new System.EventHandler(this.cmbBrightnessController_SelectedIndexChanged);
            // 
            // numBrightness
            // 
            this.numBrightness.Location = new System.Drawing.Point(346, 59);
            this.numBrightness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBrightness.Name = "numBrightness";
            this.numBrightness.Size = new System.Drawing.Size(126, 27);
            this.numBrightness.TabIndex = 2;
            this.numBrightness.ValueChanged += new System.EventHandler(this.numBrightness_ValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(346, 199);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(126, 54);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ckbAutoApply
            // 
            this.ckbAutoApply.AutoSize = true;
            this.ckbAutoApply.Location = new System.Drawing.Point(12, 199);
            this.ckbAutoApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbAutoApply.Name = "ckbAutoApply";
            this.ckbAutoApply.Size = new System.Drawing.Size(106, 24);
            this.ckbAutoApply.TabIndex = 4;
            this.ckbAutoApply.Text = "Auto Apply";
            this.ckbAutoApply.UseVisualStyleBackColor = true;
            this.ckbAutoApply.CheckedChanged += new System.EventHandler(this.ckbAutoApply_CheckedChanged);
            // 
            // ckbOverNormal
            // 
            this.ckbOverNormal.AutoSize = true;
            this.ckbOverNormal.Location = new System.Drawing.Point(12, 229);
            this.ckbOverNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbOverNormal.Name = "ckbOverNormal";
            this.ckbOverNormal.Size = new System.Drawing.Size(198, 24);
            this.ckbOverNormal.TabIndex = 5;
            this.ckbOverNormal.Text = "Allow Over Normal Value";
            this.ckbOverNormal.UseVisualStyleBackColor = true;
            this.ckbOverNormal.CheckedChanged += new System.EventHandler(this.ckbOverNormal_CheckedChanged);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.lblControllerInfo);
            this.gpbInfo.Location = new System.Drawing.Point(12, 101);
            this.gpbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbInfo.Size = new System.Drawing.Size(460, 84);
            this.gpbInfo.TabIndex = 6;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Controller Info";
            // 
            // lblControllerInfo
            // 
            this.lblControllerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblControllerInfo.Location = new System.Drawing.Point(3, 22);
            this.lblControllerInfo.Name = "lblControllerInfo";
            this.lblControllerInfo.Size = new System.Drawing.Size(454, 60);
            this.lblControllerInfo.TabIndex = 0;
            this.lblControllerInfo.Text = "Null";
            // 
            // ntfMain
            // 
            this.ntfMain.Text = "AmbientLightForPC.Desktop";
            this.ntfMain.Visible = true;
            this.ntfMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfMain_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 261);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.ckbOverNormal);
            this.Controls.Add(this.ckbAutoApply);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.numBrightness);
            this.Controls.Add(this.cmbBrightnessController);
            this.Controls.Add(this.tkbBrightness);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tkbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrightness)).EndInit();
            this.gpbInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbBrightness;
        private System.Windows.Forms.ComboBox cmbBrightnessController;
        private System.Windows.Forms.NumericUpDown numBrightness;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox ckbAutoApply;
        private System.Windows.Forms.CheckBox ckbOverNormal;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.Label lblControllerInfo;
        private System.Windows.Forms.NotifyIcon ntfMain;
    }
}

