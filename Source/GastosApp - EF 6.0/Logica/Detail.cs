using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Detail
    {
        Datos.Detail datosDetail = new Datos.Detail();

        public void AddDetail(Modelo.Detail newDetail)
        {
            datosDetail.AddDetail(newDetail);
        }

        public List<Modelo.Detail> GetDetailsByType(int typeId)
        {
            return datosDetail.GetDetailsByType(typeId);
        }

        public int ReadByName(string detailName)
        {
            return datosDetail.ReadByName(detailName);
        }

        public Modelo.Detail ReadByNameDailyType(string newType, bool newDaily, int typeId)
        {
            return datosDetail.ReadByNameDailyType(newType, newDaily, typeId);
        }

        public void UpdateIncomeType(string Income, string incomeTypeNew)
        {
            datosDetail.UpdateIncomeType(Income, incomeTypeNew);
        }

        public void UpdateOutflowName(string newName, string Daily, string outflowName)
        {
            bool boolDaily;
            if ((Daily == "Yes") && (Daily == "Si"))
                boolDaily = true;
            else
                boolDaily = false;
            datosDetail.UpdateOutflowName(newName, boolDaily, outflowName);
        }

        public void UpdateDetailState(string detailName)
        {
            datosDetail.UpdateDetailState(detailName);
        }
    }
}
