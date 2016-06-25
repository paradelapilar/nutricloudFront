using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nutricloud_web.Models;

namespace nutricloud_web.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn([Bind(Include = "Email,Password")] LogInViewModel model)
        {
            // logica de negocios
            return RedirectToAction("Home","Home");
        }

        [HttpPost]
        public ActionResult SignIn([Bind(Include = "Email,Password1,Password2,TipoUsuario")] SignInViewModel model)
        {
            // logica de negocios
            return null;
        }

    }
}