using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Context
    {
        Datos.Context datosContext = new Datos.Context();

        public bool VerifyDb()
        {
            return datosContext.VerifyDb();
        }

        public bool VerifyDbExists()
        {            
            string pathDb = System.Environment.CurrentDirectory + "\\Database.db";
            if (File.Exists(pathDb))
                return true;// If the db exists we return true
            else
                return false;// If the database does not exist we return false
        }

        public bool CreateDb()
        {
            if (datosContext.CreateDb())
                return true;// If we create the db we return true
            else
                return false;// If we can't create the db we return false
        }
    }
}
