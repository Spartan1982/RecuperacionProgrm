using Recuperacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void alta()
        {
            AlumnoDto alum = new AlumnoDto();

            Console.WriteLine("introduza el nombre");
            alum.Nombre = Console.ReadLine();

            Console.WriteLine("introduza el apellido1");
            alum.Apellido1 = Console.ReadLine();

            Console.WriteLine("introduza el apellido2");
            alum.Apellido2 = Console.ReadLine();

            Console.WriteLine("introduza el dni");
            alum.Dni = Console.ReadLine();

            Console.WriteLine("introduza la direccion");
            alum.Direccion = Console.ReadLine();

            Console.WriteLine("introduza el telefono");
            alum.Telefono = Console.ReadLine();

            Console.WriteLine("Introduzca su fecha de nacimiento");
            alum.fe

            alum.IdAlumno= generarId();

            Program.listaAlumno.Add(alum);  
        }

        public void baja()
        {
            


        }

        private long generarId()
        {
            int tamanioLista = Program.listaAlumno.Count();
            long nuevoId;


            if(tamanioLista > 0)
            {
                nuevoId = Program.listaAlumno[tamanioLista - 1].IdAlumno + 1;


            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }
    }
}
