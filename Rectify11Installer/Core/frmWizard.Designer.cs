using AeroWizard;

namespace Rectify11Installer
{
    partial class FrmWizard
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWizard));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.navigationButton1 = new Rectify11Installer.Controls.NavigationButton();
            this.lblTopText = new AeroWizard.ThemedLabel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.BtnBack = new Rectify11Installer.Controls.WinUIButton();
            this.BtnNext = new Rectify11Installer.Controls.WinUIButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Controls.Add(this.navigationButton1);
            this.pnlTop.Controls.Add(this.lblTopText);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(640, 50);
            this.pnlTop.TabIndex = 3;
            // 
            // navigationButton1
            // 
            this.navigationButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.navigationButton1.BackColor = System.Drawing.Color.Black;
            this.navigationButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.navigationButton1.Location = new System.Drawing.Point(10, 10);
            this.navigationButton1.Name = "navigationButton1";
            this.navigationButton1.NavigationButtonType = Rectify11Installer.Controls.NavigationButtonType.Backward;
            this.navigationButton1.Size = new System.Drawing.Size(30, 30);
            this.navigationButton1.TabIndex = 0;
            this.navigationButton1.Text = "navigationButton1";
            this.navigationButton1.Click += new System.EventHandler(this.NavigationButton1_Click);
            // 
            // lblTopText
            // 
            this.lblTopText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblTopText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopText.ForeColor = System.Drawing.Color.White;
            this.lblTopText.Location = new System.Drawing.Point(45, 0);
            this.lblTopText.Name = "lblTopText";
            this.lblTopText.Size = new System.Drawing.Size(595, 50);
            this.lblTopText.TabIndex = 7;
            this.lblTopText.Text = "Welcome to Rectify11 Installer";
            this.lblTopText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBottom.Controls.Add(this.BtnBack);
            this.pnlBottom.Controls.Add(this.BtnNext);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 416);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(640, 60);
            this.pnlBottom.TabIndex = 5;
            this.pnlBottom.Visible = false;
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.ButtonText = "Back";
            this.BtnBack.Enabled = false;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.Color.Black;
            this.BtnBack.Location = new System.Drawing.Point(472, 15);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 28);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.ButtonText = "Next";
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNext.ForeColor = System.Drawing.Color.Black;
            this.BtnNext.Location = new System.Drawing.Point(553, 15);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 28);
            this.BtnNext.TabIndex = 0;
            this.BtnNext.Visible = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(640, 366);
            this.pnlMain.TabIndex = 11;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // FrmWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 476);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectify11 Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWizard_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTop;
        private Panel pnlBottom;
        private Panel pnlMain;
        private ThemedLabel lblTopText;
        private Controls.WinUIButton BtnBack;
        private Controls.WinUIButton BtnNext;
        private Controls.NavigationButton navigationButton1;
    }
}