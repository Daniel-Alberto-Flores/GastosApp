using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Detail
    {
        Modelo.DatabaseContext db = new Modelo.DatabaseContext();

        public void AddDetail(Modelo.Detail newDetail)
        {
            // We add the new detail
            db.Details.Add(newDetail);
            db.SaveChanges();
        }

        public List<Modelo.Detail> GetDetailsByType(int typeId)
        {
            var listDetails = (from d in db.Details
                               where (d.State == true) && (d.typeId == typeId)
                               orderby d.Name
                               select d).ToList();
            return listDetails;
        }

        public List<Modelo.Detail> GetDetailsByTypeDaily(int typeId, bool Daily)
        {
            var listDetails = (from d in db.Details
                                where (d.State == true) && (d.typeId == typeId) && (d.Daily == Daily)
                                orderby d.Name
                                select d).ToList();
            return listDetails;
        }

        public int ReadByName(string detailName)
        {
            var itemId = (from d in db.Details
                          where (d.Name == detailName)
                          select d.Id).FirstOrDefault();
            return itemId;
        }

        public void UpdateIncomeName(string newName, string incomeName)
        {
            var incomeToUpdate = (from d in db.Details
                                  where (d.Name == incomeName)
                                  select d).First();
            incomeToUpdate.Name = newName;
            db.SaveChanges();
        }

        public void UpdateOutflowName(string newName, bool boolDaily, string outflowName)
        {
            var outflowToUpdate = (from d in db.Details
                                  where (d.Name == outflowName)
                                  select d).First();
            outflowToUpdate.Name = newName;
            outflowToUpdate.Daily = boolDaily;
            db.SaveChanges();
        }

        public void DeleteDetail(string detailName)
        {
            // We delete the detail
            var detailToDelete = (from d in db.Details
                                 where (d.Name == detailName)
                                 select d).First();
            db.Details.Remove(detailToDelete);
            db.SaveChanges();
        }
    }
}
