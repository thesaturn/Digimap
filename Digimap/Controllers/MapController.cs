using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Digimap.Models;
using Microsoft.Ajax.Utilities;

namespace Digimap.Controllers
{
    public class MapController : Controller
    {
        // GET: Map

        public ActionResult Lista(int Busqueda=0)
        {
            DigimapEntitiesFinal db = new DigimapEntitiesFinal();
            Sala sala = new Sala();
            sala.nro_Sala = Busqueda;

            List<Sala> lista = db.Salas.Where(a => a.nro_Sala == Busqueda).ToList();

            return View(lista);
        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Interes(string Busqueda)
        {
            DigimapEntitiesFinal db = new DigimapEntitiesFinal();
            PtoIntere pin = new PtoIntere();
            pin.nom_Punto = Busqueda;
            List<PtoIntere> lista = db.PtoInteres.Where(a => a.nom_Punto == Busqueda).ToList();

            return View(lista);
        }

        public ActionResult PisoMenosUno()
        {
            return View();
        }

        public ActionResult PisoUno()
        {
            return View();
        }

        public ActionResult PisoDos()
        {
            return View();
        }

        public ActionResult PisoTres()
        {
            return View();
        }

        public ActionResult PisoCuatro()
        {
            return View();
        }

        public ActionResult PisoCinco()
        {
            return View();
        }

        public ActionResult PisoSeis()
        {
            return View();
        }

        public ActionResult PisoSiete()
        {
            return View();
        }

        public ActionResult PisoOcho()
        {
            return View();
        }


    }
}