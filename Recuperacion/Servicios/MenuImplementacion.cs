using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        internal int seleccionUsuario()
        {
            int opcion;

            Console.WriteLine("0.Se cierra el menu");
            Console.WriteLine("1.Dar de alta");
            Console.WriteLine("2.Dar de baja");
            Console.WriteLine("3. Escribir en fichero");
            Console.WriteLine("Elija una opcion");

            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;

        }

       
    }
}
