using Rectify11Installer.Controls;

namespace Rectify11Installer.Pages
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbInstallNOW = new Rectify11Installer.Controls.FakeCommandLink();
            this.cmbUninstall = new Rectify11Installer.Controls.FakeCommandLink();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Rectify11Installer.Properties.Resources.rectify11Installer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(75, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 184);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmbInstallNOW
            // 
            this.cmbInstallNOW.BackColor = System.Drawing.Color.Transparent;
            this.cmbInstallNOW.Location = new System.Drawing.Point(303, 232);
            this.cmbInstallNOW.Name = "cmbInstallNOW";
            this.cmbInstallNOW.Note = "Rectify your current Windows 11 installation";
            this.cmbInstallNOW.Size = new System.Drawing.Size(294, 55);
            this.cmbInstallNOW.TabIndex = 7;
            this.cmbInstallNOW.Text = "Update or Install Now";
            // 
            // cmbUninstall
            // 
            this.cmbUninstall.BackColor = System.Drawing.Color.Transparent;
            this.cmbUninstall.Enabled = false;
            this.cmbUninstall.Location = new System.Drawing.Point(303, 290);
            this.cmbUninstall.Name = "cmbUninstall";
            this.cmbUninstall.Note = "Restores the original Windows 11 look.";
            this.cmbUninstall.Size = new System.Drawing.Size(294, 55);
            this.cmbUninstall.TabIndex = 8;
            this.cmbUninstall.Text = "Uninstall Rectify11";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.Location = new System.Drawing.Point(5, 452);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(49, 17);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "v3.0-rp";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(303, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 121);
            this.label3.TabIndex = 17;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbUninstall);
            this.Controls.Add(this.cmbInstallNOW);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "WelcomePage";
            this.Size = new System.Drawing.Size(640, 475);
            this.WizardShowTitle = false;
            this.WizardTopText = "Welcome to Rectify11 Installer";
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private FakeCommandLink cmbInstallNOW;
        private FakeCommandLink cmbUninstall;
        private Label label1;
        private Label lblVersion;
        private Label label3;
    }
}
