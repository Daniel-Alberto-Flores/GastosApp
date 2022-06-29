using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Operations
    {
        public Double CalculeAmount(string currentValue, string valueTo, string strOperator)// valueTo is the value to add or subtract
        {
            Double Amount = 0;
            currentValue = currentValue.Replace(".", ",");
            valueTo = valueTo.Replace(".", ",");
            if (strOperator == "+")// Convert string to float --> For this we use Convert.ToSingle
                Amount = Convert.ToSingle(currentValue) + Convert.ToSingle(valueTo);
            else
                Amount = Convert.ToSingle(currentValue) - Convert.ToSingle(valueTo);
            return Amount;
        }

        public Modelo.Color CalculeBalanceColor(Double Balance)
        {
            Modelo.Color rgbValue;
            if (Balance > 0)
            {
                rgbValue = new Modelo.Color() { Red = 0, Green = 80, Blue = 0 };// Green rgb values
            }                
            else
            {
                if (Balance < 0)
                    rgbValue = new Modelo.Color() { Red = 255, Green = 0, Blue = 0 };// Red rgb values
                else
                    rgbValue = new Modelo.Color() { Red = 0, Green = 0, Blue = 0 };// Red rgb values
            }
            return rgbValue;
        }

        public string DailyBoolToYesNo(string Language, bool Daily)
        {
            if (Daily)
            {
                if (Language == "Español")
                    return "Si";
                else// Language == "English"
                    return "Yes";
            }
            else
                return "No";
        }

        public bool DailyStringToYesNo(string Daily)
        {
            if ((Daily == "Yes") || (Daily == "Si"))
                return true;
            else
                return false;
        }

        public int GetMonth(DateTime Date)
        {
            int Month = Date.Month;
            return Month;
        }

        public int GetYear(DateTime Date)
        {
            int Year = Convert.ToInt32(Date.ToString("yyyy"));
            return Year;
        }

        public bool KeyFilter(string senderToString, string eToString)
        {
            if ((senderToString.Contains(".")) && (eToString == ".") || (eToString == ","))
                return true;// We suppress the pressing of the . two times and don't allow the comma key
            else
                return false;                      
        }        

        public string LanguageFilter(string Language, string formName, string Type, string Filter)
        {
            // We used this for filter Language
            string Message = "";
            switch (Language)
            {
                case "Español":
                    TranslateToSpanish logicaToSpanish = new TranslateToSpanish();
                    Message = logicaToSpanish.FormFilter(formName, Type, Filter);
                    break;
                case "English":
                    TranslateToEnglish logicaToEnglish = new TranslateToEnglish();
                    Message = logicaToEnglish.FormFilter(formName, Type, Filter);
                    break;
            }
            return Message;
        }

        public bool LengthFilter(string senderToString)
        {
            if (senderToString.Length >= 14)
                return true;// We suppress the pressing of key if the length is > 14
            else
                return false;
        }
    }
}
