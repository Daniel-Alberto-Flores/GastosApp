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

        public Modelo.Movement ReadByIdMonthYear(int detailId, int Month, int Year)
        {
            var itemMovement = (from m in db.Movements
                                where (m.detailId == detailId) && (m.Month == Month) && (m.Year == Year)
                                select m).FirstOrDefault();
            return itemMovement;
        }

        public void UpdateMovement(Modelo.Movement updateValues)
        {
            var movementToUpdate = (from m in db.Movements
                                   where ((m.detailId == updateValues.detailId)
                                   && (m.Month == updateValues.Month) && (m.Year == updateValues.Year))
                                   select m).FirstOrDefault();
            movementToUpdate.Amount = updateValues.Amount;
            db.SaveChanges();
        }

        public void DeleteMovement(int detailId)
        {
            // We delete the movement
            var movementsToDelete = (from m in db.Movements
                                    where (m.detailId == detailId)
                                    select m).ToList();
            foreach (var Movement in movementsToDelete)
                db.Movements.RemoveRange(Movement);
            db.SaveChanges();
        }

        public void DeleteMovementByMonthYear(int detailId, int Month, int Year)
        {
            // We delete the movement
            var movementToDelete = (from m in db.Movements
                                    where (m.detailId == detailId) && (m.Month == Month) && (m.Year == Year)
                                    select m).FirstOrDefault();
            db.Movements.Remove(movementToDelete);
            db.SaveChanges();    
        }
    }
}
