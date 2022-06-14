using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class MovementDetail
    {
        Modelo.DatabaseContext db = new Modelo.DatabaseContext();

        public Double GetTotalAmount(int typeId, string Month, int Year)
        {
            //Double totalAmount = 0;
            Double totalAmount = (from mov in db.Movements
                                  join det in db.Details on mov.detailId equals det.Id
                                  where (det.typeId == typeId) && (mov.Month == Month) && (mov.Year == Year)
                                  select mov.Amount).Sum();

            return totalAmount;
        }

        public List<Modelo.MovementDetail> ReadByTypeDailyMonthYear(int typeId, bool Daily, string Month, int Year)
        {
            var listFiltered = (from mov in db.Movements
                                join det in db.Details on mov.detailId equals det.Id
                                where (det.typeId == typeId) && (det.Daily == Daily)
                                && (mov.Month == Month) && (mov.Year == Year)
                                orderby det.Name
                                select new Modelo.MovementDetail
                                {
                                    Name = det.Name,
                                    Amount = mov.Amount
                                }).ToList();
            return listFiltered;
        }

        public bool ReadByNameMonthYear(string newName, string Month, int Year)
        {
            var itemMovement = (from mov in db.Movements
                                join det in db.Details on mov.detailId equals det.Id
                                where (det.Name == newName) && (mov.Month == Month) && (mov.Year == Year)
                                select mov).First();
            if (itemMovement != null)
                return true;
            else
                return false;
        }

    }
}
