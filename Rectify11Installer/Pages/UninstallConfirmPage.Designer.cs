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
            this.chkRemoveThemes = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.chkRestoreWallpaper = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.darkAwareFlowLayoutPanel1 = new Rectify11Installer.Controls.DarkAwareFlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.darkAwareFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // chkExplorerPatcher
            // 
            this.chkExplorerPatcher.AutoSize = true;
            this.chkExplorerPatcher.ForeColor = System.Drawing.Color.White;
            this.chkExplorerPatcher.Location = new System.Drawing.Point(3, 3);
            this.chkExplorerPatcher.Name = "chkExplorerPatcher";
            this.chkExplorerPatcher.Size = new System.Drawing.Size(157, 19);
            this.chkExplorerPatcher.TabIndex = 16;
            this.chkExplorerPatcher.Text = "Uninstall ExplorerPatcher";
            this.chkExplorerPatcher.UseVisualStyleBackColor = true;
            // 
            // chkRemoveThemes
            // 
            this.chkRemoveThemes.AutoSize = true;
            this.chkRemoveThemes.Checked = true;
            this.chkRemoveThemes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveThemes.ForeColor = System.Drawing.Color.White;
            this.chkRemoveThemes.Location = new System.Drawing.Point(3, 53);
            this.chkRemoveThemes.Name = "chkRemoveThemes";
            this.chkRemoveThemes.Size = new System.Drawing.Size(111, 19);
            this.chkRemoveThemes.TabIndex = 0;
            this.chkRemoveThemes.Text = "Remove themes";
            this.chkRemoveThemes.UseVisualStyleBackColor = true;
            this.chkRemoveThemes.CheckedChanged += new System.EventHandler(this.chkRemoveThemes_CheckedChanged);
            // 
            // chkRestoreWallpaper
            // 
            this.chkRestoreWallpaper.AutoSize = true;
            this.chkRestoreWallpaper.Checked = true;
            this.chkRestoreWallpaper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRestoreWallpaper.ForeColor = System.Drawing.Color.White;
            this.chkRestoreWallpaper.Location = new System.Drawing.Point(3, 28);
            this.chkRestoreWallpaper.Name = "chkRestoreWallpaper";
            this.chkRestoreWallpaper.Size = new System.Drawing.Size(171, 19);
            this.chkRestoreWallpaper.TabIndex = 17;
            this.chkRestoreWallpaper.Text = "Delete Rectify11 Wallpapers";
            this.chkRestoreWallpaper.UseVisualStyleBackColor = true;
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
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkRestoreWallpaper);
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkRemoveThemes);
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
        private Controls.DarkAwareCheckBox chkRemoveThemes;
        private Controls.DarkAwareCheckBox chkRestoreWallpaper;
        private Label label1;
        private Label label2;
        private Controls.DarkAwareFlowLayoutPanel darkAwareFlowLayoutPanel1;
        private PictureBox pictureBox2;
    }
}
