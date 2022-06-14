using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PresentacionWF.Forms
{
    public partial class frmMain : Form
    {
        // Path  = System.Environment.CurrentDirectory + "\\Database.db"
        internal static string dateDtp = "";
        int verifyDeci = 0, verifyDb = 0, editType = 0;
        string Outflow = "", Income = "", Daily ="";

        public frmMain()
        {
            InitializeComponent();

            // If 'Database.db' does not exist we must create it and load the default values
            VerifyDbExists();
            // Disable the use of paste in the text box
            DisablePasteOnTxt();
            // We select the initial combobox item
            cbxSelectDefaultItem();
            // We set the format of the DateTimePicker
            dtpMain.Format = DateTimePickerFormat.Custom;
            dtpMain.CustomFormat = "MMMM yyyy";
            dtpMain.ShowUpDown = true;
            gbxOutTypes.Size = new Size(258, 423);
            gbxIncTypes.Size = new Size(258, 450);

            if (dateDtp == "")
            {
                //We always set the first day of the month to prevent it from falling in months that do not have 31 days and an exception is generated
                dtpMain.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
            else
            {
                //We load the date from the DateTimePicker if it came back from frmOutflowsPreload
                dtpMain.Value = Convert.ToDateTime(dateDtp);
            }
            dateDtp = "";

            // We load the dgv columns names
            LoadDgvColumnsNames();

            // We load the dgv rows
            UpdateDgvListOut();        // dgvListOut
            UpdateDgvListOutOthers();  // dgvListOutOthers
            UpdateDgvListOutTypes();   // dgvListOutTypes
            UpdateDgvListInc();        // dgvListInc
            UpdateDgvListIncTypes();   // dgvListIncTypes

            //Actualizamos el tb_saldo
            UpdateBalance();
            //Cargamos el txt de notas
            UpdateNotes();
        }

        private void VerifyDbExists()
        {
            string pathDb = System.Environment.CurrentDirectory + "\\Database.db";
            Logica.Context logContext = new Logica.Context();
            if (!File.Exists(pathDb))
            {
                logContext.CreateDb();
                MessageBox.Show("Database created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }









        // Methods

        private void DisablePasteOnTxt()
        {
            // We need to generate an empty variable of the ContextMenuStrip type
            var blankContextMenu = new ContextMenuStrip();
            txtOutAmount.ContextMenuStrip = blankContextMenu;
            txtOutNewType.ContextMenuStrip = blankContextMenu;
            txtIncAmount.ContextMenuStrip = blankContextMenu;
            txtIncNewType.ContextMenuStrip = blankContextMenu;
            txtBalance.ContextMenuStrip = blankContextMenu;
        }

        private void cbxSelectDefaultItem()
        {
            cbxOutOperation.SelectedIndex = 0;
            cbxOutDaily.SelectedIndex = 0;
            cbxIncOperation.SelectedIndex = 0;
        }

        private void LoadDgvColumnsNames()
        {
            // dgvListOut
            dgvListOut.Columns.Add("Name", "Name");
            dgvListOut.Columns.Add("Amount", "Amount");
            // dgvListOutOthers
            dgvListOutOthers.Columns.Add("Name", "Name");
            dgvListOutOthers.Columns.Add("Amount", "Amount");
            // dgvListOutTypes
            dgvListOutTypes.Columns.Add("Name", "Name");
            dgvListOutTypes.Columns.Add("Daily", "Daily");
            // dgvListInc
            dgvListInc.Columns.Add("Name", "Name");
            dgvListInc.Columns.Add("Amount", "Amount");
            // dgvListIncTypes
            dgvListIncTypes.Columns.Add("Name", "Name");
        }

        // Update dgvMethods
        private void UpdateDgvListOut()
        {
            // We load the dgvListOut query
            int typeId = 2; // Outflow
            bool Daily = true; // Daily
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));

            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();            
            List<Modelo.MovementDetail> listOutMovDetDaily = logicaMovDet.ReadByTypeDailyMonthYear(typeId, Daily ,Month, Year);
            
            // We clean the content of the datagridview
            dgvListOut.Rows.Clear();
            
            Double sub_total = 0;
            // We load all rows from the list
            foreach (var movementDetail in listOutMovDetDaily)
            {
                dgvListOut.Rows.Add(movementDetail.Name, movementDetail.Amount.ToString("N2").Replace(".", ""));
                sub_total += movementDetail.Amount;
            }

            // Update the subtotal
            txtOutDailySub.Text = sub_total.ToString("N2").Replace(".", "");
        }     

        private void UpdateDgvListOutOthers()
        {
            // We load the dgvListOutOthers query
            int typeId = 2; // Outflow
            bool Daily = false; // no Daily
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));

            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();
            List<Modelo.MovementDetail> listOutMovDetOthers = logicaMovDet.ReadByTypeDailyMonthYear(typeId, Daily, Month, Year);

            // We clean the content of the datagridview
            dgvListOutOthers.Rows.Clear();
            
            Double sub_total = 0;
            // We load all rows from the list
            foreach (var movementDetail in listOutMovDetOthers)
            {
                dgvListOutOthers.Rows.Add(movementDetail.Name, movementDetail.Amount.ToString("N2").Replace(".", ""));
                sub_total += movementDetail.Amount;
            }
            // Update the subtotal
            txtOutDailyOthers.Text = sub_total.ToString("N2").Replace(".", "");
        }

        private void UpdateDgvListOutTypes()
        {
            // We load the dgvListOutTypes query
            int typeId = 2; //Outflow
            Logica.Detail logicaDetail = new Logica.Detail();
            List<Modelo.Detail> listOutflows = logicaDetail.GetDetailsByType(typeId);

            Logica.Outflow logicaOutflow = new Logica.Outflow();
            // We load all rows from the list
            foreach (var Outflows in listOutflows)
                dgvListOutTypes.Rows.Add(Outflows.Name, logicaOutflow.DailyBoolToYesNo(Outflows.Daily));
        }

        private void UpdateDgvListInc()
        {
            // We load the dgvListInc query
            int typeId = 1; // Income
            bool Daily = false; // no Daily
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));

            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();
            List<Modelo.MovementDetail> listIncMovDet = logicaMovDet.ReadByTypeDailyMonthYear(typeId, Daily, Month, Year);

            Double sub_total = 0;
            // We load all rows from the list
            foreach (var movementDetail in listIncMovDet)
            {
                dgvListInc.Rows.Add(movementDetail.Name, movementDetail.Amount.ToString("N2").Replace(".", ""));
                sub_total += movementDetail.Amount;
            }
            txtIncSub.Text = sub_total.ToString("N2").Replace(".", "");
        }

        private void UpdateDgvListIncTypes()
        {
            // We load the dgvListIncTypes query
            int typeId = 1;// Income

            Logica.Detail logicaDetail = new Logica.Detail();
            List<Modelo.Detail> listIncomes = logicaDetail.GetDetailsByType(typeId);
            // We load all rows from the list
            foreach (var Income in listIncomes)
                dgvListIncTypes.Rows.Add(Income.Name);
        }
        // End Update dgvMethods

        private bool ReadOutType(string newType, bool newDaily)
        {
            // We search if the new type to add to the dgvListOutTypes already exists
            Logica.Detail logicaDetail = new Logica.Detail();
            Modelo.Detail Detail = logicaDetail.ReadByNameDailyType(newType, newDaily, 2);
            if (Detail != null)
            { 
                if (Outflow == newType)
                    return false;
                else
                    return true;//If it already exists, it returns true and we don't allow it to be loaded again
            }
            else
                return false;
        }

        private bool ReadMovDetByName(string newName)
        {
            // We search if the outflow already exists to add it to the dgvListOut
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));
            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();

            if (logicaMovDet.ReadByNameMonthYear(newName, Month, Year))
                return true;//If it already exists, it returns true and we don't allow it to be loaded again
            else
                return false;
        }

        private void AddOutflowNewType()
        {
            // We insert the new type(Outflow)
            Logica.Outflow logicaOutflow = new Logica.Outflow();

            var newDetail = new Modelo.Detail
            {
                Name = txtOutNewType.Text.Trim(),
                typeId = 2,
                Daily = logicaOutflow.DailyStringToYesNo(cbxOutDaily.Text),
                State = true
            };

            Logica.Detail logicaDetail = new Logica.Detail();
            logicaDetail.AddDetail(newDetail);
        }

        private void AddMovement(string outflowName)
        {
            // We insert the new outflow		
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));
            Logica.Detail logicaDetail = new Logica.Detail();
            // We use logicaDetail.ReadByName(outflowName) to get the Id by name

            var newMovement = new Modelo.Movement
            {
                detailId = logicaDetail.ReadByName(outflowName),
                Amount = 0,
                Month = Month,
                Year = Year
            };

            Logica.Movement logicaMovement = new Logica.Movement();
            logicaMovement.AddMovement(newMovement); // Add the new Movement
        }

        private void UpdateMovement(string outflowName, Double Amount)
        {
            // We update the outflow(Amount)	
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));
            Logica.Detail logicaDetail = new Logica.Detail();
            // We use logicaDetail.ReadByName(outflowName) to get the Id by name

            var updateValues = new Modelo.Movement
            {
                detailId = logicaDetail.ReadByName(outflowName),
                Amount = Amount,
                Month = Month,
                Year = Year
            };

            Logica.Movement logicaMovement = new Logica.Movement();
            logicaMovement.UpdateMovement(updateValues);
        }

        private void UpdateOutflowName()
        {
            // We update the outflow(Name, Daily)
            Logica.Detail logicaDetail = new Logica.Detail();
            logicaDetail.UpdateOutflowName(txtOutNewType.Text, cbxOutDaily.Text, Outflow);
        }

        private void UpdateDetailState(string detailName)
        {
            // We update the outflow(State)
            Logica.Detail logicaDetail = new Logica.Detail();
            logicaDetail.UpdateDetailState(detailName);
        }

        private void DeleteMovement(string movementName)
        {
            // We delete the movement	
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));
            Logica.Detail logicaDetail = new Logica.Detail();
            // We use logicaDetail.ReadByName(movementName) to get the Id by name
            int detailId = logicaDetail.ReadByName(movementName);
            Logica.Movement logicaMovement = new Logica.Movement();
            logicaMovement.DeleteMovement(detailId, Month, Year);
        }

        private bool ReadIncomeType(string newType)
        {
            Logica.Detail logicaDetail = new Logica.Detail();

            // We search if the new type to add from the dgvListIncTypes already exists
            //false = no daily && 1 = type = Income
            if (logicaDetail.ReadByNameDailyType(newType, false, 1) != null)
            {
                if (Income == newType)
                {
                    return false;
                }
                {
                    return true;// If it already exists, it returns true and we do not allow it to be loaded again
                }
            }
            else
            {
                return false;
            }
        }

        private bool ReadIncome(string incomeName)
        {
            // We search if the entry to add to the dgvListInc already exists
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));

            Logica.Detail logicaDetail = new Logica.Detail();
            // We use logicaDetail.ReadByName(incomeName) to get the Id by name
            int detailId = logicaDetail.ReadByName(incomeName);

            Logica.Movement logicaMovement = new Logica.Movement();
            
            if (logicaMovement.ReadByIdMonthYear(detailId, Month, Year) != null)
            {
                return true;// If it already exists, it returns true and we do not allow it to be loaded again
            }
            else
            {
                return false;
            }
        }

        private void AddIncomeNewType()
        {
            // We insert the new type(Income)
            Logica.Outflow logicaOutflow = new Logica.Outflow();

            var newDetail = new Modelo.Detail
            {
                Name = txtIncNewType.Text.Trim(),
                typeId = 1,
                Daily = logicaOutflow.DailyStringToYesNo("No"),
                State = true
            };

            Logica.Detail logicaDetail = new Logica.Detail();
            logicaDetail.AddDetail(newDetail);
        }

        private void VerifyDb()
        {
            // We verify that the db has loaded at least one outflow in the selected month and year of the dtp
            Logica.Context logicaContext = new Logica.Context();

            if (logicaContext.VerifyDb() == false)
                verifyDb = 0;//If it is empty => load 0
            else
                verifyDb = 1;//If it have at least one record loaded => load 1
        }

        private void UpdateDgv()
        {
            //It is responsible for verifying the selected tabpage and updating the corresponding dgv
            if (verifyDb == 0)
            {
                VerifyDb();
            }

            var tab = tbcMain.SelectedTab.Text;//We get the name of the selected tabpage		
            if (tab == "Outflows")
            {
                UpdateDgvListOut();
                UpdateDgvListOutOthers();
                if ((dgvListOut.Rows.Count == 0) && (dgvListOutOthers.Rows.Count == 0) && (dateDtp == "") && (verifyDb == 1))
                {
                    DialogResult result = MessageBox.Show("There are no outflows loaded in the selected month. Do you want to preload the types of outflows that already exist?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dateDtp = dtpMain.Value.ToString("MMMM yyyy");
                        this.Hide();
                        frmOutflowsPreload frmOutPre = new frmOutflowsPreload();
                        frmOutPre.Show();
                    }
                }
            }
            if (tab == "Incomes")
            {
                UpdateDgvListInc();
            }

            // Update txtBalance
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            string Month = dtpMain.Value.ToString("MMMM");
            int Year = Convert.ToInt32(dtpMain.Value.ToString("yyyy"));

            Double totalIncomes = 0, totalOutflows = 0;
            Logica.MovementDetail logicaMovDet = new Logica.MovementDetail();

            int typeId = 1;// 1= Income
            totalIncomes = logicaMovDet.GetTotalAmount(typeId,Month, Year);// Get the total incomes
            typeId = 2;// 2 = Outflows
            totalOutflows = logicaMovDet.GetTotalAmount(typeId, Month, Year);// Get the total outflows

            Double Balance = (totalIncomes - totalOutflows);
            if (Balance > 0)
            {
                txtBalance.ForeColor = Color.Green;
            }
            if (Balance < 0)
            {
                txtBalance.ForeColor = Color.Red;
            }
            if (Balance == 0)
            {
                txtBalance.ForeColor = Color.Black;
            }
            txtBalance.Text = Balance.ToString("N2");
        }        

        private void updateIncomeType()
        {
            string incomeTypeNew = txtIncNewType.Text;
            Logica.Detail logicaDetail = new Logica.Detail();
            logicaDetail.UpdateIncomeType(Income, incomeTypeNew);
            UpdateDgvListIncTypes(); // We update dgvListIncTypes
        }        

        // Notes
        private void IniNotes()
        {
            string notesPath = Environment.CurrentDirectory + @"\Notes.txt";
            if (File.Exists(notesPath))
            {
                Logica.Note logicaNote = new Logica.Note();
                string[] Lines = logicaNote.IniNotes(notesPath);
                int conta = 1;
                foreach (string line in Lines)
                {
                    // We load each line of the txt in the rtbNotes and add a line break at the end of each one
                    if (conta != Lines.Length)
                    {
                        rtbNotes.AppendText(line + Environment.NewLine);
                    }
                    else// But if it's in the last position we don't add a line break at the end
                    {
                        rtbNotes.AppendText(line);
                    }
                    conta++;
                }
            }
            else
            {
                MessageBox.Show("The 'Notes.txt' file does not exist in the 'GastosApp' folder. Please restart the application so that it can be generated automatically.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }        

        private void UpdateNotes()
        {
            string notesPath = Environment.CurrentDirectory + @"\Notes.txt";
            if (File.Exists(notesPath))
            {
                Logica.Note logicaNote = new Logica.Note();
                string[] Lines = rtbNotes.Lines;
                logicaNote.UpdateNotes(notesPath, Lines);                
            }
        }        

        // Others methods

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateNotes();
            Application.Exit();
        }        

        private void btnOutTypesNew_Click(object sender, EventArgs e)
        {
            Outflow = "";//We whiten the egress variable
            gbxOutTypes.Size = new Size(258, 482);
            txtOutNewType.Focus();
            editType = 0;//We set it to zero to verify that it is a new type and is not being edited
        }

        private void btnOutTypesSave_Click(object sender, EventArgs e)
        {
            // We save the name of the selected type
            if (txtOutNewType.Text.Trim() != "")
            {
                string newType = txtOutNewType.Text.Trim();
                Logica.Outflow logicaOutflow = new Logica.Outflow();
                bool Daily = logicaOutflow.DailyStringToYesNo(cbxOutDaily.Text);
                if (editType == 0)// A new type is loading
                {
                    if (ReadOutType(newType, Daily))// We pass the selected type and if it is of the daily type
                    {
                        MessageBox.Show("The entered type is already loaded.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AddOutflowNewType();// We insert the new type
                        UpdateDgvListOutTypes();// We update the dgvListOutTypes with the new loaded type
                        txtOutNewType.Text = "";
                        gbxOutTypes.Size = new Size(258, 423);
                    }
                }

                if (editType == 1)
                {
                    if (ReadOutType(newType, Daily))// We pass the selected type and if it is of the daily type
                    {
                        MessageBox.Show("The entered type is already loaded.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        UpdateOutflowName();
                        UpdateDgvListOutTypes();//We update the dgvListOutTypes with the new loaded type
                        UpdateDgvListOut();
                        UpdateDgvListOutOthers();
                        txtOutNewType.Text = "";
                        gbxOutTypes.Size = new Size(258, 423);
                    }
                }
                Outflow = "";
            }
            else
            {
                MessageBox.Show("You must complete the field 'Name'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvDoubleClickFilter(object sender, DataGridViewCellEventArgs e)
        {
            // We load the value in the lblOutValue, and we also store the name of the outflow
            DataGridView dgvDoubleClick = ((DataGridView)sender);
            if (((dgvDoubleClick.Name == "dgvListOut") || (dgvDoubleClick.Name == "dgvListOutOthers")) && (e.RowIndex > -1))
            {
                Outflow = dgvDoubleClick.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                lblOutName.Text = Outflow;
                lblOutValue.Text = dgvDoubleClick.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                txtOutAmount.Enabled = true;
                txtOutAmount.Focus();
            }
            if ((dgvDoubleClick.Name == "dgvListOut") && (e.RowIndex > -1))
            {
                // We load the value in the lblIncValue, and we also store the name of the income
                Income = dgvDoubleClick.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                lblIncName.Text = Income;
                lblIncValue.Text = dgvDoubleClick.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                txtIncAmount.Enabled = true;
                txtIncAmount.Focus();
            }
        }

        private void txtOutAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnOutSave.PerformClick();
            }
        }

        private void btnOutSave_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtOutAmount.Text, out _)) // If return true is numeric
            {
                if (txtOutAmount.Text != "")
                {
                    // We update the dgvListOut with the new data entered
                    Outflow = lblOutName.Text;
                    Double Amount = 0;
                    	
                    lblOutValue.Text = lblOutValue.Text.Replace(".", ",");
                    txtOutAmount.Text = txtOutAmount.Text.Replace(".", "");

                    if (cbxOutOperation.Text == "+")
                    {
                        //Convert string to float --> para esto usamos Convert.ToSingle	
                        Amount = Convert.ToSingle(lblOutValue.Text) + Convert.ToSingle(txtOutAmount.Text);
                    }
                    else
                    {
                        Amount = Convert.ToSingle(lblOutValue.Text) - Convert.ToSingle(txtOutAmount.Text);
                    }
                    UpdateMovement(Outflow, Amount);// We update the amount in the db
                    UpdateDgvListOut();// We refresh the dgvListOut
                    UpdateDgvListOutOthers();// We refresh the dgvListOutOthers

                    lblOutValue.Text = txtOutAmount.Text;// We keep the value of the last loaded egress
                    txtOutAmount.Text = "";
                    txtOutAmount.Enabled = false;
                    // We update txtBalance
                    UpdateBalance();
                }
                else
                {
                    MessageBox.Show("You must enter an amount.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Wrong outflow value", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOutAmount.Focus();
            }            
        }

    }
}
