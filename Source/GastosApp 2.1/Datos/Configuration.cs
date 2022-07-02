using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Configuration
    {
        Modelo.DatabaseContext db = new Modelo.DatabaseContext();
        // We save the values on the first row or Id = 1 and get this

        public Modelo.Configuration GetConfiguration()
        {            
            // We use this to get the configurations values
            var Configuration = (from c in db.Configurations
                                 where (c.Id == 1)
                                 select c).First();
            return Configuration;
        }

        public void UpdateLanguage(string Language)
        {
            var configurationToUpdate = db.Configurations.Find(1);
            configurationToUpdate.Language = Language;
            db.SaveChanges();
        }
    }
}
