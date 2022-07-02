using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Context
    {
        Modelo.DatabaseContext db = new Modelo.DatabaseContext();

        public bool CreateDb()
        {
            bool createState = true;
            try
            {
                // If 'Database.db' does not exist we must create it and load the default values
                db.Database.EnsureCreatedAsync();
                List<Modelo.Configuration> configurationList = new List<Modelo.Configuration>();
                configurationList.AddRange(new List<Modelo.Configuration>
                {
                    new Modelo.Configuration(){Language = "English"}
                });
                db.AddRange(configurationList);
                List<Modelo.Type> typeList = new List<Modelo.Type>();
                typeList.AddRange(new List<Modelo.Type>
                {
                    new Modelo.Type("Income"),
                    new Modelo.Type("Outflow")
                });
                db.AddRange(typeList);
                db.SaveChanges();
            }
            catch (Exception)
            {
                createState = false;// If we cant created the db we return false and shutdown the app
            }
            return createState;
        }

        public bool VerifyDb()
        {
            // We verify that the db has loaded at least one outflow in the selected month and year of the dtp
            var listDetails = (from d in db.Details
                               where (d.State == true) && (d.typeId == 2)
                               select d).ToList();
            if (listDetails.Count > 0)
                return true;
            else
                return false;// If the database not has outflows return false
        }
    }
}
