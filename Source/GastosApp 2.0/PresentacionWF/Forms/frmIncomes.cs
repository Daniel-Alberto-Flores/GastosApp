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
    public partial class frmIncomes : Form
    {
        Modelo.Configuration Configurations = new Modelo.Configuration();
        int verifyClose = 0;
        int editType = 0;
        string Income = "";

        public frmIncomes(Modelo.Configuration configurations)
        {
            InitializeComponent();
            Configurations = configurations;// We get the configurations values
            CbxSelectDefaultItem();// We select the initial combobox item
            DtpFormat();// We set the format of the DateTimePicker
            GbxIncTypesResize("Small");// We resize the gbxIncTypes
            //We always set the first day of the month to prevent it from falling in months that do not have 31 days and an exception is generated
            dtpIncomes.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            UpdateDgvListInc();        // We load the dgvListInc rows
            UpdateDgvListIncTypes();   // We load the dgvListIncTypes rows
            UpdateBalance();// We update txtBalance
        }

        private void FrmIncomesShown(object sender, EventArgs e)
        {
            TranslateControls();// We translate the text of the controls
        }

        private void BtnReturnClick(object sender, EventArgs e)
        {
            Exit();
        }

        private void FrmIncomesFormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        private void DgvCellClickFilter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvFiltered = (DataGridView)sender;
            // We load the value in the lblIncValue, and we also save the name of the outflow
            if (e.RowIndex > -1)
            {
                if (Configurations.Language == "Español")
                {
                    Income = dgvFiltered.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                }
                    
                if (Configurations.Language == "English")
                {
                    Income = dgvFiltered.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                }
                    
            }                
        }

        private void DgvDoubleClickFilter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvDoubleClick = ((DataGridView)sender);
            if ((e.RowIndex > -1) && (Income != ""))
            {
                // We load the value in the lblIncValue, and we also store the name of the income                
                lblIncName.Text = Income;
                if (Configurations.Language == "Español")
                {
                    Income = dgvDoubleClick.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    lblIncValue.Text = dgvDoubleClick.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
                }
                if (Configurations.Language == "English")
                {
                    Income = dgvDoubleClick.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    lblIncValue.Text = dgvDoubleClick.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                }
                txtIncAmount.Enabled = true;
                txtIncAmount.Focus();
            }
        }

        private void TxtIncAmountKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnIncSave.PerformClick();
            }
        }

        private void TxtKeyPressFilter(object sender, KeyPressEventArgs e)
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            if (logicaOperations.KeyFilter(((TextBox)sender).Text, e.KeyChar.ToString()))
                e.Handled = true;            
        }        

        private void BtnIncRemoveClick(object sender, EventArgs e)
        {
            if (Income != "")
            {
                Logica.Operations logicaOperations = new Logica.Operations();        
                string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnIncRemoveClick");
                DialogResult result = MessageBox.Show($"{Message} {Income}", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Logica.Movement logicaMovement = new Logica.Movement();
                    DateTime Date = dtpIncomes.Value;

                    if (logicaMovement.DeleteMovementByMonthYear(Date, Income))
                    {
                        UpdateDgvListInc();// We update dgvListInc
                        UpdateBalance();//We update txtBalance
                        ClearCalculator();// We clean the calculator fields
                    }
                    else
                    {
                        Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnIncRemoveNotExist");
                        MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    
                }
            }
        }

        private void BtnIncSaveClick(object sender, EventArgs e)
        {            
            Logica.Operations logicaOperations = new Logica.Operations();
            string Message = "";
            int dotCount = txtIncAmount.Text.Where(x => (x == '.')).Count();// We use this for count dot or "."
            bool verifyStr = Double.TryParse(txtIncAmount.Text, out _);// If return true is numeric
            if (verifyStr && (dotCount < 2))
            {
                if (txtIncAmount.Text != "")
                {
                    Logica.Movement logicaMovement = new Logica.Movement();
                    Income = lblIncName.Text;
                    Double Amount = logicaOperations.CalculeAmount(lblIncValue.Text, txtIncAmount.Text, cbxIncOperation.Text);
                    DateTime Date = dtpIncomes.Value;
                    logicaMovement.UpdateMovement(Date, Income, Amount);//We update the dgvListInc with the new data entered
                    UpdateDgvListInc();// We refresh the dgvListInc
                    lblIncValue.Text = txtIncAmount.Text.Replace(".", ",");// We keep the value of the last loaded income
                    txtIncAmount.Text = "";
                    txtIncAmount.Enabled = false;
                    UpdateBalance();// We update txtBalance
                }
                else
                {
                    Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnIncSaveEnterAmount");
                    MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnIncSaveWrongValue");
                MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIncAmount.Focus();
            }
        }

        private void DgvListIncTypesCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Logica.Movement logicaMovement = new Logica.Movement();
                if (Configurations.Language == "Español")
                    Income = dgvListIncTypes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                if (Configurations.Language == "English")
                    Income = dgvListIncTypes.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                DateTime Date = dtpIncomes.Value;// We get the date of the dtp

                if (logicaMovement.ReadByIdMonthYear(Date, Income) != null)
                {
                    Logica.Operations logicaOperations = new Logica.Operations();
                    string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "ExistingIncome");
                    MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Insert the new type at Movements table
                    logicaMovement.AddMovement(Date, Income);// We pass the name of the income to look for it and insert it in the current period
                    UpdateDgvListInc();//Actualizamos los dgvListInc
                }
            }
        }

        private void BtnIncTypesEditClick(object sender, EventArgs e)
        {
            if (Income != "")
            {
                // We load the type to edit in the txtIncNewType
                txtIncNewType.Text = Income;
                GbxIncTypesResize("Big");
                txtIncNewType.Focus();
                editType = 1;// We set it to 1 so that when saving we know if it is being edited or if it is a new type
            }
        }

        private void BtnIncTypesRemoveClick(object sender, EventArgs e)
        {
            if (Income != "")
            {
                Logica.Operations logicaOperations = new Logica.Operations();
                string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnIncTypesRemoveClick");
                DialogResult result = MessageBox.Show($"{Message} {Income}", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Logica.Detail logicaDetail = new Logica.Detail();
                    logicaDetail.DeleteDetail(Income);
                    UpdateDgvListInc();// We update dgvListInc
                    UpdateDgvListIncTypes();// We update dgvListIncTypes
                    UpdateBalance();
                }
            }
        }

        private void BtnIncTypesAddClick(object sender, EventArgs e)
        {
            Income = "";// We whiten the ingress variable
            GbxIncTypesResize("Big");
            txtIncNewType.Focus();
            editType = 0;// We set it to zero to verify that it is a new type and not being edited
        }

        private void TxtIncNewTypeKeyDown(object sender, KeyEventArgs e)
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

        private void BtnIncTypesCancelClick(object sender, EventArgs e)
        {
            txtIncNewType.Text = "";
            GbxIncTypesResize("Small");
            editType = 0;
        }

        private void BtnIncTypesSaveClick(object sender, EventArgs e)
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            string Message = "";
            if (txtIncNewType.Text.Trim().Length <= 14)
            {
                if (txtIncNewType.Text.Trim() != "")
                {
                    // We save the name of the selected type
                    Logica.Detail logicaDetail = new Logica.Detail();
                    string detailName = txtIncNewType.Text.Trim();

                    if (logicaDetail.ReadByName(detailName) != 0)// We pass the selected type
                    {
                        Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "IncomeAlreadyLoaded");
                        MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (editType == 0)// A new type is loading
                        {
                            // 1 = Income, "No" = No daily (Incomes are always non-daily)
                            logicaDetail.AddDetail(detailName, 1, "No");// We insert the new detail
                            UpdateDgvListIncTypes();// We update the dgvListIncTypes with the new loaded type
                            txtIncNewType.Text = "";
                            GbxIncTypesResize("Small");
                        }
                        else// editType == 1
                        {
                            UpdateIncomeName();
                            UpdateDgvListIncTypes();// We update the dgvListIncTypes with the new loaded type
                            UpdateDgvListInc();
                            txtIncNewType.Text = "";
                            GbxIncTypesResize("Small");
                        }
                        Income = "";
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

        private void DtpIncomesValueChanged(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        // Methods

        private void TranslateControls()
        {
            // Control text traduction
            Logica.Operations logicaOperations = new Logica.Operations();
            ActiveForm.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "frmIncomes");
            btnReturn.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "btnReturn");
            gbxListInc.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "gbxListInc");
            gbxCalculatorInc.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "gbxCalculatorInc");
            lblInc.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblInc");
            lblIncName.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblIncName");
            lblIncAmount.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblIncAmount");
            lblIncValue.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblIncValue");
            gbxIncTypes.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "gbxIncTypes");
            lblIncTypeNewName.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblIncTypeNewName");
            lblBalance.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblBalance");
            
            if (Configurations.Language == "Español")
            {
                // Control Location
                lblInc.Location = new Point(57, 26);
                lblIncAmount.Location = new Point(41, 51);
                lblIncTypeNewName.Location = new Point(6, 455);
                lblBalance.Location = new Point(19, 6);

                // Tooltips
                ttipShowInfo.SetToolTip(btnReturn, "Volver al home.");
                ttipShowInfo.SetToolTip(btnIncRemove, "Eliminar.");
                ttipShowInfo.SetToolTip(btnIncSave, "Guardar.");
                ttipShowInfo.SetToolTip(btnIncTypesEdit, "Editar.");
                ttipShowInfo.SetToolTip(btnIncTypesRemove, "Eliminar.");
                ttipShowInfo.SetToolTip(btnIncTypesAdd, "Añadir.");
                ttipShowInfo.SetToolTip(btnIncTypesCancel, "Cancelar.");
                ttipShowInfo.SetToolTip(btnIncTypesSave, "Guardar.");
            }
            if (Configurations.Language == "English")
            {
                // Control Location
                lblInc.Location = new Point(65, 26);
                lblIncAmount.Location = new Point(33, 51);
                lblIncTypeNewName.Location = new Point(18, 455);
                lblBalance.Location = new Point(3, 6);

                // Tooltips
                ttipShowInfo.SetToolTip(btnReturn, "Return to home.");
                ttipShowInfo.SetToolTip(btnIncRemove, "Remove.");
                ttipShowInfo.SetToolTip(btnIncSave, "Save.");
                ttipShowInfo.SetToolTip(btnIncTypesEdit, "Edit.");
                ttipShowInfo.SetToolTip(btnIncTypesRemove, "Remove.");
                ttipShowInfo.SetToolTip(btnIncTypesAdd, "Add.");
                ttipShowInfo.SetToolTip(btnIncTypesCancel, "Cancel.");
                ttipShowInfo.SetToolTip(btnIncTypesSave, "Save.");
            }
        }

        private void CbxSelectDefaultItem()
        {
            cbxIncOperation.SelectedIndex = 0;
        }

        private void DtpFormat()
        {
            dtpIncomes.Format = DateTimePickerFormat.Custom;
            dtpIncomes.CustomFormat = "MMMM yyyy";
            dtpIncomes.ShowUpDown = true;
        }

        private void GbxIncTypesResize(string Size)
        {
            if (Size == "Small")
                gbxIncTypes.Size = new Size(258, 448);
            else // (Size == "Big")
                gbxIncTypes.Size = new Size(258, 483);
        }

        private void UpdateDgvListInc()
        {
            // We load the dgvListInc query
            DateTime Date = dtpIncomes.Value;// We get the date of the dtp
            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();
            List<Modelo.MovementDetail> listIncMovDet = logicaMovDet.ReadByTypeDailyMonthYear(Date, 1, false);// 1 = income, false = no daily
            if (dgvListInc.Columns.Count == 0)
                LoadDgvListIncColumnsNames();// If is the first time, we load the headers
            else
                dgvListInc.Rows.Clear();// We clean the content of the datagridview
            Double sub_total = 0;
            foreach (var movementDetail in listIncMovDet)// We load all rows from the list
            {
                dgvListInc.Rows.Add(movementDetail.Name, movementDetail.Amount.ToString("N2").Replace(".", ""));
                sub_total += movementDetail.Amount;
            }
            txtIncSub.Text = sub_total.ToString("N2").Replace(".", "");
        }

        private void UpdateDgvListIncTypes()
        {
            // We load the dgvListIncTypes query
            Logica.Detail logicaDetail = new Logica.Detail();
            if (dgvListIncTypes.Columns.Count == 0)
                LoadDgvListIncTypesColumnsNames();// If is the first time, we load the headers
            else
                dgvListIncTypes.Rows.Clear();// We clean the content of the datagridview            
            List<Modelo.Detail> listIncomes = logicaDetail.GetDetailsByType(1);// 1 = income            
            foreach (var Income in listIncomes)// We load all rows from the list
                dgvListIncTypes.Rows.Add(Income.Name);
        }

        private void UpdateDgv()
        {
            UpdateDgvListInc();
            UpdateBalance();// Update txtBalance
        }

        private void UpdateBalance()
        {
            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();
            Logica.Operations logicaOperations = new Logica.Operations();
            DateTime Date = dtpIncomes.Value;// We get the date of the dtp
            Double Balance = logicaMovDet.GetTotalAmount(Date); //We get the balance value            
            Modelo.Color balanceRgbValue = logicaOperations.CalculeBalanceColor(Balance);// We get the rgb value
            txtBalance.ForeColor = Color.FromArgb(balanceRgbValue.Red, balanceRgbValue.Green, balanceRgbValue.Blue);
            txtBalance.Text = Balance.ToString("N2");
        }

        private void ClearCalculator()
        {
            // We used this for clear Calculator fields and income variable
            Income = "";
            if (Configurations.Language == "Español")
            {
                lblIncName.Text = "Nombre";
                lblIncValue.Text = "Valor";
            }
            if (Configurations.Language == "English")
            {
                lblIncName.Text = "Name";
                lblIncValue.Text = "Value";
            }
            txtIncAmount.Text = "";
            txtIncAmount.Enabled = false;
        }

        private void UpdateIncomeName()
        {
            Logica.Detail logicaDetail = new Logica.Detail();
            logicaDetail.UpdateIncomeName(txtIncNewType.Text, Income);// We update the income(Name)
        }

        private void LoadDgvListIncColumnsNames()
        {   // dgvListInc
            if (Configurations.Language == "Español")
            {
                dgvListInc.Columns.Add("Nombre", "Nombre");
                dgvListInc.Columns.Add("Monto", "Monto");
            }
            if (Configurations.Language == "English")
            {
                dgvListInc.Columns.Add("Name", "Name");
                dgvListInc.Columns.Add("Amount", "Amount");
            }
        }

        private void LoadDgvListIncTypesColumnsNames()
        {   // dgvListIncTypes
            if (Configurations.Language == "Español")
                dgvListIncTypes.Columns.Add("Nombre", "Nombre");
            if (Configurations.Language == "English")
                dgvListIncTypes.Columns.Add("Name", "Name");
        }        

        private void Exit()
        {
            if (verifyClose == 0)
            {
                this.Hide();
                frmMain frmMai = new frmMain(Configurations);
                frmMai.Show();
            }            
        }
    }
}
