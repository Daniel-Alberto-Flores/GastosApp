namespace PresentacionWF.Forms
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.imlIncomes = new System.Windows.Forms.ImageList(this.components);
            this.ttipShowInfo = new System.Windows.Forms.ToolTip(this.components);
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.btnReturn);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(708, 22);
            this.pnlTop.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.ImageKey = "Back.png";
            this.btnReturn.ImageList = this.imlIncomes;
            this.btnReturn.Location = new System.Drawing.Point(1, 0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(78, 22);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturnClick);
            // 
            // imlIncomes
            // 
            this.imlIncomes.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlIncomes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIncomes.ImageStream")));
            this.imlIncomes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIncomes.Images.SetKeyName(0, "Back.png");
            // 
            // ttipShowInfo
            // 
            this.ttipShowInfo.BackColor = System.Drawing.Color.White;
            this.ttipShowInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipShowInfo.ToolTipTitle = "Info";
            // 
            // rtbHelp
            // 
            this.rtbHelp.BackColor = System.Drawing.SystemColors.Info;
            this.rtbHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHelp.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbHelp.Location = new System.Drawing.Point(0, 22);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.Size = new System.Drawing.Size(708, 458);
            this.rtbHelp.TabIndex = 9;
            this.rtbHelp.Text = "";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 480);
            this.Controls.Add(this.rtbHelp);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(724, 519);
            this.MinimumSize = new System.Drawing.Size(724, 519);
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHelpFormClosed);
            this.Shown += new System.EventHandler(this.FrmHelpShown);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTop;
        private Button btnReturn;
        private ImageList imlIncomes;
        private ToolTip ttipShowInfo;
        private RichTextBox rtbHelp;
    }
}