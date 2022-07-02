using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Note
    {
        public string[] IniNotes(string notesPath)
        {
            string[] Lines = File.ReadAllLines(notesPath);            
            return Lines;
        }

        public void UpdateNotes(string notesPath, string[] Lines)
        {            
            StreamWriter file = new StreamWriter(notesPath);
            foreach (string line in Lines)
            {
                file.WriteLine(line);
            }
            file.Close();
        }
    }
}
