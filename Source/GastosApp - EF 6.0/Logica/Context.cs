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

        public void CreateDb()
        {
            datosContext.CreateDb();
        }
    }
}
