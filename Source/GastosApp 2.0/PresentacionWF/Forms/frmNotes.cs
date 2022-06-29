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
    public partial class frmNotes : Form
    {
        Modelo.Configuration Configurations = new Modelo.Configuration();

        public frmNotes(Modelo.Configuration configurations)
        {
            InitializeComponent();
            Configurations = configurations;
            IniNotes();// We load the txt of notes
        }

        private void FrmNotesShown(object sender, EventArgs e)
        {
            TranslateControls();// We translate the text of the controls
        }

        private void FrmNotesFormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateNotes();
            this.Hide();
            frmMain frmMai = new frmMain(Configurations);
            frmMai.Show();
        }

        // Methods

        private void TranslateControls()
        {
            // Control text traduction
            Logica.Operations logicaOperations = new Logica.Operations();
            ActiveForm.Text = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Control", "frmNotes");
        }

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
                Logica.Operations logicaOperations = new Logica.Operations();
                string Message = logicaOperations.LanguageFilter(Configurations.Language, ActiveForm.Name, "Message", "IniNotes");
                MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
