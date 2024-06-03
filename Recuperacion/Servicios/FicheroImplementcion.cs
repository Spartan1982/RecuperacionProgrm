using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion.Servicios
{
    internal class FicheroImplementcion : FicheroInterfaz
    {
        public void escribirFicheroLog(string mensaje)
        {
            try
            {

                StreamWriter escritor = new StreamWriter(Program.rutaFicheroLog,true);

                escritor.WriteLine(mensaje);
                escritor.Close();

            }catch (IOException ex)
            {
                Console.WriteLine("error al escribir en fichero");

            }

        }
    }

}
