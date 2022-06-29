using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWF.Forms
{
    public partial class frmAbout : Form
    {
        Modelo.Configuration Configurations = new Modelo.Configuration();
        int verifyClose = 0;

        public frmAbout(Modelo.Configuration configurations)
        {
            InitializeComponent();
            Configurations = configurations;// We get the configurations values            
        }

        private void FrmAboutShown(object sender, EventArgs e)
        {
            TranslateControls();// We translate the text of the controls
        }

        private void BtnReturnClick(object sender, EventArgs e)
        {
            Exit();
        }

        private void FrmAboutFormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        // Methods        

        private void BtnClickFilter(object sender, EventArgs e)
        {
            string Link = "";
            Button btnPressed = (Button)sender;
            switch (btnPressed.Name)
            {
                case "btnSourceForge":
                    Link = "https://sourceforge.net/projects/gastos-app/";
                    break;
                case "btnGitHub":
                    Link = "https://github.com/daniel-alberto-flores";
                    break;
                case "btnLinkedIn":
                    Link = "https://www.linkedin.com/in/daniel-flores-45417517a/";
                    break;
                case "btnOpenSource":
                    Link = "https://es.wikipedia.org/wiki/C%C3%B3digo_abierto";
                    break;
                case "btnCSharp":
                    Link = "https://docs.microsoft.com/en-us/dotnet/csharp/";
                    break;
                case "btnSQLite":
                    Link = "https://www.sqlite.org/index.html";
                    break;
            }
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = Link;
            proc.Start();
        }        

        private void TranslateControls()
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            btnReturn.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "btnReturn");
            lblDeveloped.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblDeveloped");
            lblContact.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "lblContact");
            rtbInfo.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "rtbInfo");

            if (Configurations.Language == "Español")
            {
                // Control Location
                ttipShowInfo.SetToolTip(btnSourceForge, "Visita mi perfil de SourceForge.");
                ttipShowInfo.SetToolTip(btnGitHub, "Visita mi perfil de GitHub.");
                ttipShowInfo.SetToolTip(btnLinkedIn, "Visita mi perfil de LinkedIn.");
                ttipShowInfo.SetToolTip(btnOpenSource, "Software gratuito y de código abierto.");
                ttipShowInfo.SetToolTip(btnCSharp, "Lenguage usado: C#. Visita su sitio web.");
                ttipShowInfo.SetToolTip(btnSQLite, "Motor de base de datos usado: SQLite. Visita su sitio web.");
            }
            if (Configurations.Language == "English")
            {
                // Control Location
                ttipShowInfo.SetToolTip(btnSourceForge, "Visit my SourceForge profile.");
                ttipShowInfo.SetToolTip(btnGitHub, "Visit my GitHub profile.");
                ttipShowInfo.SetToolTip(btnLinkedIn, "Visit LinkedIn profile.");
                ttipShowInfo.SetToolTip(btnOpenSource, "Free and open-source software.");
                ttipShowInfo.SetToolTip(btnCSharp, "Language used: C#. Visit their website.");
                ttipShowInfo.SetToolTip(btnSQLite, "Database engine used: SQLite. Visit their website.");
            }
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
