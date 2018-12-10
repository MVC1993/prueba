using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo_LinQ.Controllers
{
    public class LinQController : Controller
    {
        // GET: LinQ
        public ActionResult Index()
        {
            int[] numero = { 2, 5, -9, -7, 3, 4, 96, -78, -85,55, 43,4, -78, -56, 96,85, 74, -9, 85, -98,85 };

            //Numeros Iguales
            var query1 = from n in numero
                         where n == 85
                         select n;
            ViewBag.dato = query1;

            //Numeros pares
                List<int> numQuery2 =
                (from n in numero
                where (n % 2) == 0
                select n).ToList();

                ViewBag.dato2 = numQuery2;

            //Mayor que
            var query3 =
              from n in numero
              where n > 5 && n < 60
              select n;

            ViewBag.dato3 = query3;

            //ordenar de mayor a menor
            var query4 = from n in numero
                         orderby n descending
                         select n;

            ViewBag.dato4 = query4;
            //ordenar de menor a mayor
            var query5 = from n in numero
                         orderby n
                         select n;

            ViewBag.dato5 = query5;


            return View();
        }

        public ActionResult lista()
        {
            List<string> materias = new List<string>()
            {
                "Matematicas", "algoritmia","Mvc basico","historia de internet", "linq","use tools"
            };
            //Empiezan con la letra x
            var query = from n in materias
                        where n.StartsWith("M")
                        select n;
            ViewBag.dato = query;

            //Terminan con la letra x
            var query2 = from n in materias
                        where n.EndsWith("a")
                        select n;
            ViewBag.dato1 = query2;

            //
            var query3 = from n in materias
                         where n.Contains("a")
                         select n;
            ViewBag.dato2 = query3;





            return View(query2.ToList());
        }

    }
}