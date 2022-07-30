namespace Rectify11Installer.Pages
{
    partial class EPPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkW11 = new Rectify11Installer.Controls.DarkAwareRadioButton();
            this.chkW10 = new Rectify11Installer.Controls.DarkAwareRadioButton();
            this.chkMicaExplorer = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.darkAwareFlowLayoutPanel1 = new Rectify11Installer.Controls.DarkAwareFlowLayoutPanel();
            this.chkW10TaskB = new Rectify11Installer.Controls.DarkAwareCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.darkAwareFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Rectify11Installer.Properties.Resources.ep;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 367);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your desired theme";
            // 
            // chkW11
            // 
            this.chkW11.AutoSize = true;
            this.chkW11.ForeColor = System.Drawing.Color.White;
            this.chkW11.Location = new System.Drawing.Point(325, 62);
            this.chkW11.Name = "chkW11";
            this.chkW11.Size = new System.Drawing.Size(130, 19);
            this.chkW11.TabIndex = 2;
            this.chkW11.TabStop = true;
            this.chkW11.Text = "Windows 11 Default";
            this.chkW11.UseVisualStyleBackColor = true;
            // 
            // chkW10
            // 
            this.chkW10.AutoSize = true;
            this.chkW10.ForeColor = System.Drawing.Color.White;
            this.chkW10.Location = new System.Drawing.Point(325, 129);
            this.chkW10.Name = "chkW10";
            this.chkW10.Size = new System.Drawing.Size(140, 19);
            this.chkW10.TabIndex = 3;
            this.chkW10.TabStop = true;
            this.chkW10.Text = "Windows 10 Rounded";
            this.chkW10.UseVisualStyleBackColor = true;
            // 
            // chkMicaExplorer
            // 
            this.chkMicaExplorer.AutoSize = true;
            this.chkMicaExplorer.ForeColor = System.Drawing.Color.White;
            this.chkMicaExplorer.Location = new System.Drawing.Point(3, 28);
            this.chkMicaExplorer.Name = "chkMicaExplorer";
            this.chkMicaExplorer.Size = new System.Drawing.Size(228, 19);
            this.chkMicaExplorer.TabIndex = 4;
            this.chkMicaExplorer.Text = "Extend mica to explorer navigation bar";
            this.chkMicaExplorer.UseVisualStyleBackColor = true;
            // 
            // darkAwareFlowLayoutPanel1
            // 
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkW10TaskB);
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkMicaExplorer);
            this.darkAwareFlowLayoutPanel1.Location = new System.Drawing.Point(325, 187);
            this.darkAwareFlowLayoutPanel1.Name = "darkAwareFlowLayoutPanel1";
            this.darkAwareFlowLayoutPanel1.Size = new System.Drawing.Size(239, 81);
            this.darkAwareFlowLayoutPanel1.TabIndex = 5;
            // 
            // chkW10TaskB
            // 
            this.chkW10TaskB.AutoSize = true;
            this.chkW10TaskB.ForeColor = System.Drawing.Color.White;
            this.chkW10TaskB.Location = new System.Drawing.Point(3, 3);
            this.chkW10TaskB.Name = "chkW10TaskB";
            this.chkW10TaskB.Size = new System.Drawing.Size(133, 19);
            this.chkW10TaskB.TabIndex = 5;
            this.chkW10TaskB.Text = "Windows 10 Taskbar";
            this.chkW10TaskB.UseVisualStyleBackColor = true;
            // 
            // EPPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.darkAwareFlowLayoutPanel1);
            this.Controls.Add(this.chkW10);
            this.Controls.Add(this.chkW11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EPPage";
            this.WizardTopText = "Customize your desktop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.darkAwareFlowLayoutPanel1.ResumeLayout(false);
            this.darkAwareFlowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Controls.DarkAwareRadioButton chkW11;
        private Controls.DarkAwareRadioButton chkW10;
        private Controls.DarkAwareCheckBox chkMicaExplorer;
        private Controls.DarkAwareFlowLayoutPanel darkAwareFlowLayoutPanel1;
        private Controls.DarkAwareCheckBox chkW10TaskB;
    }
}
