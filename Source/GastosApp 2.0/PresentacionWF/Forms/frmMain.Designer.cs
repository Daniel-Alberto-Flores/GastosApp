namespace PresentacionWF.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnLanguageSave = new System.Windows.Forms.Button();
            this.imlMain = new System.Windows.Forms.ImageList(this.components);
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnOutflows = new System.Windows.Forms.Button();
            this.btnIncomes = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.ttipShowInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBottom.Controls.Add(this.btnLanguageSave);
            this.pnlBottom.Controls.Add(this.cbxLanguage);
            this.pnlBottom.Controls.Add(this.lblLanguage);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBottom.Location = new System.Drawing.Point(0, 297);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(235, 30);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnLanguageSave
            // 
            this.btnLanguageSave.BackColor = System.Drawing.Color.White;
            this.btnLanguageSave.BackgroundImage = global::PresentacionWF.Properties.Resources.Save;
            this.btnLanguageSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLanguageSave.ImageList = this.imlMain;
            this.btnLanguageSave.Location = new System.Drawing.Point(202, 0);
            this.btnLanguageSave.Name = "btnLanguageSave";
            this.btnLanguageSave.Size = new System.Drawing.Size(30, 30);
            this.btnLanguageSave.TabIndex = 18;
            this.ttipShowInfo.SetToolTip(this.btnLanguageSave, "Save language");
            this.btnLanguageSave.UseVisualStyleBackColor = false;
            this.btnLanguageSave.Click += new System.EventHandler(this.BtnLanguageSaveClick);
            // 
            // imlMain
            // 
            this.imlMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMain.ImageStream")));
            this.imlMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imlMain.Images.SetKeyName(0, "incomesIcon.png");
            this.imlMain.Images.SetKeyName(1, "notesIcon.png");
            this.imlMain.Images.SetKeyName(2, "outflowsIcon.png");
            this.imlMain.Images.SetKeyName(3, "helpIcon.png");
            this.imlMain.Images.SetKeyName(4, "Save.png");
            this.imlMain.Images.SetKeyName(5, "About.png");
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.DropDownWidth = 34;
            this.cbxLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "English",
            "Español"});
            this.cbxLanguage.Location = new System.Drawing.Point(97, 6);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(100, 21);
            this.cbxLanguage.TabIndex = 17;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLanguage.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLanguage.Location = new System.Drawing.Point(12, 8);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(79, 16);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Language:";
            // 
            // btnOutflows
            // 
            this.btnOutflows.BackColor = System.Drawing.Color.White;
            this.btnOutflows.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOutflows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutflows.ImageKey = "outflowsIcon.png";
            this.btnOutflows.ImageList = this.imlMain;
            this.btnOutflows.Location = new System.Drawing.Point(47, 25);
            this.btnOutflows.Name = "btnOutflows";
            this.btnOutflows.Size = new System.Drawing.Size(142, 48);
            this.btnOutflows.TabIndex = 3;
            this.btnOutflows.Text = "Outflows";
            this.btnOutflows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOutflows.UseVisualStyleBackColor = false;
            this.btnOutflows.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // btnIncomes
            // 
            this.btnIncomes.BackColor = System.Drawing.Color.White;
            this.btnIncomes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncomes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncomes.ImageKey = "incomesIcon.png";
            this.btnIncomes.ImageList = this.imlMain;
            this.btnIncomes.Location = new System.Drawing.Point(47, 79);
            this.btnIncomes.Name = "btnIncomes";
            this.btnIncomes.Size = new System.Drawing.Size(142, 48);
            this.btnIncomes.TabIndex = 4;
            this.btnIncomes.Text = "Incomes";
            this.btnIncomes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncomes.UseVisualStyleBackColor = false;
            this.btnIncomes.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // btnNotes
            // 
            this.btnNotes.BackColor = System.Drawing.Color.White;
            this.btnNotes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.ImageKey = "notesIcon.png";
            this.btnNotes.ImageList = this.imlMain;
            this.btnNotes.Location = new System.Drawing.Point(47, 133);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(142, 48);
            this.btnNotes.TabIndex = 5;
            this.btnNotes.Text = "Notes";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNotes.UseVisualStyleBackColor = false;
            this.btnNotes.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.White;
            this.btnHelp.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.ImageKey = "helpIcon.png";
            this.btnHelp.ImageList = this.imlMain;
            this.btnHelp.Location = new System.Drawing.Point(47, 187);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(142, 48);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // ttipShowInfo
            // 
            this.ttipShowInfo.BackColor = System.Drawing.Color.White;
            this.ttipShowInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipShowInfo.ToolTipTitle = "Info";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.ImageKey = "About.png";
            this.btnAbout.ImageList = this.imlMain;
            this.btnAbout.Location = new System.Drawing.Point(47, 241);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(142, 48);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.BtnClickFilter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(235, 327);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnIncomes);
            this.Controls.Add(this.btnOutflows);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(251, 366);
            this.MinimumSize = new System.Drawing.Size(251, 366);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainFormClosing);
            this.Shown += new System.EventHandler(this.FrmMainShown);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBottom;
        private Button btnOutflows;
        private ImageList imlMain;
        private Button btnIncomes;
        private Button btnNotes;
        private Label lblLanguage;
        private ComboBox cbxLanguage;
        private Button btnHelp;
        private Button btnLanguageSave;
        private ToolTip ttipShowInfo;
        private Button btnAbout;
    }
}