namespace PresentacionWF.Forms
{
    partial class frmAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.imlAbout = new System.Windows.Forms.ImageList(this.components);
            this.ttipShowInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pbxGastosApp = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDeveloped = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnSourceForge = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.btnLinkedIn = new System.Windows.Forms.Button();
            this.btnOpenSource = new System.Windows.Forms.Button();
            this.btnSQLite = new System.Windows.Forms.Button();
            this.btnCSharp = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGastosApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(184, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GastosApp";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.btnReturn);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(445, 22);
            this.pnlTop.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.ImageKey = "Back.png";
            this.btnReturn.ImageList = this.imlAbout;
            this.btnReturn.Location = new System.Drawing.Point(1, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(78, 22);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturnClick);
            // 
            // imlAbout
            // 
            this.imlAbout.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlAbout.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlAbout.ImageStream")));
            this.imlAbout.TransparentColor = System.Drawing.Color.Transparent;
            this.imlAbout.Images.SetKeyName(0, "Back.png");
            this.imlAbout.Images.SetKeyName(1, "GastosApp.png");
            this.imlAbout.Images.SetKeyName(2, "C#_logo.png");
            this.imlAbout.Images.SetKeyName(3, "SQLite.png");
            this.imlAbout.Images.SetKeyName(4, "GitHub.png");
            this.imlAbout.Images.SetKeyName(5, "LinkedIn.png");
            this.imlAbout.Images.SetKeyName(6, "SourceForge.png");
            // 
            // ttipShowInfo
            // 
            this.ttipShowInfo.BackColor = System.Drawing.Color.White;
            this.ttipShowInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipShowInfo.ToolTipTitle = "Info";
            // 
            // pbxGastosApp
            // 
            this.pbxGastosApp.BackgroundImage = global::PresentacionWF.Properties.Resources.GastosApp;
            this.pbxGastosApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxGastosApp.Location = new System.Drawing.Point(14, 35);
            this.pbxGastosApp.Name = "pbxGastosApp";
            this.pbxGastosApp.Size = new System.Drawing.Size(164, 128);
            this.pbxGastosApp.TabIndex = 9;
            this.pbxGastosApp.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.Location = new System.Drawing.Point(184, 75);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(142, 22);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Version: 2.1";
            // 
            // lblDeveloped
            // 
            this.lblDeveloped.AutoSize = true;
            this.lblDeveloped.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeveloped.Location = new System.Drawing.Point(184, 97);
            this.lblDeveloped.Name = "lblDeveloped";
            this.lblDeveloped.Size = new System.Drawing.Size(223, 16);
            this.lblDeveloped.TabIndex = 11;
            this.lblDeveloped.Text = "Developed by: Daniel Flores";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContact.Location = new System.Drawing.Point(184, 119);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(247, 16);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Contact: dan.alb.flo@gmail.com";
            // 
            // btnSourceForge
            // 
            this.btnSourceForge.BackColor = System.Drawing.Color.White;
            this.btnSourceForge.BackgroundImage = global::PresentacionWF.Properties.Resources.SourceForge;
            this.btnSourceForge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSourceForge.ImageKey = "(ninguna)";
            this.btnSourceForge.Location = new System.Drawing.Point(184, 144);
            this.btnSourceForge.Name = "btnSourceForge";
            this.btnSourceForge.Size = new System.Drawing.Size(75, 75);
            this.btnSourceForge.TabIndex = 13;
            this.btnSourceForge.UseVisualStyleBackColor = false;
            this.btnSourceForge.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackColor = System.Drawing.Color.White;
            this.btnGitHub.BackgroundImage = global::PresentacionWF.Properties.Resources.GitHub;
            this.btnGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGitHub.Location = new System.Drawing.Point(265, 144);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(75, 75);
            this.btnGitHub.TabIndex = 14;
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // btnLinkedIn
            // 
            this.btnLinkedIn.BackColor = System.Drawing.Color.White;
            this.btnLinkedIn.BackgroundImage = global::PresentacionWF.Properties.Resources.LinkedIn;
            this.btnLinkedIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLinkedIn.Location = new System.Drawing.Point(346, 144);
            this.btnLinkedIn.Name = "btnLinkedIn";
            this.btnLinkedIn.Size = new System.Drawing.Size(75, 75);
            this.btnLinkedIn.TabIndex = 15;
            this.btnLinkedIn.UseVisualStyleBackColor = false;
            this.btnLinkedIn.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // btnOpenSource
            // 
            this.btnOpenSource.BackColor = System.Drawing.Color.White;
            this.btnOpenSource.BackgroundImage = global::PresentacionWF.Properties.Resources.OpenSource;
            this.btnOpenSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenSource.Location = new System.Drawing.Point(184, 225);
            this.btnOpenSource.Name = "btnOpenSource";
            this.btnOpenSource.Size = new System.Drawing.Size(75, 75);
            this.btnOpenSource.TabIndex = 16;
            this.btnOpenSource.UseVisualStyleBackColor = false;
            this.btnOpenSource.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // btnSQLite
            // 
            this.btnSQLite.BackColor = System.Drawing.Color.White;
            this.btnSQLite.BackgroundImage = global::PresentacionWF.Properties.Resources.SQLite;
            this.btnSQLite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSQLite.Location = new System.Drawing.Point(346, 225);
            this.btnSQLite.Name = "btnSQLite";
            this.btnSQLite.Size = new System.Drawing.Size(75, 75);
            this.btnSQLite.TabIndex = 17;
            this.btnSQLite.UseVisualStyleBackColor = false;
            this.btnSQLite.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // btnCSharp
            // 
            this.btnCSharp.BackColor = System.Drawing.Color.White;
            this.btnCSharp.BackgroundImage = global::PresentacionWF.Properties.Resources.C__logo;
            this.btnCSharp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCSharp.Location = new System.Drawing.Point(265, 225);
            this.btnCSharp.Name = "btnCSharp";
            this.btnCSharp.Size = new System.Drawing.Size(75, 75);
            this.btnCSharp.TabIndex = 18;
            this.btnCSharp.UseVisualStyleBackColor = false;
            this.btnCSharp.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.SystemColors.Info;
            this.rtbInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbInfo.Location = new System.Drawing.Point(19, 169);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbInfo.Size = new System.Drawing.Size(159, 131);
            this.rtbInfo.TabIndex = 20;
            this.rtbInfo.Text = "Thank you very much for using this application.\nIf you have any questions, do not" +
    " hesitate to contact me.\n";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(445, 318);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.btnCSharp);
            this.Controls.Add(this.btnSQLite);
            this.Controls.Add(this.btnOpenSource);
            this.Controls.Add(this.btnLinkedIn);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.btnSourceForge);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblDeveloped);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pbxGastosApp);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAboutFormClosed);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGastosApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Panel pnlTop;
        private Button btnReturn;
        private ImageList imlAbout;
        private ToolTip ttipShowInfo;
        private PictureBox pbxGastosApp;
        private Label lblVersion;
        private Label lblDeveloped;
        private Label lblContact;
        private Button btnSourceForge;
        private Button btnGitHub;
        private Button btnLinkedIn;
        private Button btnOpenSource;
        private Button btnSQLite;
        private Button btnCSharp;
        private RichTextBox rtbInfo;
    }
}