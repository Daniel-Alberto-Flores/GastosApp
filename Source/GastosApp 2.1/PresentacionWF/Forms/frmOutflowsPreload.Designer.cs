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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutflowsPreload));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dtpPreload = new System.Windows.Forms.DateTimePicker();
            this.gbxDaily = new System.Windows.Forms.GroupBox();
            this.dgvListOut = new System.Windows.Forms.DataGridView();
            this.gbxOthers = new System.Windows.Forms.GroupBox();
            this.dgvListOutOthers = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.ttipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.gbxDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOut)).BeginInit();
            this.gbxOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOutOthers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBottom.Controls.Add(this.dtpPreload);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBottom.Location = new System.Drawing.Point(0, 378);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(263, 28);
            this.pnlBottom.TabIndex = 2;
            // 
            // dtpPreload
            // 
            this.dtpPreload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPreload.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpPreload.Enabled = false;
            this.dtpPreload.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpPreload.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPreload.Location = new System.Drawing.Point(111, 5);
            this.dtpPreload.Name = "dtpPreload";
            this.dtpPreload.Size = new System.Drawing.Size(149, 20);
            this.dtpPreload.TabIndex = 4;
            this.dtpPreload.Value = new System.DateTime(2020, 7, 15, 0, 29, 0, 0);
            // 
            // gbxDaily
            // 
            this.gbxDaily.Controls.Add(this.dgvListOut);
            this.gbxDaily.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxDaily.Location = new System.Drawing.Point(12, 12);
            this.gbxDaily.Name = "gbxDaily";
            this.gbxDaily.Size = new System.Drawing.Size(239, 160);
            this.gbxDaily.TabIndex = 3;
            this.gbxDaily.TabStop = false;
            this.gbxDaily.Text = "Outflows daily";
            // 
            // dgvListOut
            // 
            this.dgvListOut.AllowUserToAddRows = false;
            this.dgvListOut.AllowUserToDeleteRows = false;
            this.dgvListOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListOut.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOut.Location = new System.Drawing.Point(6, 22);
            this.dgvListOut.Name = "dgvListOut";
            this.dgvListOut.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListOut.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListOut.RowTemplate.Height = 25;
            this.dgvListOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOut.Size = new System.Drawing.Size(227, 124);
            this.dgvListOut.TabIndex = 2;
            // 
            // gbxOthers
            // 
            this.gbxOthers.Controls.Add(this.dgvListOutOthers);
            this.gbxOthers.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxOthers.Location = new System.Drawing.Point(12, 178);
            this.gbxOthers.Name = "gbxOthers";
            this.gbxOthers.Size = new System.Drawing.Size(239, 163);
            this.gbxOthers.TabIndex = 4;
            this.gbxOthers.TabStop = false;
            this.gbxOthers.Text = "Others outflows";
            // 
            // dgvListOutOthers
            // 
            this.dgvListOutOthers.AllowUserToAddRows = false;
            this.dgvListOutOthers.AllowUserToDeleteRows = false;
            this.dgvListOutOthers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListOutOthers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListOutOthers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListOutOthers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListOutOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOutOthers.Location = new System.Drawing.Point(6, 22);
            this.dgvListOutOthers.Name = "dgvListOutOthers";
            this.dgvListOutOthers.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListOutOthers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListOutOthers.RowTemplate.Height = 25;
            this.dgvListOutOthers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOutOthers.Size = new System.Drawing.Size(227, 124);
            this.dgvListOutOthers.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImage = global::PresentacionWF.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(221, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 30);
            this.btnSave.TabIndex = 16;
            this.ttipInfo.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // frmOutflowsPreload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(263, 406);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxOthers);
            this.Controls.Add(this.gbxDaily);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(279, 445);
            this.MinimumSize = new System.Drawing.Size(279, 445);
            this.Name = "frmOutflowsPreload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outflows preload";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOutflowsPreloadFormClosed);
            this.Shown += new System.EventHandler(this.FrmOutflowsPreloadShown);
            this.pnlBottom.ResumeLayout(false);
            this.gbxDaily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOut)).EndInit();
            this.gbxOthers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOutOthers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBottom;
        private DateTimePicker dtpPreload;
        private GroupBox gbxDaily;
        private GroupBox gbxOthers;
        private Button btnSave;
        private ToolTip ttipInfo;
        private DataGridView dgvListOut;
        private DataGridView dgvListOutOthers;
    }
}