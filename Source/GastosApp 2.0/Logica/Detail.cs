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

        public void AddDetail(string detailName, int valueTypeId, string strDaily)
        {
            // We insert the new outflow
            Operations logicaOutflow = new Operations();
            var newDetail = new Modelo.Detail
            {
                Name = detailName,
                typeId = valueTypeId,
                Daily = logicaOutflow.DailyStringToYesNo(strDaily),
                State = true
            };
            datosDetail.AddDetail(newDetail);
        }

        public List<Modelo.Detail> GetDetailsByType(int typeId)
        {
            return datosDetail.GetDetailsByType(typeId);
        }

        public List<Modelo.Detail> GetDetailsByTypeDaily(int typeId, bool Daily)
        {
            return datosDetail.GetDetailsByTypeDaily(typeId, Daily);
        }

        public int ReadByName(string detailName)
        {
            return datosDetail.ReadByName(detailName);
        }

        public void UpdateIncomeName(string newName, string incomeName)
        {
            datosDetail.UpdateIncomeName(newName, incomeName);
        }

        public void UpdateOutflowName(string newName, string Daily, string outflowName)
        {
            Operations logicaOperations = new Operations();
            bool boolDaily = logicaOperations.DailyStringToYesNo(Daily);
            datosDetail.UpdateOutflowName(newName, boolDaily, outflowName);
        }

        public void DeleteDetail(string detailName)
        {            
            Detail logicaDetail = new Detail();
            Movement logicaMovement = new Movement();
            int detailId = logicaDetail.ReadByName(detailName);// We get the Id by name
            logicaMovement.DeleteMovement(detailId);// 1ro - Eliminate associated movements
            datosDetail.DeleteDetail(detailName);// 2do - Remove the detail
        }
    }
}
