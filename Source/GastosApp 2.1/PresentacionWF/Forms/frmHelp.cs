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
    public partial class frmHelp : Form
    {
        Modelo.Configuration Configurations = new Modelo.Configuration();
        int verifyClose = 0;

        public frmHelp(Modelo.Configuration configurations)
        {
            InitializeComponent();
            Configurations = configurations;// We get the configurations values
        }

        private void FrmHelpShown(object sender, EventArgs e)
        {
            TranslateControls();// We translate the text of the controls
            RtbHelpLoadText();
        }

        private void BtnReturnClick(object sender, EventArgs e)
        {
            Exit();
        }

        private void FrmHelpFormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        // Methods

        private void TranslateControls()
        {
            // Control text traduction
            Logica.Operations logicaOperations = new Logica.Operations();
            this.Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "frmHelp");
            btnReturn.Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "btnReturn");
            
            if (Configurations.Language == "Español")
            {
                // Tooltips
                ttipShowInfo.SetToolTip(btnReturn, "Volver al home.");
            }
            if (Configurations.Language == "English")
            {
                // Tooltips
                ttipShowInfo.SetToolTip(btnReturn, "Return to home.");
            }
        }        

        private void RtbHelpLoadText()
        {
            Logica.Operations logicaOperations = new Logica.Operations();
            Font fontTitle = new Font(rtbHelp.Font, FontStyle.Bold | FontStyle.Underline);
            Font fontParagraph = new Font(rtbHelp.Font, FontStyle.Regular);

            // Outflows
            string Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "OutflowsTitle");
            AppendTextToRtbHelp("Center", fontTitle, Text);
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "OutflowsParagraph");
            AppendTextToRtbHelp("Left", fontParagraph, Text);

            // Incomes
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "IncomesTitle");
            AppendTextToRtbHelp("Center", fontTitle, Text);
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "IncomesParagraph");
            AppendTextToRtbHelp("Left", fontParagraph, Text);

            // User guide - Outflows and Incomes
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "UserGuide");
            AppendTextToRtbHelp("Center", fontTitle, Text);
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "UserGuideParagraphOne");
            AppendTextToRtbHelp("Left", fontParagraph, Text);
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "UserGuideParagraphTwo");
            AppendTextToRtbHelp("Left", fontParagraph, Text);

            // Notes
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "NotesTitle");
            AppendTextToRtbHelp("Center", fontTitle, Text);
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "NotesParagraph");
            AppendTextToRtbHelp("Left", fontParagraph, Text);

            // About
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "AboutTitle");
            AppendTextToRtbHelp("Center", fontTitle, Text);
            Text = logicaOperations.LanguageFilter(Configurations.Language, this.Name, "Control", "AboutParagraph");
            AppendTextToRtbHelp("Left", fontParagraph, Text);
        }

        private void AppendTextToRtbHelp(string Aligment, Font fontAssigned, string textToAppend)
        {
            if (Aligment == "Center")
                rtbHelp.SelectionAlignment = HorizontalAlignment.Center;
            else // (Aligment == "Left")
                rtbHelp.SelectionAlignment = HorizontalAlignment.Left;
            rtbHelp.SelectionFont = fontAssigned;
            rtbHelp.AppendText(textToAppend);
        }

        private void Exit()
        {
            if (verifyClose == 0)
            {
                verifyClose = 1;
                this.Hide();
                frmMain frmMai = new frmMain(Configurations);
                frmMai.Show();
            }
        }
    }
}
