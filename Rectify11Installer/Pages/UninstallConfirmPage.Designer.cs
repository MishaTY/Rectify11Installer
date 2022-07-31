namespace Rectify11Installer.Pages
{
    partial class UninstallConfirmPage
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
            this.chkExplorerPatcher = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.chkRemoveWallpapers = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.chkRemoveWinver = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.darkAwareFlowLayoutPanel1 = new Rectify11Installer.Controls.DarkAwareFlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkRemoveAsdf = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.darkAwareFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // chkExplorerPatcher
            // 
            this.chkExplorerPatcher.AutoSize = true;
            this.chkExplorerPatcher.Checked = true;
            this.chkExplorerPatcher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExplorerPatcher.ForeColor = System.Drawing.Color.White;
            this.chkExplorerPatcher.Location = new System.Drawing.Point(3, 3);
            this.chkExplorerPatcher.Name = "chkExplorerPatcher";
            this.chkExplorerPatcher.Size = new System.Drawing.Size(157, 19);
            this.chkExplorerPatcher.TabIndex = 16;
            this.chkExplorerPatcher.Text = "Uninstall ExplorerPatcher";
            this.chkExplorerPatcher.UseVisualStyleBackColor = true;
            // 
            // chkRemoveWallpapers
            // 
            this.chkRemoveWallpapers.AutoSize = true;
            this.chkRemoveWallpapers.Checked = true;
            this.chkRemoveWallpapers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveWallpapers.ForeColor = System.Drawing.Color.White;
            this.chkRemoveWallpapers.Location = new System.Drawing.Point(3, 53);
            this.chkRemoveWallpapers.Name = "chkRemoveWallpapers";
            this.chkRemoveWallpapers.Size = new System.Drawing.Size(128, 19);
            this.chkRemoveWallpapers.TabIndex = 0;
            this.chkRemoveWallpapers.Text = "Remove wallpapers";
            this.chkRemoveWallpapers.UseVisualStyleBackColor = true;
            // 
            // chkRemoveWinver
            // 
            this.chkRemoveWinver.AutoSize = true;
            this.chkRemoveWinver.Checked = true;
            this.chkRemoveWinver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveWinver.ForeColor = System.Drawing.Color.White;
            this.chkRemoveWinver.Location = new System.Drawing.Point(3, 28);
            this.chkRemoveWinver.Name = "chkRemoveWinver";
            this.chkRemoveWinver.Size = new System.Drawing.Size(158, 19);
            this.chkRemoveWinver.TabIndex = 17;
            this.chkRemoveWinver.Text = "Remove Rectify11 winver";
            this.chkRemoveWinver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose what to remove";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 45);
            this.label2.TabIndex = 24;
            this.label2.Text = "Choose what other features/programs will be removed. Icons are always restored ba" +
    "ck.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkAwareFlowLayoutPanel1
            // 
            this.darkAwareFlowLayoutPanel1.AutoScroll = true;
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkExplorerPatcher);
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkRemoveWinver);
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkRemoveWallpapers);
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkRemoveAsdf);
            this.darkAwareFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.darkAwareFlowLayoutPanel1.Location = new System.Drawing.Point(148, 221);
            this.darkAwareFlowLayoutPanel1.Name = "darkAwareFlowLayoutPanel1";
            this.darkAwareFlowLayoutPanel1.Size = new System.Drawing.Size(340, 181);
            this.darkAwareFlowLayoutPanel1.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Rectify11Installer.Properties.Resources.rectify11Installer;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(642, 150);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // chkRemoveAsdf
            // 
            this.chkRemoveAsdf.AutoSize = true;
            this.chkRemoveAsdf.Checked = true;
            this.chkRemoveAsdf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveAsdf.ForeColor = System.Drawing.Color.White;
            this.chkRemoveAsdf.Location = new System.Drawing.Point(3, 78);
            this.chkRemoveAsdf.Name = "chkRemoveAsdf";
            this.chkRemoveAsdf.Size = new System.Drawing.Size(156, 19);
            this.chkRemoveAsdf.TabIndex = 18;
            this.chkRemoveAsdf.Text = "Remove AccentColorizer";
            this.chkRemoveAsdf.UseVisualStyleBackColor = true;
            // 
            // UninstallConfirmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.darkAwareFlowLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UninstallConfirmPage";
            this.WizardShowTitle = false;
            this.WizardTopText = "Choose what to uninstall";
            this.darkAwareFlowLayoutPanel1.ResumeLayout(false);
            this.darkAwareFlowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.DarkAwareCheckBox chkExplorerPatcher;
        private Controls.DarkAwareCheckBox chkRemoveWallpapers;
        private Controls.DarkAwareCheckBox chkRemoveWinver;
        private Label label1;
        private Label label2;
        private Controls.DarkAwareFlowLayoutPanel darkAwareFlowLayoutPanel1;
        private PictureBox pictureBox2;
        private Controls.DarkAwareCheckBox chkRemoveAsdf;
    }
}
