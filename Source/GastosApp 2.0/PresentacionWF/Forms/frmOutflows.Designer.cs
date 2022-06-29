namespace PresentacionWF.Forms
{
    partial class frmOutflows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutflows));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.imlIncomes = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ttipShowInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnOutDailyOthersRemove = new System.Windows.Forms.Button();
            this.btnOutDailyRemove = new System.Windows.Forms.Button();
            this.btnOutSave = new System.Windows.Forms.Button();
            this.btnOutTypesCancel = new System.Windows.Forms.Button();
            this.btnOutTypesSave = new System.Windows.Forms.Button();
            this.btnOutTypesAdd = new System.Windows.Forms.Button();
            this.btnOutTypesEdit = new System.Windows.Forms.Button();
            this.btnOutTypesRemove = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dtpOutflows = new System.Windows.Forms.DateTimePicker();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.gbxListOut = new System.Windows.Forms.GroupBox();
            this.lblOutOthers = new System.Windows.Forms.Label();
            this.pnlOthers = new System.Windows.Forms.Panel();
            this.txtOutDailyOthers = new System.Windows.Forms.TextBox();
            this.lblOutDailyOthers = new System.Windows.Forms.Label();
            this.pnlDaily = new System.Windows.Forms.Panel();
            this.txtOutDailySub = new System.Windows.Forms.TextBox();
            this.lblOutDailySub = new System.Windows.Forms.Label();
            this.dgvListOutOthers = new System.Windows.Forms.DataGridView();
            this.dgvListOut = new System.Windows.Forms.DataGridView();
            this.lblOutDaily = new System.Windows.Forms.Label();
            this.gbxCalculatorOut = new System.Windows.Forms.GroupBox();
            this.txtOutAmount = new System.Windows.Forms.TextBox();
            this.cbxOutOperation = new System.Windows.Forms.ComboBox();
            this.lblOutValue = new System.Windows.Forms.Label();
            this.lblOutName = new System.Windows.Forms.Label();
            this.lblOutAmount = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.pbxCalculatorOut = new System.Windows.Forms.PictureBox();
            this.gbxOutTypes = new System.Windows.Forms.GroupBox();
            this.cbxOutTypeDaily = new System.Windows.Forms.ComboBox();
            this.txtOutNewType = new System.Windows.Forms.TextBox();
            this.lblOutTypeDaily = new System.Windows.Forms.Label();
            this.lblOutTypeNewName = new System.Windows.Forms.Label();
            this.dgvListOutTypes = new System.Windows.Forms.DataGridView();
            this.pnlOutTypes = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.gbxListOut.SuspendLayout();
            this.pnlOthers.SuspendLayout();
            this.pnlDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOutOthers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOut)).BeginInit();
            this.gbxCalculatorOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalculatorOut)).BeginInit();
            this.gbxOutTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOutTypes)).BeginInit();
            this.pnlOutTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.btnReturn);
            this.pnlTop.Controls.Add(this.dateTimePicker1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(567, 22);
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
            this.imlIncomes.Images.SetKeyName(1, "Add.png");
            this.imlIncomes.Images.SetKeyName(2, "Calculator.png");
            this.imlIncomes.Images.SetKeyName(3, "Cancel.png");
            this.imlIncomes.Images.SetKeyName(4, "Delete.png");
            this.imlIncomes.Images.SetKeyName(5, "Edit.png");
            this.imlIncomes.Images.SetKeyName(6, "Save.png");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1148, -152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2020, 7, 15, 0, 29, 0, 0);
            // 
            // ttipShowInfo
            // 
            this.ttipShowInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipShowInfo.ToolTipTitle = "Info";
            // 
            // btnOutDailyOthersRemove
            // 
            this.btnOutDailyOthersRemove.BackColor = System.Drawing.Color.White;
            this.btnOutDailyOthersRemove.BackgroundImage = global::PresentacionWF.Properties.Resources.Delete;
            this.btnOutDailyOthersRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutDailyOthersRemove.Location = new System.Drawing.Point(239, 2);
            this.btnOutDailyOthersRemove.Name = "btnOutDailyOthersRemove";
            this.btnOutDailyOthersRemove.Size = new System.Drawing.Size(30, 30);
            this.btnOutDailyOthersRemove.TabIndex = 4;
            this.btnOutDailyOthersRemove.UseVisualStyleBackColor = false;
            this.btnOutDailyOthersRemove.Click += new System.EventHandler(this.BtnRemoveClickFilter);
            // 
            // btnOutDailyRemove
            // 
            this.btnOutDailyRemove.BackColor = System.Drawing.Color.White;
            this.btnOutDailyRemove.BackgroundImage = global::PresentacionWF.Properties.Resources.Delete;
            this.btnOutDailyRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutDailyRemove.Location = new System.Drawing.Point(239, 1);
            this.btnOutDailyRemove.Name = "btnOutDailyRemove";
            this.btnOutDailyRemove.Size = new System.Drawing.Size(30, 30);
            this.btnOutDailyRemove.TabIndex = 4;
            this.btnOutDailyRemove.UseVisualStyleBackColor = false;
            this.btnOutDailyRemove.Click += new System.EventHandler(this.BtnRemoveClickFilter);
            // 
            // btnOutSave
            // 
            this.btnOutSave.BackColor = System.Drawing.Color.White;
            this.btnOutSave.BackgroundImage = global::PresentacionWF.Properties.Resources.Save;
            this.btnOutSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutSave.Location = new System.Drawing.Point(195, 66);
            this.btnOutSave.Name = "btnOutSave";
            this.btnOutSave.Size = new System.Drawing.Size(30, 30);
            this.btnOutSave.TabIndex = 15;
            this.btnOutSave.UseVisualStyleBackColor = false;
            this.btnOutSave.Click += new System.EventHandler(this.BtnOutSaveClick);
            // 
            // btnOutTypesCancel
            // 
            this.btnOutTypesCancel.BackColor = System.Drawing.Color.White;
            this.btnOutTypesCancel.BackgroundImage = global::PresentacionWF.Properties.Resources.Cancel;
            this.btnOutTypesCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutTypesCancel.Location = new System.Drawing.Point(188, 421);
            this.btnOutTypesCancel.Name = "btnOutTypesCancel";
            this.btnOutTypesCancel.Size = new System.Drawing.Size(30, 30);
            this.btnOutTypesCancel.TabIndex = 18;
            this.btnOutTypesCancel.UseVisualStyleBackColor = false;
            this.btnOutTypesCancel.Click += new System.EventHandler(this.BtnOutTypesCancelClick);
            // 
            // btnOutTypesSave
            // 
            this.btnOutTypesSave.BackColor = System.Drawing.Color.White;
            this.btnOutTypesSave.BackgroundImage = global::PresentacionWF.Properties.Resources.Save;
            this.btnOutTypesSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutTypesSave.Location = new System.Drawing.Point(219, 421);
            this.btnOutTypesSave.Name = "btnOutTypesSave";
            this.btnOutTypesSave.Size = new System.Drawing.Size(30, 30);
            this.btnOutTypesSave.TabIndex = 17;
            this.btnOutTypesSave.UseVisualStyleBackColor = false;
            this.btnOutTypesSave.Click += new System.EventHandler(this.BtnOutTypesSaveClick);
            // 
            // btnOutTypesAdd
            // 
            this.btnOutTypesAdd.BackColor = System.Drawing.Color.White;
            this.btnOutTypesAdd.BackgroundImage = global::PresentacionWF.Properties.Resources.Add;
            this.btnOutTypesAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutTypesAdd.Location = new System.Drawing.Point(210, 2);
            this.btnOutTypesAdd.Name = "btnOutTypesAdd";
            this.btnOutTypesAdd.Size = new System.Drawing.Size(30, 30);
            this.btnOutTypesAdd.TabIndex = 6;
            this.btnOutTypesAdd.UseVisualStyleBackColor = false;
            this.btnOutTypesAdd.Click += new System.EventHandler(this.BtnOutTypesAddClick);
            // 
            // btnOutTypesEdit
            // 
            this.btnOutTypesEdit.BackColor = System.Drawing.Color.White;
            this.btnOutTypesEdit.BackgroundImage = global::PresentacionWF.Properties.Resources.Edit;
            this.btnOutTypesEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutTypesEdit.Location = new System.Drawing.Point(146, 2);
            this.btnOutTypesEdit.Name = "btnOutTypesEdit";
            this.btnOutTypesEdit.Size = new System.Drawing.Size(30, 30);
            this.btnOutTypesEdit.TabIndex = 5;
            this.btnOutTypesEdit.UseVisualStyleBackColor = false;
            this.btnOutTypesEdit.Click += new System.EventHandler(this.BtnOutTypesEditClick);
            // 
            // btnOutTypesRemove
            // 
            this.btnOutTypesRemove.BackColor = System.Drawing.Color.White;
            this.btnOutTypesRemove.BackgroundImage = global::PresentacionWF.Properties.Resources.Delete;
            this.btnOutTypesRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOutTypesRemove.Location = new System.Drawing.Point(178, 2);
            this.btnOutTypesRemove.Name = "btnOutTypesRemove";
            this.btnOutTypesRemove.Size = new System.Drawing.Size(30, 30);
            this.btnOutTypesRemove.TabIndex = 4;
            this.btnOutTypesRemove.UseVisualStyleBackColor = false;
            this.btnOutTypesRemove.Click += new System.EventHandler(this.BtnOutTypesRemoveClick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBottom.Controls.Add(this.dtpOutflows);
            this.pnlBottom.Controls.Add(this.txtBalance);
            this.pnlBottom.Controls.Add(this.lblBalance);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBottom.Location = new System.Drawing.Point(0, 632);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(567, 28);
            this.pnlBottom.TabIndex = 9;
            // 
            // dtpOutflows
            // 
            this.dtpOutflows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOutflows.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpOutflows.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpOutflows.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutflows.Location = new System.Drawing.Point(414, 4);
            this.dtpOutflows.Name = "dtpOutflows";
            this.dtpOutflows.Size = new System.Drawing.Size(149, 20);
            this.dtpOutflows.TabIndex = 4;
            this.dtpOutflows.Value = new System.DateTime(2020, 7, 15, 0, 29, 0, 0);
            this.dtpOutflows.ValueChanged += new System.EventHandler(this.DtpOutflowsValueChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBalance.Location = new System.Drawing.Point(112, 3);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 23);
            this.txtBalance.TabIndex = 2;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBalance.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBalance.Location = new System.Drawing.Point(3, 8);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(103, 16);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance ($):";
            // 
            // gbxListOut
            // 
            this.gbxListOut.Controls.Add(this.lblOutOthers);
            this.gbxListOut.Controls.Add(this.pnlOthers);
            this.gbxListOut.Controls.Add(this.pnlDaily);
            this.gbxListOut.Controls.Add(this.dgvListOutOthers);
            this.gbxListOut.Controls.Add(this.dgvListOut);
            this.gbxListOut.Controls.Add(this.lblOutDaily);
            this.gbxListOut.Location = new System.Drawing.Point(7, 28);
            this.gbxListOut.Name = "gbxListOut";
            this.gbxListOut.Size = new System.Drawing.Size(288, 594);
            this.gbxListOut.TabIndex = 10;
            this.gbxListOut.TabStop = false;
            this.gbxListOut.Text = "Outflows list";
            // 
            // lblOutOthers
            // 
            this.lblOutOthers.AutoSize = true;
            this.lblOutOthers.Location = new System.Drawing.Point(14, 251);
            this.lblOutOthers.Name = "lblOutOthers";
            this.lblOutOthers.Size = new System.Drawing.Size(63, 16);
            this.lblOutOthers.TabIndex = 9;
            this.lblOutOthers.Text = "Others:";
            // 
            // pnlOthers
            // 
            this.pnlOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlOthers.Controls.Add(this.txtOutDailyOthers);
            this.pnlOthers.Controls.Add(this.lblOutDailyOthers);
            this.pnlOthers.Controls.Add(this.btnOutDailyOthersRemove);
            this.pnlOthers.Location = new System.Drawing.Point(6, 554);
            this.pnlOthers.Name = "pnlOthers";
            this.pnlOthers.Size = new System.Drawing.Size(272, 34);
            this.pnlOthers.TabIndex = 8;
            // 
            // txtOutDailyOthers
            // 
            this.txtOutDailyOthers.Location = new System.Drawing.Point(94, 5);
            this.txtOutDailyOthers.Name = "txtOutDailyOthers";
            this.txtOutDailyOthers.ReadOnly = true;
            this.txtOutDailyOthers.Size = new System.Drawing.Size(100, 23);
            this.txtOutDailyOthers.TabIndex = 6;
            // 
            // lblOutDailyOthers
            // 
            this.lblOutDailyOthers.AutoSize = true;
            this.lblOutDailyOthers.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutDailyOthers.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOutDailyOthers.Location = new System.Drawing.Point(8, 8);
            this.lblOutDailyOthers.Name = "lblOutDailyOthers";
            this.lblOutDailyOthers.Size = new System.Drawing.Size(79, 16);
            this.lblOutDailyOthers.TabIndex = 5;
            this.lblOutDailyOthers.Text = "Subtotal:";
            // 
            // pnlDaily
            // 
            this.pnlDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlDaily.Controls.Add(this.txtOutDailySub);
            this.pnlDaily.Controls.Add(this.lblOutDailySub);
            this.pnlDaily.Controls.Add(this.btnOutDailyRemove);
            this.pnlDaily.Location = new System.Drawing.Point(6, 214);
            this.pnlDaily.Name = "pnlDaily";
            this.pnlDaily.Size = new System.Drawing.Size(272, 34);
            this.pnlDaily.TabIndex = 2;
            // 
            // txtOutDailySub
            // 
            this.txtOutDailySub.Location = new System.Drawing.Point(94, 5);
            this.txtOutDailySub.Name = "txtOutDailySub";
            this.txtOutDailySub.ReadOnly = true;
            this.txtOutDailySub.Size = new System.Drawing.Size(100, 23);
            this.txtOutDailySub.TabIndex = 6;
            // 
            // lblOutDailySub
            // 
            this.lblOutDailySub.AutoSize = true;
            this.lblOutDailySub.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOutDailySub.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOutDailySub.Location = new System.Drawing.Point(8, 8);
            this.lblOutDailySub.Name = "lblOutDailySub";
            this.lblOutDailySub.Size = new System.Drawing.Size(79, 16);
            this.lblOutDailySub.TabIndex = 5;
            this.lblOutDailySub.Text = "Subtotal:";
            // 
            // dgvListOutOthers
            // 
            this.dgvListOutOthers.AllowUserToAddRows = false;
            this.dgvListOutOthers.AllowUserToDeleteRows = false;
            this.dgvListOutOthers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListOutOthers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListOutOthers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListOutOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOutOthers.Location = new System.Drawing.Point(6, 268);
            this.dgvListOutOthers.Name = "dgvListOutOthers";
            this.dgvListOutOthers.ReadOnly = true;
            this.dgvListOutOthers.RowHeadersVisible = false;
            this.dgvListOutOthers.RowTemplate.Height = 25;
            this.dgvListOutOthers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOutOthers.ShowCellToolTips = false;
            this.dgvListOutOthers.Size = new System.Drawing.Size(272, 286);
            this.dgvListOutOthers.TabIndex = 7;
            this.dgvListOutOthers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellClickFilter);
            this.dgvListOutOthers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoubleClickFilter);
            // 
            // dgvListOut
            // 
            this.dgvListOut.AllowUserToAddRows = false;
            this.dgvListOut.AllowUserToDeleteRows = false;
            this.dgvListOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListOut.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOut.Location = new System.Drawing.Point(6, 35);
            this.dgvListOut.Name = "dgvListOut";
            this.dgvListOut.ReadOnly = true;
            this.dgvListOut.RowHeadersVisible = false;
            this.dgvListOut.RowTemplate.Height = 25;
            this.dgvListOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOut.ShowCellToolTips = false;
            this.dgvListOut.Size = new System.Drawing.Size(272, 179);
            this.dgvListOut.TabIndex = 1;
            this.dgvListOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellClickFilter);
            this.dgvListOut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoubleClickFilter);
            // 
            // lblOutDaily
            // 
            this.lblOutDaily.AutoSize = true;
            this.lblOutDaily.Location = new System.Drawing.Point(14, 18);
            this.lblOutDaily.Name = "lblOutDaily";
            this.lblOutDaily.Size = new System.Drawing.Size(55, 16);
            this.lblOutDaily.TabIndex = 0;
            this.lblOutDaily.Text = "Daily:";
            // 
            // gbxCalculatorOut
            // 
            this.gbxCalculatorOut.Controls.Add(this.btnOutSave);
            this.gbxCalculatorOut.Controls.Add(this.txtOutAmount);
            this.gbxCalculatorOut.Controls.Add(this.cbxOutOperation);
            this.gbxCalculatorOut.Controls.Add(this.lblOutValue);
            this.gbxCalculatorOut.Controls.Add(this.lblOutName);
            this.gbxCalculatorOut.Controls.Add(this.lblOutAmount);
            this.gbxCalculatorOut.Controls.Add(this.lblOut);
            this.gbxCalculatorOut.Controls.Add(this.pbxCalculatorOut);
            this.gbxCalculatorOut.Location = new System.Drawing.Point(301, 28);
            this.gbxCalculatorOut.Name = "gbxCalculatorOut";
            this.gbxCalculatorOut.Size = new System.Drawing.Size(258, 106);
            this.gbxCalculatorOut.TabIndex = 11;
            this.gbxCalculatorOut.TabStop = false;
            this.gbxCalculatorOut.Text = "Calculator";
            // 
            // txtOutAmount
            // 
            this.txtOutAmount.Enabled = false;
            this.txtOutAmount.Location = new System.Drawing.Point(97, 70);
            this.txtOutAmount.Name = "txtOutAmount";
            this.txtOutAmount.Size = new System.Drawing.Size(92, 23);
            this.txtOutAmount.TabIndex = 14;
            this.txtOutAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtOutAmountKeyDown);
            this.txtOutAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKeyPressFilter);
            // 
            // cbxOutOperation
            // 
            this.cbxOutOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutOperation.DropDownWidth = 34;
            this.cbxOutOperation.FormattingEnabled = true;
            this.cbxOutOperation.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbxOutOperation.Location = new System.Drawing.Point(57, 69);
            this.cbxOutOperation.Name = "cbxOutOperation";
            this.cbxOutOperation.Size = new System.Drawing.Size(34, 24);
            this.cbxOutOperation.TabIndex = 13;
            // 
            // lblOutValue
            // 
            this.lblOutValue.AutoSize = true;
            this.lblOutValue.Location = new System.Drawing.Point(134, 51);
            this.lblOutValue.Name = "lblOutValue";
            this.lblOutValue.Size = new System.Drawing.Size(47, 16);
            this.lblOutValue.TabIndex = 12;
            this.lblOutValue.Text = "Value";
            // 
            // lblOutName
            // 
            this.lblOutName.AutoSize = true;
            this.lblOutName.Location = new System.Drawing.Point(134, 26);
            this.lblOutName.Name = "lblOutName";
            this.lblOutName.Size = new System.Drawing.Size(39, 16);
            this.lblOutName.TabIndex = 11;
            this.lblOutName.Text = "Name";
            // 
            // lblOutAmount
            // 
            this.lblOutAmount.AutoSize = true;
            this.lblOutAmount.Location = new System.Drawing.Point(33, 51);
            this.lblOutAmount.Name = "lblOutAmount";
            this.lblOutAmount.Size = new System.Drawing.Size(95, 16);
            this.lblOutAmount.TabIndex = 10;
            this.lblOutAmount.Text = "Amount ($):";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(57, 26);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(71, 16);
            this.lblOut.TabIndex = 9;
            this.lblOut.Text = "Outflow:";
            // 
            // pbxCalculatorOut
            // 
            this.pbxCalculatorOut.BackgroundImage = global::PresentacionWF.Properties.Resources.Calculator;
            this.pbxCalculatorOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCalculatorOut.ErrorImage = null;
            this.pbxCalculatorOut.Location = new System.Drawing.Point(6, 18);
            this.pbxCalculatorOut.Name = "pbxCalculatorOut";
            this.pbxCalculatorOut.Size = new System.Drawing.Size(30, 30);
            this.pbxCalculatorOut.TabIndex = 0;
            this.pbxCalculatorOut.TabStop = false;
            // 
            // gbxOutTypes
            // 
            this.gbxOutTypes.Controls.Add(this.btnOutTypesCancel);
            this.gbxOutTypes.Controls.Add(this.btnOutTypesSave);
            this.gbxOutTypes.Controls.Add(this.cbxOutTypeDaily);
            this.gbxOutTypes.Controls.Add(this.txtOutNewType);
            this.gbxOutTypes.Controls.Add(this.lblOutTypeDaily);
            this.gbxOutTypes.Controls.Add(this.lblOutTypeNewName);
            this.gbxOutTypes.Controls.Add(this.dgvListOutTypes);
            this.gbxOutTypes.Controls.Add(this.pnlOutTypes);
            this.gbxOutTypes.Location = new System.Drawing.Point(301, 139);
            this.gbxOutTypes.Name = "gbxOutTypes";
            this.gbxOutTypes.Size = new System.Drawing.Size(258, 483);
            this.gbxOutTypes.TabIndex = 12;
            this.gbxOutTypes.TabStop = false;
            this.gbxOutTypes.Text = "Add outflow types:";
            // 
            // cbxOutTypeDaily
            // 
            this.cbxOutTypeDaily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutTypeDaily.DropDownWidth = 34;
            this.cbxOutTypeDaily.FormattingEnabled = true;
            this.cbxOutTypeDaily.Location = new System.Drawing.Point(71, 452);
            this.cbxOutTypeDaily.Name = "cbxOutTypeDaily";
            this.cbxOutTypeDaily.Size = new System.Drawing.Size(56, 24);
            this.cbxOutTypeDaily.TabIndex = 16;
            // 
            // txtOutNewType
            // 
            this.txtOutNewType.Location = new System.Drawing.Point(71, 425);
            this.txtOutNewType.Name = "txtOutNewType";
            this.txtOutNewType.Size = new System.Drawing.Size(111, 23);
            this.txtOutNewType.TabIndex = 15;
            this.txtOutNewType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtOutNewTypeKeyDown);
            // 
            // lblOutTypeDaily
            // 
            this.lblOutTypeDaily.AutoSize = true;
            this.lblOutTypeDaily.Location = new System.Drawing.Point(10, 455);
            this.lblOutTypeDaily.Name = "lblOutTypeDaily";
            this.lblOutTypeDaily.Size = new System.Drawing.Size(55, 16);
            this.lblOutTypeDaily.TabIndex = 14;
            this.lblOutTypeDaily.Text = "Daily:";
            // 
            // lblOutTypeNewName
            // 
            this.lblOutTypeNewName.AutoSize = true;
            this.lblOutTypeNewName.Location = new System.Drawing.Point(18, 428);
            this.lblOutTypeNewName.Name = "lblOutTypeNewName";
            this.lblOutTypeNewName.Size = new System.Drawing.Size(47, 16);
            this.lblOutTypeNewName.TabIndex = 13;
            this.lblOutTypeNewName.Text = "Name:";
            // 
            // dgvListOutTypes
            // 
            this.dgvListOutTypes.AllowUserToAddRows = false;
            this.dgvListOutTypes.AllowUserToDeleteRows = false;
            this.dgvListOutTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListOutTypes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListOutTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListOutTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOutTypes.Location = new System.Drawing.Point(6, 22);
            this.dgvListOutTypes.Name = "dgvListOutTypes";
            this.dgvListOutTypes.ReadOnly = true;
            this.dgvListOutTypes.RowHeadersVisible = false;
            this.dgvListOutTypes.RowTemplate.Height = 25;
            this.dgvListOutTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListOutTypes.ShowCellToolTips = false;
            this.dgvListOutTypes.Size = new System.Drawing.Size(243, 358);
            this.dgvListOutTypes.TabIndex = 3;
            this.dgvListOutTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListOutTypesCellClick);
            this.dgvListOutTypes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListOutTypesDoubleClick);
            // 
            // pnlOutTypes
            // 
            this.pnlOutTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlOutTypes.Controls.Add(this.btnOutTypesAdd);
            this.pnlOutTypes.Controls.Add(this.btnOutTypesEdit);
            this.pnlOutTypes.Controls.Add(this.btnOutTypesRemove);
            this.pnlOutTypes.Location = new System.Drawing.Point(6, 380);
            this.pnlOutTypes.Name = "pnlOutTypes";
            this.pnlOutTypes.Size = new System.Drawing.Size(243, 34);
            this.pnlOutTypes.TabIndex = 4;
            // 
            // frmOutflows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(567, 660);
            this.Controls.Add(this.gbxOutTypes);
            this.Controls.Add(this.gbxCalculatorOut);
            this.Controls.Add(this.gbxListOut);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 699);
            this.MinimumSize = new System.Drawing.Size(583, 699);
            this.Name = "frmOutflows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outflows";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOutflowsFormClosed);
            this.Shown += new System.EventHandler(this.FrmOutflowsShown);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.gbxListOut.ResumeLayout(false);
            this.gbxListOut.PerformLayout();
            this.pnlOthers.ResumeLayout(false);
            this.pnlOthers.PerformLayout();
            this.pnlDaily.ResumeLayout(false);
            this.pnlDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOutOthers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOut)).EndInit();
            this.gbxCalculatorOut.ResumeLayout(false);
            this.gbxCalculatorOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalculatorOut)).EndInit();
            this.gbxOutTypes.ResumeLayout(false);
            this.gbxOutTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOutTypes)).EndInit();
            this.pnlOutTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTop;
        private Button btnReturn;
        private DateTimePicker dateTimePicker1;
        private ImageList imlIncomes;
        private ToolTip ttipShowInfo;
        private Panel pnlBottom;
        private TextBox txtBalance;
        private Label lblBalance;
        private DateTimePicker dtpOutflows;
        private GroupBox gbxListOut;
        private Label lblOutOthers;
        private Panel pnlOthers;
        private TextBox txtOutDailyOthers;
        private Label lblOutDailyOthers;
        private Button btnOutDailyOthersRemove;
        private Panel pnlDaily;
        private TextBox txtOutDailySub;
        private Label lblOutDailySub;
        private Button btnOutDailyRemove;
        private DataGridView dgvListOutOthers;
        private DataGridView dgvListOut;
        private Label lblOutDaily;
        private GroupBox gbxCalculatorOut;
        private Button btnOutSave;
        private TextBox txtOutAmount;
        private ComboBox cbxOutOperation;
        private Label lblOutValue;
        private Label lblOutName;
        private Label lblOutAmount;
        private Label lblOut;
        private PictureBox pbxCalculatorOut;
        private GroupBox gbxOutTypes;
        private Button btnOutTypesCancel;
        private Button btnOutTypesSave;
        private ComboBox cbxOutTypeDaily;
        private TextBox txtOutNewType;
        private Label lblOutTypeDaily;
        private Label lblOutTypeNewName;
        private DataGridView dgvListOutTypes;
        private Panel pnlOutTypes;
        private Button btnOutTypesAdd;
        private Button btnOutTypesEdit;
        private Button btnOutTypesRemove;
    }
}