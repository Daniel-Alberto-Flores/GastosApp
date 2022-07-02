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

        public void AddMovement(DateTime Date, string detailName)
        {
            // We insert the new movement
            Detail logicaDetail = new Detail();
            Operations logicaOperations = new Operations();
            int Month = logicaOperations.GetMonth(Date);
            int Year = logicaOperations.GetYear(Date);
            var newMovement = new Modelo.Movement
            {
                // We use logicaDetail.ReadByName to get the detailId by name
                detailId = logicaDetail.ReadByName(detailName),
                Amount = 0,
                Month = Month,
                Year = Year
            };
            datosMovement.AddMovement(newMovement);
        }

        public Modelo.Movement ReadByIdMonthYear(DateTime Date, string detailName)
        {
            // We search if the entry to add to the dgvListInc already exists
            Detail logicaDetail = new Detail();
            Operations logicaOperations = new Operations();
            int Month = logicaOperations.GetMonth(Date);
            int Year = logicaOperations.GetYear(Date);
            int detailId = logicaDetail.ReadByName(detailName);// We get the Id by name
            return datosMovement.ReadByIdMonthYear(detailId, Month, Year);
        }

        public void UpdateMovement(DateTime Date, string detailName, Double valueAmount)
        {
            Detail logicaDetail = new Detail();
            Operations logicaOperations = new Operations();
            int Month = logicaOperations.GetMonth(Date);
            int Year = logicaOperations.GetYear(Date);
            var updateValues = new Modelo.Movement
            {   // We use logicaDetail.ReadByName to get the detailId by name
                detailId = logicaDetail.ReadByName(detailName),
                Amount = valueAmount,
                Month = Month,
                Year = Year
            };
            datosMovement.UpdateMovement(updateValues);
        }

        public void DeleteMovement(int detailId)
        {
            datosMovement.DeleteMovement(detailId);
        }

        public bool DeleteMovementByMonthYear(DateTime Date,string detailName)
        {            
            Detail logicaDetail = new Detail();
            Operations logicaOperations = new Operations();
            int Month = logicaOperations.GetMonth(Date);
            int Year = logicaOperations.GetYear(Date);
            int detailId = logicaDetail.ReadByName(detailName);// We get the Id by name

            if (datosMovement.ReadByIdMonthYear(detailId, Month, Year) == null)
            {
                return false;// There is no movement for the selected period
            }
            else
            {
                datosMovement.DeleteMovementByMonthYear(detailId, Month, Year);
                return true;
            }                      
        }
        
    }
}
