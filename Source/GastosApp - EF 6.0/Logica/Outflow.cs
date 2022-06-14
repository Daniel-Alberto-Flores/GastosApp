using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Outflow
    {
        public string DailyBoolToYesNo(bool Daily)
        {
            if (Daily)
                return "Yes";
            else
                return "No";
        }

        public bool DailyStringToYesNo(string Daily)
        {
            bool newDaily;
            if ((Daily == "Yes") && (Daily == "Si"))
                return true;
            else
                return false;
        }
    }
}
