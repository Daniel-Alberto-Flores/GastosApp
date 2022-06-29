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
    public partial class frmMain : Form
    {
        Modelo.Configuration Configurations = new Modelo.Configuration();

        public frmMain(Modelo.Configuration configurations = null)
        {
            InitializeComponent();
            VerifyDbExists();// If 'Database.db' does not exist we must create it and load the default values
            if (configurations == null)
                GetConfiguration();// We get the configurations values if Configurations == null
            else
                Configurations = configurations;            
            cbxLanguage.Text = Configurations.Language;            
        }

        private void FrmMainShown(object sender, EventArgs e)
        {
            TranslateControls();// We translate the text of the controls
        }

        private void BtnClickFilter(object sender, EventArgs e)
        {
            Button btnPressed = (Button)sender;
            switch (btnPressed.Text)
            {
                case "Outflows":
                case "Egresos":
                    this.Hide();
                    frmOutflows frmOut = new frmOutflows(Configurations);
                    frmOut.Show();
                    break;
                case "Incomes":
                case "Ingresos":
                    this.Hide();
                    frmIncomes frmInc = new frmIncomes(Configurations);
                    frmInc.Show();
                    break;
                case "Notes":
                case "Notas":
                    this.Hide();
                    frmNotes frmNot = new frmNotes(Configurations);
                    frmNot.Show();
                    break;
                case "Help":
                case "Ayuda":
                    this.Hide();
                    frmHelp frmHel = new frmHelp(Configurations);
                    frmHel.Show();
                    break;
                case "About":
                case "Acerca de":
                    this.Hide();
                    frmAbout frmAbout = new frmAbout(Configurations);
                    frmAbout.Show();
                    break;
            }
        }

        private void BtnLanguageSaveClick(object sender, EventArgs e)
        {
            Logica.Configuration logicaConfiguration = new Logica.Configuration();
            logicaConfiguration.UpdateLanguage(cbxLanguage.Text);
            Configurations.Language = cbxLanguage.Text;
            Logica.Operations logicaOperations = new Logica.Operations();
            frmMain.ActiveForm.Name.ToString();
            string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "LanguageUpdated");
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TranslateControls();
        }

        private void FrmMainFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Methods

        private void VerifyDbExists()
        {
            Logica.Context logContext = new Logica.Context();
            if (!logContext.VerifyDbExists())
            {
                // The default language is English. We not have to translate this texts
                if (logContext.CreateDb())
                    MessageBox.Show("Database created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("The database could not be created. Restart the app.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }

        private void GetConfiguration()
        {
            Logica.Configuration logicaConfiguration = new Logica.Configuration();
            Configurations = logicaConfiguration.GetConfiguration();
        }

        private void TranslateControls()
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            btnOutflows.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "btnOutflows");
            btnIncomes.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "btnIncomes");
            btnNotes.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "btnNotes");
            btnHelp.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "btnHelp");
            btnAbout.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "btnAbout");
            lblLanguage.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblLanguage");
            
            if (Configurations.Language == "Español")
            {
                // Control Location
                lblLanguage.Location = new Point(28, 8);
                ttipShowInfo.SetToolTip(btnLanguageSave, "Guardar");
                ttipShowInfo.SetToolTip(btnOutflows, "Te permite cargar los egresos.");
                ttipShowInfo.SetToolTip(btnIncomes, "Te permite cargar los ingresos.");
                ttipShowInfo.SetToolTip(btnNotes, "Te permite añadir notas.");
                ttipShowInfo.SetToolTip(btnHelp, "Manual de usuario.");
                ttipShowInfo.SetToolTip(btnAbout, "Acerca de GastossApp.");
            }            
            if (Configurations.Language == "English")
            {
                // Control Location
                lblLanguage.Location = new Point(12, 8);
                ttipShowInfo.SetToolTip(btnLanguageSave, "Save");
                ttipShowInfo.SetToolTip(btnOutflows, "Allows you to load outflows.");
                ttipShowInfo.SetToolTip(btnIncomes, "Allows you to load incomes.");
                ttipShowInfo.SetToolTip(btnNotes, "Allows you to add notes.");
                ttipShowInfo.SetToolTip(btnHelp, "Manual user.");
                ttipShowInfo.SetToolTip(btnAbout, "About of GastosApp.");
            }                     
        }      
    }
}
