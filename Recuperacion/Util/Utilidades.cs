using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion.Util
{
    internal class Utilidades
    {
        public static string crearNombrefichero()
        {
            string nombreCompleto = "9";

            try
            {
               DateTime fechaActual = DateTime.Today;

                nombreCompleto = String.Concat("log-", fechaActual.ToString("ddMMyy"),".txt");

            }catch (Exception e)
            {
                throw;
            }
            return nombreCompleto;
        }
    }
}
