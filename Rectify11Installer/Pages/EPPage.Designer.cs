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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.darkAwareFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Rectify11Installer.Properties.Resources.ep;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 367);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your desired desktop experience";
            // 
            // chkW11
            // 
            this.chkW11.AutoSize = true;
            this.chkW11.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkW11.ForeColor = System.Drawing.Color.White;
            this.chkW11.Location = new System.Drawing.Point(475, 143);
            this.chkW11.Name = "chkW11";
            this.chkW11.Size = new System.Drawing.Size(130, 19);
            this.chkW11.TabIndex = 2;
            this.chkW11.Text = "Windows 11 Default";
            this.chkW11.UseVisualStyleBackColor = true;
            this.chkW11.CheckedChanged += new System.EventHandler(this.chkW11_CheckedChanged);
            // 
            // chkW10
            // 
            this.chkW10.AutoSize = true;
            this.chkW10.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkW10.Checked = true;
            this.chkW10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkW10.ForeColor = System.Drawing.Color.White;
            this.chkW10.Location = new System.Drawing.Point(310, 142);
            this.chkW10.Name = "chkW10";
            this.chkW10.Size = new System.Drawing.Size(155, 19);
            this.chkW10.TabIndex = 3;
            this.chkW10.TabStop = true;
            this.chkW10.Text = "Windows 10 Modernized";
            this.chkW10.UseVisualStyleBackColor = true;
            this.chkW10.CheckedChanged += new System.EventHandler(this.chkW10_CheckedChanged);
            // 
            // chkMicaExplorer
            // 
            this.chkMicaExplorer.AutoSize = true;
            this.chkMicaExplorer.Checked = true;
            this.chkMicaExplorer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMicaExplorer.ForeColor = System.Drawing.Color.White;
            this.chkMicaExplorer.Location = new System.Drawing.Point(3, 40);
            this.chkMicaExplorer.Name = "chkMicaExplorer";
            this.chkMicaExplorer.Size = new System.Drawing.Size(254, 21);
            this.chkMicaExplorer.TabIndex = 4;
            this.chkMicaExplorer.Text = "Extend mica to explorer navigation bar";
            this.chkMicaExplorer.UseVisualStyleBackColor = true;
            // 
            // darkAwareFlowLayoutPanel1
            // 
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkW10TaskB);
            this.darkAwareFlowLayoutPanel1.Controls.Add(this.chkMicaExplorer);
            this.darkAwareFlowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darkAwareFlowLayoutPanel1.Location = new System.Drawing.Point(307, 179);
            this.darkAwareFlowLayoutPanel1.Name = "darkAwareFlowLayoutPanel1";
            this.darkAwareFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.darkAwareFlowLayoutPanel1.Size = new System.Drawing.Size(262, 60);
            this.darkAwareFlowLayoutPanel1.TabIndex = 5;
            this.darkAwareFlowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.darkAwareFlowLayoutPanel1_Paint);
            // 
            // chkW10TaskB
            // 
            this.chkW10TaskB.AutoSize = true;
            this.chkW10TaskB.ForeColor = System.Drawing.Color.White;
            this.chkW10TaskB.Location = new System.Drawing.Point(3, 7);
            this.chkW10TaskB.Name = "chkW10TaskB";
            this.chkW10TaskB.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.chkW10TaskB.Size = new System.Drawing.Size(147, 27);
            this.chkW10TaskB.TabIndex = 5;
            this.chkW10TaskB.Text = "Windows 10 Taskbar";
            this.chkW10TaskB.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rectify11Installer.Properties.Resources._10start;
            this.pictureBox2.Location = new System.Drawing.Point(312, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Rectify11Installer.Properties.Resources._11start;
            this.pictureBox3.Location = new System.Drawing.Point(471, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(307, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 78);
            this.label3.TabIndex = 18;
            this.label3.Text = "These settings can later be configured in ExplorerPatcher properties. Extended ex" +
    "plorer mica may behave a bit buggy on Copper builds (25xxx).";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EPPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.darkAwareFlowLayoutPanel1);
            this.Controls.Add(this.chkW10);
            this.Controls.Add(this.chkW11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EPPage";
            this.WizardTopText = "Customize your Desktop";
            this.Load += new System.EventHandler(this.EPPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.darkAwareFlowLayoutPanel1.ResumeLayout(false);
            this.darkAwareFlowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
    }
}
