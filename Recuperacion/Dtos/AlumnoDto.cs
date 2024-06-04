using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion.Dtos
{
    internal class AlumnoDto
    {



        long idAlumno;
        string nombre = "aaaaaaa";
        string apellido1 = "aaaaaaa";
        string apellido2 = "aaaaaaa";
        string direccion = "aaaaaaa";
        string email = "aaaaaaa";
        string telefono ="aaaaaaaa";
        string dni = "aaaaaaa";
        string FechaNac= "31-12-9999";
        
        public AlumnoDto() { }


        public AlumnoDto(long idAlumno, string nombre, string apellido1, string apellido2, string direccion, string email, string telefono, string FechaNac, AlumnoDto.FechaNac fechaNacimiento)
        {
            this.idAlumno = idAlumno;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono;
            this.FechaNac = fechaNacimiento;
        }

        public long IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaNac { get => FechaNac; set => FechaNac = value; }
    }
}
