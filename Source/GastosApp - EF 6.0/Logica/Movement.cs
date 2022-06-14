using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Movement
    {
        Datos.Movement datosMovement = new Datos.Movement();

        public void AddMovement(Modelo.Movement newMovement)
        {
            datosMovement.AddMovement(newMovement);
        }

        public Modelo.Movement ReadByIdMonthYear(int detailId, string Month, int Year)
        {
            return datosMovement.ReadByIdMonthYear(detailId, Month, Year);
        }

        public void UpdateMovement(Modelo.Movement updateValues)
        {
            datosMovement.UpdateMovement(updateValues);
        }

        public void DeleteMovement(int detailId, string Month, int Year)
        {
            datosMovement.DeleteMovement(detailId, Month, Year);
        }
        
    }
}
