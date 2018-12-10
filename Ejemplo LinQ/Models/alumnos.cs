using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_LinQ.Models
{
    public class alumnos
    {
        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double Promedio { get; set; }
        public DateTime Fecha { get; set; }


        public List<alumnos> Lista()
        {
            var estudiante1 = new alumnos()
            {
                Carnet = 7845,
                Nombre= "Humberto",
                Materia="Matematica",
                Promedio= 7.8,
                Fecha=DateTime.Now

            };
            var estudiante2 = new alumnos()
            {
                Carnet = 9901,
                Nombre = "Roberto",
                Materia = "Fisica I",
                Promedio = 7.6,
                Fecha = DateTime.Now

            };
            var estudiante3 = new alumnos()
            {
                Carnet = 8745,
                Nombre = "Marta",
                Materia = "Quimica",
                Promedio = 8.9,
                Fecha = DateTime.Now

            };
            var estudiante4 = new alumnos()
            {
                Carnet = 1024,
                Nombre = "Maria",
                Materia = "Cálculo",
                Promedio = 6.8,
                Fecha = DateTime.Now

            };
            var estudiante5 = new alumnos()
            {
                Carnet = 1041,
                Nombre = "Marcos",
                Materia = "Fisica II",
                Promedio = 5.8,
                Fecha = DateTime.Now

            };
            return new List<alumnos>() {estudiante1,estudiante2,estudiante3,estudiante4,estudiante5 };
        }
    }

}