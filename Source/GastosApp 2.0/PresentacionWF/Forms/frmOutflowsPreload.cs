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
    public partial class frmOutflowsPreload : Form
    {
		Modelo.Configuration Configurations = new Modelo.Configuration();
		int verifyClose = 0;

		public frmOutflowsPreload(Modelo.Configuration configurations, string dtpValue)
        {
            InitializeComponent();
			Configurations = configurations;
			DtpFormat();// We set the format of the DateTimePicker
            dtpPreload.Value = Convert.ToDateTime(dtpValue);// Value inherited from frmOutflows
			GetDetailsByTypeDaily(2, true);// We get the outflows(2) dailys(true)
			GetDetailsByTypeDaily(2, false);// We get the outflows(2) no dailys(false)
		}

		private void FrmOutflowsPreloadShown(object sender, EventArgs e)
		{
			TranslateControls();// We translate the text of the controls
		}

		private void LoadDgvListOutColumnsNames()
		{   // dgvListOut
			if (Configurations.Language == "Español")
			{
				dgvListOut.Columns.Add("Nombre", "Nombre");
			}
			if (Configurations.Language == "English")
			{
				dgvListOut.Columns.Add("Name", "Name");
			}
			dgvListOut.Columns.Add(CreateDgvCbxColumn());
		}

		private void LoadDgvListOutOthersColumnsNames()
		{   // dgvListOutOthers
			if (Configurations.Language == "Español")
			{
				dgvListOutOthers.Columns.Add("Nombre", "Nombre");
			}
			if (Configurations.Language == "English")
			{
				dgvListOutOthers.Columns.Add("Name", "Name");
			}
			dgvListOutOthers.Columns.Add(CreateDgvCbxColumn());
		}	

		private void BtnSaveClick(object sender, EventArgs e)
		{
			Logica.Operations logicaOperations = new Logica.Operations();
			string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "BtnSaveClick");
			DialogResult result = MessageBox.Show(Message, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				//We insert a new record in the movements table
				string Outflow = "";
				Double Amount = 0;
				DateTime Date = dtpPreload.Value;// We get the date of the dtp
				Logica.Movement logicaMovement = new Logica.Movement();
				foreach (DataGridViewRow Row in dgvListOut.Rows)
                {
					if ((bool)Row.Cells["ckCbxColumn"].Value)
                    {
						if (Configurations.Language == "Español")
							Outflow = Row.Cells["Nombre"].Value.ToString();
						if (Configurations.Language == "English")
							Outflow = Row.Cells["Name"].Value.ToString();
						logicaMovement.AddMovement(Date, Outflow);// We pass the name of the outflow to search for it and insert it in the current period
					}					
				}
				foreach (DataGridViewRow Row in dgvListOutOthers.Rows)
				{
					if ((bool)Row.Cells["ckCbxColumn"].Value)
                    {
						if (Configurations.Language == "Español")
							Outflow = Row.Cells["Nombre"].Value.ToString();
						if (Configurations.Language == "English")
							Outflow = Row.Cells["Name"].Value.ToString();
						logicaMovement.AddMovement(Date, Outflow);
					}					
				}
                if (verifyClose == 0)// We do this check so it doesn't go through the closing event twice
                {
                    Exit();
                }
            }
        }

		private void FrmOutflowsPreloadFormClosing(object sender, FormClosingEventArgs e)
		{
			Exit();
		}

		// Methods

		private void TranslateControls()
        {
			// Control text traduction
			Logica.Operations logicaOperations = new Logica.Operations();
			ActiveForm.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "frmOutflowsPreload");
			gbxDaily.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "gbxDaily");
			gbxOthers.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "gbxOthers");
		}

		private void GetDetailsByTypeDaily(int typeId, bool boolDaily)
		{
			Logica.Detail logicaDetail = new Logica.Detail();
			List<Modelo.Detail> listDetails = logicaDetail.GetDetailsByTypeDaily(typeId, boolDaily);
			if (boolDaily == true) // Outflows daily
				LoadDgvListOutColumnsNames();// We load the headers
			else                  // Outflows no daily
				LoadDgvListOutOthersColumnsNames();// We load the headers
			foreach (var Detail in listDetails)
            {
				if (boolDaily == true)
					dgvListOut.Rows.Add(Detail.Name, true);
				else
					dgvListOutOthers.Rows.Add(Detail.Name, true);
			}
		}

		private void DtpFormat()
		{
			dtpPreload.Format = DateTimePickerFormat.Custom;
			dtpPreload.CustomFormat = "MMMM yyyy";
			dtpPreload.ShowUpDown = true;
		}

		private DataGridViewCheckBoxColumn CreateDgvCbxColumn()
		{
			// We create a DataGridViewCheckBoxColumn at runtime
			DataGridViewCheckBoxColumn cbxColumn = new DataGridViewCheckBoxColumn();
			cbxColumn.Name = "ckCbxColumn";
			cbxColumn.HeaderText = "Check";
			cbxColumn.Width = 30;
			cbxColumn.ReadOnly = false;
			return cbxColumn;
		}

		private void Exit()
        {
			if (verifyClose == 0)
            {
				verifyClose++;
				this.Hide();
				frmOutflows frmOut = new frmOutflows(Configurations, dtpPreload.Value.ToString());
				frmOut.Show();
			}			
		}        
    }
}
