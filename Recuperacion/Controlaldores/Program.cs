
using Recuperacion.Dtos;
using Recuperacion.Servicios;

namespace Recuperacion;

class Program
{

    public static List<AlumnoDto>listaAlumno=new List<AlumnoDto>();
    public static void main(String[] args){

        MenuInterfaz mi = new MenuImplementacion();
        OperativaInterfaz oi = new OperativaImplementacion();
        bool cerrarMenu = false;
        int opcion;

        while (true)
        {

            opcion = mi.seleccionUsuario();

            switch ( opcion )
            {
                case 0:
                    Console.WriteLine("Se cierra el menu");
                    break;
                case 1:
                    Console.WriteLine("Alta");
                    oi.alta();
                    break;
                case 2:
                    Console.WriteLine("Baja");
                    oi.baja();
                    break;
                case 3:


                default:
                    break;
            }
        }
    }
}