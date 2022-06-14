namespace PresentacionWF.Forms
{
    partial class frmOutflowsPreload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutflowsPreload));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dtpMain = new System.Windows.Forms.DateTimePicker();
            this.dtpPreload = new System.Windows.Forms.DateTimePicker();
            this.gbxDaily = new System.Windows.Forms.GroupBox();
            this.gbxOthers = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ttipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBottom.Controls.Add(this.dtpPreload);
            this.pnlBottom.Controls.Add(this.dtpMain);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBottom.Location = new System.Drawing.Point(0, 233);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(256, 28);
            this.pnlBottom.TabIndex = 2;
            // 
            // dtpMain
            // 
            this.dtpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMain.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpMain.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpMain.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMain.Location = new System.Drawing.Point(538, -68);
            this.dtpMain.Name = "dtpMain";
            this.dtpMain.Size = new System.Drawing.Size(149, 20);
            this.dtpMain.TabIndex = 3;
            this.dtpMain.Value = new System.DateTime(2020, 7, 15, 0, 29, 0, 0);
            // 
            // dtpPreload
            // 
            this.dtpPreload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPreload.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpPreload.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpPreload.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPreload.Location = new System.Drawing.Point(104, 5);
            this.dtpPreload.Name = "dtpPreload";
            this.dtpPreload.Size = new System.Drawing.Size(149, 20);
            this.dtpPreload.TabIndex = 4;
            this.dtpPreload.Value = new System.DateTime(2020, 7, 15, 0, 29, 0, 0);
            // 
            // gbxDaily
            // 
            this.gbxDaily.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxDaily.Location = new System.Drawing.Point(12, 12);
            this.gbxDaily.Name = "gbxDaily";
            this.gbxDaily.Size = new System.Drawing.Size(235, 100);
            this.gbxDaily.TabIndex = 3;
            this.gbxDaily.TabStop = false;
            this.gbxDaily.Text = "Outflows daily";
            // 
            // gbxOthers
            // 
            this.gbxOthers.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxOthers.Location = new System.Drawing.Point(12, 118);
            this.gbxOthers.Name = "gbxOthers";
            this.gbxOthers.Size = new System.Drawing.Size(235, 85);
            this.gbxOthers.TabIndex = 4;
            this.gbxOthers.TabStop = false;
            this.gbxOthers.Text = "Others outflows";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImage = global::PresentacionWF.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(222, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 16;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // frmOutflowsPreload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(256, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxOthers);
            this.Controls.Add(this.gbxDaily);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOutflowsPreload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outflows preload";
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBottom;
        private DateTimePicker dtpMain;
        private DateTimePicker dtpPreload;
        private GroupBox gbxDaily;
        private GroupBox gbxOthers;
        private Button btnSave;
        private ToolTip ttipInfo;
    }
}