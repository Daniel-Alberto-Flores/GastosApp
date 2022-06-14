using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Movement
    {
        Modelo.DatabaseContext db = new Modelo.DatabaseContext();

        public void AddMovement(Modelo.Movement newMovement)
        {
            // We add the new movement
            db.Movements.Add(newMovement);
            db.SaveChanges();
        }

        public Modelo.Movement ReadByIdMonthYear(int detailId, string Month, int Year)
        {
            var itemMovement = (from m in db.Movements
                                where (m.detailId == detailId) && (m.Month == Month) && (m.Year == Year)
                                select m).First();
            return itemMovement;
        }

        public void UpdateMovement(Modelo.Movement updateValues)
        {
            var movementToUpdate = (from m in db.Movements
                                   where (m.detailId == updateValues.detailId)
                                   && (m.Month == updateValues.Month) && (m.Year == updateValues.Year)
                                   select m).First();
            movementToUpdate.Amount = updateValues.Amount;
            db.SaveChanges();
        }

        public void DeleteMovement(int detailId, string Month, int Year)
        {
            var movementToDelete = (from m in db.Movements
                                    where (m.detailId == detailId) && (m.Month == Month) && (m.Year == Year)
                                    select m).First();
            db.Movements.Remove(movementToDelete);
            db.SaveChanges();        
        }
    }
}
