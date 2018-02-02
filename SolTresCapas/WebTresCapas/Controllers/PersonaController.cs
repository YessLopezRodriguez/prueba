using FTG.TresCapas.Business;
using FTG.TresCapas.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTresCapas.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            try
            {
                BusinessPersona busP = new BusinessPersona();
                List<EntPersona> mod = busP.Mostrar();
                return View(mod);
            }
            catch (Exception ex)
            {
                TempData["ERROR_MOSTRAR"] = ex.Message;
                List<EntPersona> mod = new List<EntPersona>();
                return View(mod);
            }

        }

        public ActionResult CrearGET()
        {
            return View();
        }

        public ActionResult CrearPOST(EntPersona p)
        {
            BusinessPersona busP = new BusinessPersona();
            busP.Crear(p);
            return RedirectToAction("Index");
        }
    }
}