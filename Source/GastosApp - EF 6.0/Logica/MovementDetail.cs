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
        
        public Double GetTotalAmount(int typeId, string Month, int Year)
        {
            return datosMovDet.GetTotalAmount(typeId, Month, Year);
        }

        public List<Modelo.MovementDetail> ReadByTypeDailyMonthYear(int typeId, bool Daily, string Month, int Year)
        {
            return datosMovDet.ReadByTypeDailyMonthYear(typeId, Daily, Month, Year);
        }

        public bool ReadByNameMonthYear(string newName, string Month, int Year)
        {
            return ReadByNameMonthYear(newName, Month, Year);
        }
    }
}
