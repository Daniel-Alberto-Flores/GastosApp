namespace PresentacionWF.Forms
{
    partial class frmIncomes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncomes));
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dtpIncomes = new System.Windows.Forms.DateTimePicker();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.gbxIncTypes = new System.Windows.Forms.GroupBox();
            this.btnIncTypesCancel = new System.Windows.Forms.Button();
            this.btnIncTypesSave = new System.Windows.Forms.Button();
            this.txtIncNewType = new System.Windows.Forms.TextBox();
            this.lblIncTypeNewName = new System.Windows.Forms.Label();
            this.dgvListIncTypes = new System.Windows.Forms.DataGridView();
            this.pnlIncTypes = new System.Windows.Forms.Panel();
            this.btnIncTypesAdd = new System.Windows.Forms.Button();
            this.btnIncTypesEdit = new System.Windows.Forms.Button();
            this.btnIncTypesRemove = new System.Windows.Forms.Button();
            this.gbxCalculatorInc = new System.Windows.Forms.GroupBox();
            this.btnIncSave = new System.Windows.Forms.Button();
            this.imlIncomes = new System.Windows.Forms.ImageList(this.components);
            this.txtIncAmount = new System.Windows.Forms.TextBox();
            this.cbxIncOperation = new System.Windows.Forms.ComboBox();
            this.lblIncValue = new System.Windows.Forms.Label();
            this.lblIncName = new System.Windows.Forms.Label();
            this.lblIncAmount = new System.Windows.Forms.Label();
            this.lblInc = new System.Windows.Forms.Label();
            this.pbxCalculatorInc = new System.Windows.Forms.PictureBox();
            this.gbxListInc = new System.Windows.Forms.GroupBox();
            this.pnlInc = new System.Windows.Forms.Panel();
            this.txtIncSub = new System.Windows.Forms.TextBox();
            this.lblIncSub = new System.Windows.Forms.Label();
            this.btnIncRemove = new System.Windows.Forms.Button();
            this.dgvListInc = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.ttipShowInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom.SuspendLayout();
            this.gbxIncTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListIncTypes)).BeginInit();
            this.pnlIncTypes.SuspendLayout();
            this.gbxCalculatorInc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalculatorInc)).BeginInit();
            this.gbxListInc.SuspendLayout();
            this.pnlInc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInc)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBottom.Controls.Add(this.dtpIncomes);
            this.pnlBottom.Controls.Add(this.txtBalance);
            this.pnlBottom.Controls.Add(this.lblBalance);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlBottom.Location = new System.Drawing.Point(0, 632);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(567, 28);
            this.pnlBottom.TabIndex = 2;
            // 
            // dtpIncomes
            // 
            this.dtpIncomes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIncomes.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpIncomes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpIncomes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIncomes.Location = new System.Drawing.Point(414, 4);
            this.dtpIncomes.Name = "dtpIncomes";
            this.dtpIncomes.Size = new System.Drawing.Size(149, 20);
            this.dtpIncomes.TabIndex = 3;
            this.dtpIncomes.Value = new System.DateTime(2020, 7, 15, 0, 29, 0, 0);
            this.dtpIncomes.ValueChanged += new System.EventHandler(this.DtpIncomesValueChanged);
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
            this.lblBalance.Location = new System.Drawing.Point(3, 6);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(103, 16);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance ($):";
            // 
            // gbxIncTypes
            // 
            this.gbxIncTypes.Controls.Add(this.btnIncTypesCancel);
            this.gbxIncTypes.Controls.Add(this.btnIncTypesSave);
            this.gbxIncTypes.Controls.Add(this.txtIncNewType);
            this.gbxIncTypes.Controls.Add(this.lblIncTypeNewName);
            this.gbxIncTypes.Controls.Add(this.dgvListIncTypes);
            this.gbxIncTypes.Controls.Add(this.pnlIncTypes);
            this.gbxIncTypes.Location = new System.Drawing.Point(301, 139);
            this.gbxIncTypes.Name = "gbxIncTypes";
            this.gbxIncTypes.Size = new System.Drawing.Size(258, 483);
            this.gbxIncTypes.TabIndex = 6;
            this.gbxIncTypes.TabStop = false;
            this.gbxIncTypes.Text = "Add income types";
            // 
            // btnIncTypesCancel
            // 
            this.btnIncTypesCancel.BackColor = System.Drawing.Color.White;
            this.btnIncTypesCancel.BackgroundImage = global::PresentacionWF.Properties.Resources.Cancel;
            this.btnIncTypesCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncTypesCancel.Location = new System.Drawing.Point(188, 447);
            this.btnIncTypesCancel.Name = "btnIncTypesCancel";
            this.btnIncTypesCancel.Size = new System.Drawing.Size(30, 30);
            this.btnIncTypesCancel.TabIndex = 18;
            this.btnIncTypesCancel.UseVisualStyleBackColor = false;
            this.btnIncTypesCancel.Click += new System.EventHandler(this.BtnIncTypesCancelClick);
            // 
            // btnIncTypesSave
            // 
            this.btnIncTypesSave.BackColor = System.Drawing.Color.White;
            this.btnIncTypesSave.BackgroundImage = global::PresentacionWF.Properties.Resources.Save;
            this.btnIncTypesSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncTypesSave.Location = new System.Drawing.Point(219, 447);
            this.btnIncTypesSave.Name = "btnIncTypesSave";
            this.btnIncTypesSave.Size = new System.Drawing.Size(30, 30);
            this.btnIncTypesSave.TabIndex = 17;
            this.btnIncTypesSave.UseVisualStyleBackColor = false;
            this.btnIncTypesSave.Click += new System.EventHandler(this.BtnIncTypesSaveClick);
            // 
            // txtIncNewType
            // 
            this.txtIncNewType.Location = new System.Drawing.Point(71, 452);
            this.txtIncNewType.Name = "txtIncNewType";
            this.txtIncNewType.Size = new System.Drawing.Size(111, 23);
            this.txtIncNewType.TabIndex = 15;
            this.txtIncNewType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIncNewTypeKeyDown);
            // 
            // lblIncTypeNewName
            // 
            this.lblIncTypeNewName.AutoSize = true;
            this.lblIncTypeNewName.Location = new System.Drawing.Point(18, 455);
            this.lblIncTypeNewName.Name = "lblIncTypeNewName";
            this.lblIncTypeNewName.Size = new System.Drawing.Size(47, 16);
            this.lblIncTypeNewName.TabIndex = 13;
            this.lblIncTypeNewName.Text = "Name:";
            // 
            // dgvListIncTypes
            // 
            this.dgvListIncTypes.AllowUserToAddRows = false;
            this.dgvListIncTypes.AllowUserToDeleteRows = false;
            this.dgvListIncTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListIncTypes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListIncTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListIncTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListIncTypes.Location = new System.Drawing.Point(6, 22);
            this.dgvListIncTypes.Name = "dgvListIncTypes";
            this.dgvListIncTypes.ReadOnly = true;
            this.dgvListIncTypes.RowHeadersVisible = false;
            this.dgvListIncTypes.RowTemplate.Height = 25;
            this.dgvListIncTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListIncTypes.ShowCellToolTips = false;
            this.dgvListIncTypes.Size = new System.Drawing.Size(243, 386);
            this.dgvListIncTypes.TabIndex = 3;
            this.dgvListIncTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellClickFilter);
            this.dgvListIncTypes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListIncTypesCellDoubleClick);
            // 
            // pnlIncTypes
            // 
            this.pnlIncTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlIncTypes.Controls.Add(this.btnIncTypesAdd);
            this.pnlIncTypes.Controls.Add(this.btnIncTypesEdit);
            this.pnlIncTypes.Controls.Add(this.btnIncTypesRemove);
            this.pnlIncTypes.Location = new System.Drawing.Point(6, 408);
            this.pnlIncTypes.Name = "pnlIncTypes";
            this.pnlIncTypes.Size = new System.Drawing.Size(243, 34);
            this.pnlIncTypes.TabIndex = 4;
            // 
            // btnIncTypesAdd
            // 
            this.btnIncTypesAdd.BackColor = System.Drawing.Color.White;
            this.btnIncTypesAdd.BackgroundImage = global::PresentacionWF.Properties.Resources.Add;
            this.btnIncTypesAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncTypesAdd.Location = new System.Drawing.Point(210, 2);
            this.btnIncTypesAdd.Name = "btnIncTypesAdd";
            this.btnIncTypesAdd.Size = new System.Drawing.Size(30, 30);
            this.btnIncTypesAdd.TabIndex = 6;
            this.btnIncTypesAdd.UseVisualStyleBackColor = false;
            this.btnIncTypesAdd.Click += new System.EventHandler(this.BtnIncTypesAddClick);
            // 
            // btnIncTypesEdit
            // 
            this.btnIncTypesEdit.BackColor = System.Drawing.Color.White;
            this.btnIncTypesEdit.BackgroundImage = global::PresentacionWF.Properties.Resources.Edit;
            this.btnIncTypesEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncTypesEdit.Location = new System.Drawing.Point(146, 2);
            this.btnIncTypesEdit.Name = "btnIncTypesEdit";
            this.btnIncTypesEdit.Size = new System.Drawing.Size(30, 30);
            this.btnIncTypesEdit.TabIndex = 5;
            this.btnIncTypesEdit.UseVisualStyleBackColor = false;
            this.btnIncTypesEdit.Click += new System.EventHandler(this.BtnIncTypesEditClick);
            // 
            // btnIncTypesRemove
            // 
            this.btnIncTypesRemove.BackColor = System.Drawing.Color.White;
            this.btnIncTypesRemove.BackgroundImage = global::PresentacionWF.Properties.Resources.Delete;
            this.btnIncTypesRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncTypesRemove.Location = new System.Drawing.Point(178, 2);
            this.btnIncTypesRemove.Name = "btnIncTypesRemove";
            this.btnIncTypesRemove.Size = new System.Drawing.Size(30, 30);
            this.btnIncTypesRemove.TabIndex = 4;
            this.btnIncTypesRemove.UseVisualStyleBackColor = false;
            this.btnIncTypesRemove.Click += new System.EventHandler(this.BtnIncTypesRemoveClick);
            // 
            // gbxCalculatorInc
            // 
            this.gbxCalculatorInc.Controls.Add(this.btnIncSave);
            this.gbxCalculatorInc.Controls.Add(this.txtIncAmount);
            this.gbxCalculatorInc.Controls.Add(this.cbxIncOperation);
            this.gbxCalculatorInc.Controls.Add(this.lblIncValue);
            this.gbxCalculatorInc.Controls.Add(this.lblIncName);
            this.gbxCalculatorInc.Controls.Add(this.lblIncAmount);
            this.gbxCalculatorInc.Controls.Add(this.lblInc);
            this.gbxCalculatorInc.Controls.Add(this.pbxCalculatorInc);
            this.gbxCalculatorInc.Location = new System.Drawing.Point(301, 28);
            this.gbxCalculatorInc.Name = "gbxCalculatorInc";
            this.gbxCalculatorInc.Size = new System.Drawing.Size(258, 106);
            this.gbxCalculatorInc.TabIndex = 5;
            this.gbxCalculatorInc.TabStop = false;
            this.gbxCalculatorInc.Text = "Calculator";
            // 
            // btnIncSave
            // 
            this.btnIncSave.BackColor = System.Drawing.Color.White;
            this.btnIncSave.BackgroundImage = global::PresentacionWF.Properties.Resources.Save;
            this.btnIncSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncSave.ImageKey = "(ninguna)";
            this.btnIncSave.ImageList = this.imlIncomes;
            this.btnIncSave.Location = new System.Drawing.Point(195, 66);
            this.btnIncSave.Name = "btnIncSave";
            this.btnIncSave.Size = new System.Drawing.Size(30, 30);
            this.btnIncSave.TabIndex = 15;
            this.btnIncSave.UseVisualStyleBackColor = false;
            this.btnIncSave.Click += new System.EventHandler(this.BtnIncSaveClick);
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
            // txtIncAmount
            // 
            this.txtIncAmount.Enabled = false;
            this.txtIncAmount.Location = new System.Drawing.Point(97, 70);
            this.txtIncAmount.Name = "txtIncAmount";
            this.txtIncAmount.Size = new System.Drawing.Size(92, 23);
            this.txtIncAmount.TabIndex = 14;
            this.txtIncAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIncAmountKeyDown);
            this.txtIncAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKeyPressFilter);
            // 
            // cbxIncOperation
            // 
            this.cbxIncOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIncOperation.DropDownWidth = 34;
            this.cbxIncOperation.FormattingEnabled = true;
            this.cbxIncOperation.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbxIncOperation.Location = new System.Drawing.Point(57, 69);
            this.cbxIncOperation.Name = "cbxIncOperation";
            this.cbxIncOperation.Size = new System.Drawing.Size(34, 24);
            this.cbxIncOperation.TabIndex = 13;
            // 
            // lblIncValue
            // 
            this.lblIncValue.AutoSize = true;
            this.lblIncValue.Location = new System.Drawing.Point(134, 51);
            this.lblIncValue.Name = "lblIncValue";
            this.lblIncValue.Size = new System.Drawing.Size(47, 16);
            this.lblIncValue.TabIndex = 12;
            this.lblIncValue.Text = "Value";
            // 
            // lblIncName
            // 
            this.lblIncName.AutoSize = true;
            this.lblIncName.Location = new System.Drawing.Point(134, 26);
            this.lblIncName.Name = "lblIncName";
            this.lblIncName.Size = new System.Drawing.Size(39, 16);
            this.lblIncName.TabIndex = 11;
            this.lblIncName.Text = "Name";
            // 
            // lblIncAmount
            // 
            this.lblIncAmount.AutoSize = true;
            this.lblIncAmount.Location = new System.Drawing.Point(33, 51);
            this.lblIncAmount.Name = "lblIncAmount";
            this.lblIncAmount.Size = new System.Drawing.Size(95, 16);
            this.lblIncAmount.TabIndex = 10;
            this.lblIncAmount.Text = "Amount ($):";
            // 
            // lblInc
            // 
            this.lblInc.AutoSize = true;
            this.lblInc.Location = new System.Drawing.Point(65, 26);
            this.lblInc.Name = "lblInc";
            this.lblInc.Size = new System.Drawing.Size(63, 16);
            this.lblInc.TabIndex = 9;
            this.lblInc.Text = "Income:";
            // 
            // pbxCalculatorInc
            // 
            this.pbxCalculatorInc.BackgroundImage = global::PresentacionWF.Properties.Resources.Calculator;
            this.pbxCalculatorInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxCalculatorInc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCalculatorInc.ErrorImage = null;
            this.pbxCalculatorInc.Location = new System.Drawing.Point(6, 18);
            this.pbxCalculatorInc.Name = "pbxCalculatorInc";
            this.pbxCalculatorInc.Size = new System.Drawing.Size(30, 30);
            this.pbxCalculatorInc.TabIndex = 0;
            this.pbxCalculatorInc.TabStop = false;
            // 
            // gbxListInc
            // 
            this.gbxListInc.Controls.Add(this.pnlInc);
            this.gbxListInc.Controls.Add(this.dgvListInc);
            this.gbxListInc.Location = new System.Drawing.Point(7, 28);
            this.gbxListInc.Name = "gbxListInc";
            this.gbxListInc.Size = new System.Drawing.Size(288, 594);
            this.gbxListInc.TabIndex = 4;
            this.gbxListInc.TabStop = false;
            this.gbxListInc.Text = "Incomes list";
            // 
            // pnlInc
            // 
            this.pnlInc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlInc.Controls.Add(this.txtIncSub);
            this.pnlInc.Controls.Add(this.lblIncSub);
            this.pnlInc.Controls.Add(this.btnIncRemove);
            this.pnlInc.Location = new System.Drawing.Point(6, 554);
            this.pnlInc.Name = "pnlInc";
            this.pnlInc.Size = new System.Drawing.Size(272, 34);
            this.pnlInc.TabIndex = 2;
            // 
            // txtIncSub
            // 
            this.txtIncSub.Location = new System.Drawing.Point(94, 5);
            this.txtIncSub.Name = "txtIncSub";
            this.txtIncSub.ReadOnly = true;
            this.txtIncSub.Size = new System.Drawing.Size(100, 23);
            this.txtIncSub.TabIndex = 6;
            // 
            // lblIncSub
            // 
            this.lblIncSub.AutoSize = true;
            this.lblIncSub.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncSub.ForeColor = System.Drawing.SystemColors.Window;
            this.lblIncSub.Location = new System.Drawing.Point(8, 8);
            this.lblIncSub.Name = "lblIncSub";
            this.lblIncSub.Size = new System.Drawing.Size(79, 16);
            this.lblIncSub.TabIndex = 5;
            this.lblIncSub.Text = "Subtotal:";
            // 
            // btnIncRemove
            // 
            this.btnIncRemove.BackColor = System.Drawing.Color.White;
            this.btnIncRemove.BackgroundImage = global::PresentacionWF.Properties.Resources.Delete;
            this.btnIncRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncRemove.Location = new System.Drawing.Point(239, 2);
            this.btnIncRemove.Name = "btnIncRemove";
            this.btnIncRemove.Size = new System.Drawing.Size(30, 30);
            this.btnIncRemove.TabIndex = 4;
            this.btnIncRemove.UseVisualStyleBackColor = false;
            this.btnIncRemove.Click += new System.EventHandler(this.BtnIncRemoveClick);
            // 
            // dgvListInc
            // 
            this.dgvListInc.AllowUserToAddRows = false;
            this.dgvListInc.AllowUserToDeleteRows = false;
            this.dgvListInc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListInc.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListInc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvListInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListInc.Location = new System.Drawing.Point(6, 35);
            this.dgvListInc.Name = "dgvListInc";
            this.dgvListInc.ReadOnly = true;
            this.dgvListInc.RowHeadersVisible = false;
            this.dgvListInc.RowTemplate.Height = 25;
            this.dgvListInc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListInc.ShowCellToolTips = false;
            this.dgvListInc.Size = new System.Drawing.Size(272, 519);
            this.dgvListInc.TabIndex = 1;
            this.dgvListInc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellClickFilter);
            this.dgvListInc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoubleClickFilter);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTop.Controls.Add(this.btnReturn);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(567, 22);
            this.pnlTop.TabIndex = 7;
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
            // ttipShowInfo
            // 
            this.ttipShowInfo.BackColor = System.Drawing.Color.White;
            this.ttipShowInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipShowInfo.ToolTipTitle = "Info";
            // 
            // frmIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(567, 660);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.gbxIncTypes);
            this.Controls.Add(this.gbxCalculatorInc);
            this.Controls.Add(this.gbxListInc);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 699);
            this.MinimumSize = new System.Drawing.Size(583, 699);
            this.Name = "frmIncomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incomes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIncomesFormClosed);
            this.Shown += new System.EventHandler(this.FrmIncomesShown);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.gbxIncTypes.ResumeLayout(false);
            this.gbxIncTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListIncTypes)).EndInit();
            this.pnlIncTypes.ResumeLayout(false);
            this.gbxCalculatorInc.ResumeLayout(false);
            this.gbxCalculatorInc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalculatorInc)).EndInit();
            this.gbxListInc.ResumeLayout(false);
            this.pnlInc.ResumeLayout(false);
            this.pnlInc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInc)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBottom;
        private DateTimePicker dtpIncomes;
        private TextBox txtBalance;
        private Label lblBalance;
        private GroupBox gbxIncTypes;
        private Button btnIncTypesCancel;
        private Button btnIncTypesSave;
        private TextBox txtIncNewType;
        private Label lblIncTypeNewName;
        private DataGridView dgvListIncTypes;
        private Panel pnlIncTypes;
        private Button btnIncTypesAdd;
        private Button btnIncTypesEdit;
        private Button btnIncTypesRemove;
        private GroupBox gbxCalculatorInc;
        private Button btnIncSave;
        private TextBox txtIncAmount;
        private ComboBox cbxIncOperation;
        private Label lblIncValue;
        private Label lblIncName;
        private Label lblIncAmount;
        private Label lblInc;
        private PictureBox pbxCalculatorInc;
        private GroupBox gbxListInc;
        private Panel pnlInc;
        private TextBox txtIncSub;
        private Label lblIncSub;
        private Button btnIncRemove;
        private DataGridView dgvListInc;
        private Panel pnlTop;
        private Button btnReturn;
        private ImageList imlIncomes;
        private ToolTip ttipShowInfo;
    }
}