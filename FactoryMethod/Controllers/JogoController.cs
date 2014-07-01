using Jogos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryMethod.Controllers
{
    public class JogoController : Controller
    {

        //public ActionResult Index()
        //{
        //    var jogo = new JogoDeFutebol();
        //    ViewBag.Message = jogo.Iniciar();
        //    return View();
        //}



        public ActionResult Index()
        {
            var tipoJogo = ConfigurationManager.AppSettings["TipoJogo"];
            Jogo jogo = Jogo.Create(tipoJogo);
            ViewBag.Message = jogo.Iniciar();

            return View();
        }

    }
}
