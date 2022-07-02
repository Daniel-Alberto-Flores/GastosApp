using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MovementDetail
    {
        Datos.MovementDetail datosMovDet = new Datos.MovementDetail();
        
        public Double GetTotalAmount(DateTime Date)
        {
            Operations logicaOperations = new Operations();
            int Month = logicaOperations.GetMonth(Date);
            int Year = logicaOperations.GetYear(Date);
            Double totalIncomes = 0, totalOutflows = 0, Balance = 0;
            totalIncomes = datosMovDet.GetTotalAmount(1, Month, Year); ;// Get the total incomes(1)
            totalOutflows = datosMovDet.GetTotalAmount(2, Month, Year);// Get the total outflows(2)
            Balance = totalIncomes - totalOutflows;
            return Balance;           
        }

        public List<Modelo.MovementDetail> ReadByTypeDailyMonthYear(DateTime Date, int typeId, bool boolDaily)
        {
            Operations logicaOperations = new Operations();
            int Month = logicaOperations.GetMonth(Date);
            int Year = logicaOperations.GetYear(Date);
            return datosMovDet.ReadByTypeDailyMonthYear(typeId, boolDaily, Month, Year);
        }

        public bool ReadByNameMonthYear(DateTime Date, string newName)
        {
            // We search if the outflow already exists to add it to the dgvListOut
            Operations logicaOperations = new Operations();
            int Month = logicaOperations.GetMonth(Date);
            int Year = logicaOperations.GetYear(Date);
            return datosMovDet.ReadByNameMonthYear(newName, Month, Year);
        }
    }
}
