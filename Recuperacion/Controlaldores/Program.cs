
using Recuperacion.Dtos;
using Recuperacion.Servicios;
using Recuperacion.Util;
using System.Net.NetworkInformation;

namespace Recuperacion;

class Program
{
    //creacion de lista de lso alumnos
    public static List<AlumnoDto>listaAlumno=new List<AlumnoDto>();

    //creacion la ruta del archivo
    public static string rutaCarpetaLog = "C:\\Users\\Jaime\\Desktop\\Progamacion\\Recuperacion\\Log\\";

    //concatenacion la ruta de la carpeta y nombre fichero
    public static string rutaFicheroLog = String.Concat(rutaCarpetaLog, Utilidades.crearNombrefichero());


    public static void main(String[] args){

        MenuInterfaz mi = new MenuImplementacion();
        OperativaInterfaz oi = new OperativaImplementacion();
        FicheroInterfaz fi = new FicheroImplementcion();

        bool cerrarMenu = false;
        int opcion;

        while (!cerrarMenu)
        {
            try
            {
                opcion = mi.seleccionUsuario();

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Se cierra el menu");
                        fi.escribirFicheroLog("se cierra la app");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Alta");
                        fi.escribirFicheroLog("Se dara de alta al alumno");
                        oi.alta();
                        break;
                    case 2:
                        Console.WriteLine("Baja");
                        fi.escribirFicheroLog("Se dara de baja al alumno");
                        oi.baja();
                        break;
                    case 3:
                        Console.WriteLine("Escribir fichero");
                        fi.escribirFicheroLog("Se escribe en el fichero");
                        break;

                    default:
                        fi.escribirFicheroLog("ERROR, WArning");
                        break;
                }
            }
            catch(Exception ex)
            {
                fi.escribirFicheroLog("ERROR, WArning");

            } 
            
        }
    }
}