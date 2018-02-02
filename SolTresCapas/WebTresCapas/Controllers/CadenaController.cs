using FTG.TresCapas.Business;
using FTG.TresCapas.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTresCapas.Controllers
{
    public class CadenaController : Controller
    {
        // GET: Cadena
        public ActionResult Index()
        {
            BusCadena bus = new BusCadena();
            List<EntCadena> mod = bus.Mostrar();

            return View(mod);
        }

        public ActionResult InsertarCadenasPOST(EntCadena c)
        {
            BusCadena bus = new BusCadena();
            bus.InsertaCadenas(c.Cadena);
            return RedirectToAction("Index");
        }
    }
}