using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWF.Forms
{
    public partial class frmOutflows : Form
    {
        Modelo.Configuration Configurations = new Modelo.Configuration();
        string dateDtp = "";
        int verifyDb = 0, editType = 0;
        string Outflow = "", Daily = "";

        public frmOutflows(Modelo.Configuration configurations, string dtpValue = null)
        {
            InitializeComponent();
            Configurations = configurations;
            DtpFormat();// We set the format of the DateTimePicker
            GbxOutTypesResize("Small");// We resize the gbxOutTypes
            if (dtpValue != null)
                dateDtp = dtpValue;// Value inherited from Preload      
            VerifyDtp();// Check if outflows types need to be preloaded
            UpdateDgvListOut();        // We load the dgvListOut rows
            UpdateDgvListOutOthers();  // We load the dgvListOutOthers rows
            UpdateDgvListOutTypes();   // We load the dgvListOutTypes rows
            UpdateBalance();// We update txtBalance
        }

        private void FrmOutflowsShown(object sender, EventArgs e)
        {
            TranslateControls();// We translate the text of the controls
        }

        private void DgvCellClickFilter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvFiltered = (DataGridView)sender;
            // We load the value in the lblOutValue, and we also save the name of the outflow
            if (e.RowIndex > -1)
            {
                if (Configurations.Language == "Español")
                    Outflow = dgvFiltered.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                if (Configurations.Language == "English")
                    Outflow = dgvFiltered.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        private void DgvDoubleClickFilter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvDoubleClick = ((DataGridView)sender);
            if ((e.RowIndex > -1) && (Outflow != ""))
            {
                // We load the value in the lblOutValue, and we also store the name of the outflow
                lblOutName.Text = Outflow;

                if (Configurations.Language == "Español")
                {
                    Outflow = dgvDoubleClick.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    lblOutValue.Text = dgvDoubleClick.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
                }
                if (Configurations.Language == "English")
                {
                    Outflow = dgvDoubleClick.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    lblOutValue.Text = dgvDoubleClick.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                }
                txtOutAmount.Enabled = true;
                txtOutAmount.Focus();
            }
        }

        private void BtnRemoveClickFilter(object sender, EventArgs e)
        {
            if (Outflow != "")
            {
                Logica.Operations logicaOperations = new Logica.Operations();
                string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnOutRemoveClick");
                DialogResult result = MessageBox.Show($"{Message} {Outflow}", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Logica.Movement logicaMovement = new Logica.Movement();
                    DateTime Date = dtpOutflows.Value;

                    if (logicaMovement.DeleteMovementByMonthYear(Date, Outflow))
                    {
                        UpdateDgvListOut();// Update dgvListOut
                        UpdateDgvListOutOthers();// Update dgvListOutOthers
                        UpdateBalance();// We update txtBalanc
                        ClearCalculator();// We clean the calculator fields
                    }
                    else
                    {
                        Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnOutRemoveNotExist");
                        MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void TxtOutAmountKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnOutSave.PerformClick();
            }
        }

        private void TxtKeyPressFilter(object sender, KeyPressEventArgs e)
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            if (logicaOperations.KeyFilter(((TextBox)sender).Text, e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void BtnOutSaveClick(object sender, EventArgs e)
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            string Message = "";
            int dotCount = txtOutAmount.Text.Where(x => (x == '.')).Count();// We use this for count dot or "."
            bool verifyStr = Double.TryParse(txtOutAmount.Text, out _);// If return true is numeric
            if (verifyStr && (dotCount < 2))
            {
                if (txtOutAmount.Text != "")
                {
                    Logica.Movement logicaMovement = new Logica.Movement();
                    Outflow = lblOutName.Text;
                    Double Amount = logicaOperations.CalculeAmount(lblOutValue.Text, txtOutAmount.Text, cbxOutOperation.Text);
                    DateTime Date = dtpOutflows.Value;
                    logicaMovement.UpdateMovement(Date, Outflow, Amount);// We update the dgvListOut with the new data entered
                    UpdateDgvListOut();// We refresh the dgvListOut
                    UpdateDgvListOutOthers();// We refresh the dgvListOutOthers
                    lblOutValue.Text = txtOutAmount.Text.Replace(".", ",");// We keep the value of the last loaded egress
                    txtOutAmount.Text = "";
                    txtOutAmount.Enabled = false;
                    UpdateBalance();// We update txtBalance
                }
                else
                {
                    Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnOutSaveEnterAmount");
                    MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                    
            }
            else
            {
                Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnOutSaveWrongValue");
                MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOutAmount.Focus();
            }
        }

        private void DgvListOutTypesCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // We save the name of the selected outflow to later inactivate it
                if (Configurations.Language == "Español")
                {
                    Outflow = dgvListOutTypes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    Daily = dgvListOutTypes.Rows[e.RowIndex].Cells["Diario"].Value.ToString();
                }
                if (Configurations.Language == "English")
                {
                    Outflow = dgvListOutTypes.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    Daily = dgvListOutTypes.Rows[e.RowIndex].Cells["Daily"].Value.ToString();
                }
            }
        }

        private void DgvListOutTypesDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();
                if (Configurations.Language == "Español")
                    Outflow = dgvListOutTypes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                if (Configurations.Language == "English")
                    Outflow = dgvListOutTypes.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                DateTime Date = dtpOutflows.Value;// We get the date of the dtp
                if (logicaMovDet.ReadByNameMonthYear(Date, Outflow))
                {
                    Logica.Operations logicaOperations = new Logica.Operations();
                    string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "ExistingOutflow");
                    MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Insert the new type at Movements table
                    Logica.Movement logicaMovement = new Logica.Movement();
                    logicaMovement.AddMovement(Date, Outflow);// We pass the name of the outflow to look for it and insert it in the current period         
                    UpdateDgvListOut();// Update dgvListOut
                    UpdateDgvListOutOthers();// Update dgvListOutOthers
                }
            }
        }

        private void BtnOutTypesEditClick(object sender, EventArgs e)
        {
            if (Outflow != "")
            {
                // We load the type to edit in the txtOutNewType, and we also charge if it is of the daily type or not
                txtOutNewType.Text = Outflow;
                cbxOutTypeDaily.Text = Daily;
                GbxOutTypesResize("Big");
                txtOutNewType.Focus();
                editType = 1;// We set it to 1 so that when saving we know if it is being edited or if it is a new type
            }
        }

        private void BtnOutTypesRemoveClick(object sender, EventArgs e)
        {
            if (Outflow != "")
            {
                Logica.Operations logicaOperations = new Logica.Operations();
                string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnOutTypesRemoveClick");
                DialogResult result = MessageBox.Show($"{Message} {Outflow}", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Logica.Detail logicaDetail = new Logica.Detail();
                    logicaDetail.DeleteDetail(Outflow);
                    // Update dgvs
                    UpdateDgvListOut();
                    UpdateDgvListOutOthers();
                    UpdateDgvListOutTypes();
                    UpdateBalance();
                }
            }
        }

        private void BtnOutTypesAddClick(object sender, EventArgs e)
        {
            Outflow = "";//We whiten the egress variable
            GbxOutTypesResize("Big");
            txtOutNewType.Focus();
            editType = 0;//We set it to zero to verify that it is a new type and is not being edited
        }

        private void TxtOutNewTypeKeyDown(object sender, KeyEventArgs e)
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            if (logicaOperations.LengthFilter(((TextBox)sender).Text))
            {
                if ((e.KeyCode != Keys.Back) && (e.KeyCode != Keys.Delete) && (e.KeyCode != Keys.Left) && (e.KeyCode != Keys.Right))
                {
                    // We only allows to press keys back, delete, left and right
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void BtnOutTypesCancelClick(object sender, EventArgs e)
        {
            txtOutNewType.Text = "";
            GbxOutTypesResize("Small");
            editType = 0;
        }

        private void BtnOutTypesSaveClick(object sender, EventArgs e)
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            string Message = "";
            if (txtOutNewType.Text.Trim().Length <= 14)
            {
                // We save the name of the selected type
                if (txtOutNewType.Text.Trim() != "")
                {
                    Logica.Detail logicaDetail = new Logica.Detail();
                    string detailName = txtOutNewType.Text.Trim();
                    bool boolDaily = logicaOperations.DailyStringToYesNo(cbxOutTypeDaily.Text);

                    if (logicaDetail.ReadByName(detailName) != 0)// We pass the selected type and if it is of the daily type
                    {
                        Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "OutflowAlreadyLoaded");
                        MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (editType == 0)// A new type is loading
                        {
                            // 2 = outflow
                            logicaDetail.AddDetail(detailName, 2, cbxOutTypeDaily.Text);// We insert the new type
                            UpdateDgvListOutTypes();// We update the dgvListOutTypes with the new loaded type
                            txtOutNewType.Text = "";
                            GbxOutTypesResize("Small");
                        }
                        else // editType == 1
                        {
                            UpdateOutflowName();
                            UpdateDgvListOutTypes();//We update the dgvListOutTypes with the new loaded type
                            UpdateDgvListOut();
                            UpdateDgvListOutOthers();
                            txtOutNewType.Text = "";
                            GbxOutTypesResize("Small");
                        }
                        Outflow = "";
                    }                    
                }
                else
                {
                    Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "CompleteFieldName");
                    MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "LengthNameInvalid");
                MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void DtpOutflowsValueChanged(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void BtnReturnClick(object sender, EventArgs e)
        {
            Exit();
        }

        private void FrmOutflowsFormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        // Methods

        private void TranslateControls()
        {
            // Control text traduction
            Logica.Operations logicaOperations = new Logica.Operations();
            ActiveForm.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "frmOutflows");
            btnReturn.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "btnReturn");
            gbxListOut.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "gbxListOut");
            lblOutDaily.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblOutDaily");
            lblOutOthers.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblOutOthers");
            gbxCalculatorOut.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "gbxCalculatorOut");
            lblOut.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblOut");
            lblOutName.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblOutName");
            lblOutAmount.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblOutAmount");
            lblOutValue.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblOutValue");
            gbxOutTypes.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "gbxOutTypes");
            lblOutTypeNewName.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblOutTypeNewName");
            lblOutTypeDaily.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblOutTypeDaily");
            lblBalance.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblBalance");
            
            if (Configurations.Language == "Español")
            {
                // Add items to cbc
                cbxOutTypeDaily.Items.Add("Si");
                cbxOutTypeDaily.Items.Add("No");
                // Control Location
                lblOut.Location = new Point(64, 26);
                lblOutAmount.Location = new Point(40, 51);
                lblOutTypeNewName.Location = new Point(6, 428);
                lblOutTypeDaily.Location = new Point(6, 455);
                lblBalance.Location = new Point(19, 6);

                // Tooltips
                ttipShowInfo.SetToolTip(btnReturn, "Volver al home.");
                ttipShowInfo.SetToolTip(btnOutDailyRemove, "Eliminar.");
                ttipShowInfo.SetToolTip(btnOutDailyOthersRemove, "Eliminar.");
                ttipShowInfo.SetToolTip(btnOutSave, "Guardar.");
                ttipShowInfo.SetToolTip(btnOutTypesEdit, "Editar.");
                ttipShowInfo.SetToolTip(btnOutTypesRemove, "Eliminar.");
                ttipShowInfo.SetToolTip(btnOutTypesAdd, "Añadir.");
                ttipShowInfo.SetToolTip(btnOutTypesCancel, "Cancelar.");
                ttipShowInfo.SetToolTip(btnOutTypesSave, "Guardar.");
            }
            if (Configurations.Language == "English")
            {
                // Add items to cbc
                cbxOutTypeDaily.Items.Add("Yes");
                cbxOutTypeDaily.Items.Add("No");
                // Control Location
                lblOut.Location = new Point(57, 26);
                lblOutAmount.Location = new Point(33, 51);
                lblOutTypeNewName.Location = new Point(18, 428);
                lblOutTypeDaily.Location = new Point(10, 455);
                lblBalance.Location = new Point(3, 6);

                // Tooltips
                ttipShowInfo.SetToolTip(btnReturn, "Return to home.");
                ttipShowInfo.SetToolTip(btnOutDailyRemove, "Remove.");
                ttipShowInfo.SetToolTip(btnOutDailyOthersRemove, "Remove.");
                ttipShowInfo.SetToolTip(btnOutSave, "Save.");
                ttipShowInfo.SetToolTip(btnOutTypesEdit, "Edit.");
                ttipShowInfo.SetToolTip(btnOutTypesRemove, "Remove.");
                ttipShowInfo.SetToolTip(btnOutTypesAdd, "Add.");
                ttipShowInfo.SetToolTip(btnOutTypesCancel, "Cancel.");
                ttipShowInfo.SetToolTip(btnOutTypesSave, "Save.");
            }
            CbxSelectDefaultItem();
        }

        private void CbxSelectDefaultItem()
        {
            // We select the initial combobox item
            cbxOutOperation.SelectedIndex = 0;
            cbxOutTypeDaily.SelectedIndex = 0;
        }

        private void DtpFormat()
        {
            dtpOutflows.Format = DateTimePickerFormat.Custom;
            dtpOutflows.CustomFormat = "MMMM yyyy";
            dtpOutflows.ShowUpDown = true;
        }

        private void GbxOutTypesResize(string Size)
        {
            if (Size == "Small")
                gbxOutTypes.Size = new Size(258, 420);
            else // (Size == "Big")
                gbxOutTypes.Size = new Size(258, 483);
        }

        private void VerifyDtp()
        {
            if (dateDtp == "")
            {
                //We always set the first day of the month to prevent it from falling in months that do not have 31 days and an exception is generated
                dtpOutflows.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
            else
            {
                //We load the date from the DateTimePicker if it came back from frmOutflowsPreload
                dtpOutflows.Value = Convert.ToDateTime(dateDtp);
            }
            dateDtp = "";
        }

        private void UpdateDgvListOut()
        {
            // We load the dgvListOut query
            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();
            DateTime Date = dtpOutflows.Value;// We get the date of the dtp
            List<Modelo.MovementDetail> listOutMovDetDaily = logicaMovDet.ReadByTypeDailyMonthYear(Date, 2, true);// 2 = outflow, true = daily
            if (dgvListOut.Columns.Count == 0)
                LoadDgvListOutColumnsNames();// If is the first time, we load the headers
            else
                dgvListOut.Rows.Clear();// We clean the content of the datagridview
            Double sub_total = 0;
            foreach (var movementDetail in listOutMovDetDaily)// We load all rows from the list
            {
                dgvListOut.Rows.Add(movementDetail.Name, movementDetail.Amount.ToString("N2").Replace(".", ""));
                sub_total += movementDetail.Amount;
            }
            txtOutDailySub.Text = sub_total.ToString("N2").Replace(".", "");// Update the subtotal
        }

        private void UpdateDgvListOutOthers()
        {
            // We load the dgvListOutOthers query
            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();
            DateTime Date = dtpOutflows.Value;// We get the date of the dtp
            List<Modelo.MovementDetail> listOutMovDetOthers = logicaMovDet.ReadByTypeDailyMonthYear(Date, 2, false);// 2 = outflow, false = no daily
            if (dgvListOutOthers.Columns.Count == 0)
                LoadDgvListOutOthersColumnsNames();// If is the first time, we load the headers
            else
                dgvListOutOthers.Rows.Clear();// We clean the content of the datagridview
            Double sub_total = 0;
            foreach (var movementDetail in listOutMovDetOthers)// We load all rows from the list
            {
                dgvListOutOthers.Rows.Add(movementDetail.Name, movementDetail.Amount.ToString("N2").Replace(".", ""));
                sub_total += movementDetail.Amount;
            }
            txtOutDailyOthers.Text = sub_total.ToString("N2").Replace(".", "");// Update the subtotal
        }

        private void UpdateDgvListOutTypes()
        {
            // We load the dgvListOutTypes query
            Logica.Detail logicaDetail = new Logica.Detail();
            Logica.Operations logicaOperations = new Logica.Operations();
            List<Modelo.Detail> listOutflows = logicaDetail.GetDetailsByType(2);// 2 = outflow
            if (dgvListOutTypes.Columns.Count == 0)
                LoadDgvListOutTypesColumnsNames();// If is the first time, we load the headers
            else
                dgvListOutTypes.Rows.Clear();// We clean the content of the datagridview
            foreach (var Outflows in listOutflows)// We load all rows from the list
                dgvListOutTypes.Rows.Add(Outflows.Name, logicaOperations.DailyBoolToYesNo(Configurations.Language,Outflows.Daily));
        }

        private void VerifyDb()
        {
            // We verify that the db has loaded at least one outflow in the selected month and year of the dtp
            Logica.Context logicaContext = new Logica.Context();
            if (logicaContext.VerifyDb())
                verifyDb = 1;//If it have at least one record loaded => load 1
            else
                verifyDb = 0;//If it is empty => load 0 
        }

        private void UpdateDgv()
        {
            if (ActiveForm != null)
            {
                //It is responsible for verifying the selected tabpage and updating the corresponding dgv
                if (verifyDb == 0)
                {
                    VerifyDb();
                }
                UpdateDgvListOut();
                UpdateDgvListOutOthers();
                if ((dgvListOut.Rows.Count == 0) && (dgvListOutOthers.Rows.Count == 0) && (dateDtp == "") && (verifyDb == 1))
                {
                    Logica.Operations logicaOperations = new Logica.Operations();
                    string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "UpdateDgv");
                    DialogResult result = MessageBox.Show(Message, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dateDtp = dtpOutflows.Value.ToString("MMMM yyyy");
                        this.Hide();
                        frmOutflowsPreload frmOutPre = new frmOutflowsPreload(Configurations, dateDtp);
                        frmOutPre.Show();
                    }
                }
                UpdateBalance();// Update txtBalance
            }
            
        }

        private void UpdateBalance()
        {
            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();
            Logica.Operations logicaOperations = new Logica.Operations();
            DateTime Date = dtpOutflows.Value;// We get the date of the dtp
            Double Balance = logicaMovDet.GetTotalAmount(Date); //We get the balance value            
            Modelo.Color balanceRgbValue = logicaOperations.CalculeBalanceColor(Balance);// We get the rgb value
            txtBalance.ForeColor = Color.FromArgb(balanceRgbValue.Red, balanceRgbValue.Green, balanceRgbValue.Blue);
            txtBalance.Text = Balance.ToString("N2");
        }

        private void UpdateOutflowName()
        {
            // We update the outflow(Name, Daily)
            Logica.Detail logicaDetail = new Logica.Detail();
            logicaDetail.UpdateOutflowName(txtOutNewType.Text, cbxOutTypeDaily.Text, Outflow);
        }

        private void LoadDgvListOutColumnsNames()
        {   // dgvListOut  
            
            if (Configurations.Language == "Español")
            {
                dgvListOut.Columns.Add("Nombre", "Nombre");
                dgvListOut.Columns.Add("Monto", "Monto");
            }
            if (Configurations.Language == "English")
            {
                dgvListOut.Columns.Add("Name", "Name");
                dgvListOut.Columns.Add("Amount", "Amount");
            }
        }

        private void LoadDgvListOutTypesColumnsNames()
        {   // dgvListOutTypes   
            
            if (Configurations.Language == "Español")
            {
                dgvListOutTypes.Columns.Add("Nombre", "Nombre");
                dgvListOutTypes.Columns.Add("Diario", "Diario");
            }
            if (Configurations.Language == "English")
            {
                dgvListOutTypes.Columns.Add("Name", "Name");
                dgvListOutTypes.Columns.Add("Daily", "Daily");
            }
        }

        private void LoadDgvListOutOthersColumnsNames()
        {   // dgvListOutOthers
            if (Configurations.Language == "Español")
            {
                dgvListOutOthers.Columns.Add("Nombre", "Nombre");
                dgvListOutOthers.Columns.Add("Monto", "Monto");
            }
            if (Configurations.Language == "English")
            {
                dgvListOutOthers.Columns.Add("Name", "Name");
                dgvListOutOthers.Columns.Add("Amount", "Amount");
            }
        }        

        private void ClearCalculator()
        {
            // We used this for clear Calculator fields and outflow/income variable
            Outflow = "";
            lblOutName.Text = "Name";
            lblOutValue.Text = "Value";
            txtOutAmount.Text = "";
            txtOutAmount.Enabled = false;
        }

        private void Exit()
        {
            this.Hide();
            frmMain frmMai = new frmMain(Configurations);
            frmMai.Show();
        }        
    }
}
