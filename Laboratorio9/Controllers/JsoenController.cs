using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio9.Models;

namespace Laboratorio9.Controllers
{
    public class JsoenController : Controller
    {
        // GET: Jsoen
        public ActionResult Index()
        {

            
            return View();
        }

        public JsonResult ObtenerClientes()
        {

            List<Cliente> lst;
            using (ClientesEntities db = new ClientesEntities())
            {
                lst = (from d in db.Clientes
                       select d).ToList();


            }

            return Json(lst, JsonRequestBehavior.AllowGet);
        }

    }
}