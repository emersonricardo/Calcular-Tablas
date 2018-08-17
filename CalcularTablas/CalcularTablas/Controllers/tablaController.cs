using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcularTablas.Controllers
{
    public class TablaController : Controller
    {
        // GET: Index
        public ActionResult Tabla()
        {
            ViewBag.datos = false;
            return View();
        }

        [HttpPost]
        public ActionResult Tabla(int txttabla)
        {
            ViewBag.datos = true;
            ViewBag.tabla = txttabla;
            
            return View();
        }
    }
}