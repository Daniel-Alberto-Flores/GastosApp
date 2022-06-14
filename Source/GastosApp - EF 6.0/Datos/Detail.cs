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
            var listOutflows = (from d in db.Details
                               where (d.State == true) && (d.typeId == typeId)
                               orderby d.Name
                               select d).ToList();
            return listOutflows;
        }

        public int ReadByName(string detailName)
        {
            var itemId = (from d in db.Details
                          where (d.Name == detailName)
                          select d.Id).First();
            return itemId;
        }

        public Modelo.Detail ReadByNameDailyType(string newType, bool newDaily, int typeId)
        {
            var itemDetail = (from d in db.Details
                              where (d.Name == newType) && (d.Daily == newDaily)
                              && (d.typeId == typeId) && (d.State == true)
                              select d).First();
            return itemDetail;
        }

        public void UpdateIncomeType(string Income, string incomeTypeNew)
        {
            Modelo.DatabaseContext db = new Modelo.DatabaseContext();
            var incomeToUpdate = db.Details.Find(Income);
            incomeToUpdate.Name = incomeTypeNew;
            db.SaveChanges();
        }

        public void UpdateOutflowName(string newName, bool boolDaily, string outflowName)
        {
            var outflowToUpdate = db.Details.Find(outflowName);
            outflowToUpdate.Name = newName;
            outflowToUpdate.Daily = boolDaily;
            db.SaveChanges();
        }

        public void UpdateDetailState(string detailName)
        {
            var outflowToUpdate = db.Details.Find(detailName);
            outflowToUpdate.State = false;
            db.SaveChanges();
        }
    }
}
