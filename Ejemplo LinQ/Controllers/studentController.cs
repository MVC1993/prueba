using Ejemplo_LinQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo_LinQ.Controllers
{
    public class studentController : Controller
    {
        alumnos db = new alumnos();
        // GET: student
        public ActionResult Index()
        {
            var Listado = db.Lista();
            
            return View(Listado.ToList());
        }
        [HttpPost]
        public ActionResult Index(string Busqueda, string Opc)
        {

            var Listado0 = (from n in db.Lista()
                            select n);

            switch (Opc)
            {
                case "Materia":

                    var Listado = (from n in db.Lista()
                                   where n.Materia.ToUpper().Contains(Busqueda.ToUpper())
                                   select n);
                    return View(Listado);
                case "Nombre":
                    var Listado1 = (from n in db.Lista()
                                    where n.Nombre.ToUpper().Contains(Busqueda.ToUpper())
                                    select n);
                    return View(Listado1);
                case "Promedio":
                    var Listado2 = (from n in db.Lista()
                                    where n.Promedio.ToString().ToUpper().Contains(Busqueda.ToUpper())
                                    select n);
                    return View(Listado2);
            }

            return View(Listado0);
        }

            [HttpPost]
            public ActionResult index (string txtbuscar, string select)
            {

            var listado = db.Lista();
            string formato = txtbuscar.Trim();
            var query = from a in   db.Lista() select a;
            
            if(select == "1")
            {
                query = from n in db.Lista() where n.Nombre.Contains(formato) select n;
            }

            if (select == "2")
            {
                query = from n in db.Lista() where n.Materia.Contains(formato) select n;
            }

            if (select == "3")
            {
                double prom = Convert.ToDouble(formato);
                query = from n in db.Lista() where n.Promedio == prom select n;
            }

            return View(query.ToList());

        }
        








    }
    }
