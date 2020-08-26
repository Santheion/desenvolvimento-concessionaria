using Concessionaria.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concessionaria.Web.Controllers
{
    public class CarroController : Controller
    {
        // GET: Carro
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(DadosCarro dadosCarro)
        {
            return View("RegistroCarro", dadosCarro);
        }
    }
}