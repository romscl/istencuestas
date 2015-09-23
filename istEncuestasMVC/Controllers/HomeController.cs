﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using istEncuestasMVC.Models;

namespace istEncuestasMVC.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    XMLReader readXML = new XMLReader();
        //    var data = readXML.ReturnListOfNewDataSet();
        //    return View(data.ToList());
      
        //}

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult ShowEmpresa()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ShowEmpresa(Empresa e)
        {

            servMEDAtencionProxy.servMEDAtencion  obj = new servMEDAtencionProxy.servMEDAtencion();
            var sRespuesta = obj.wsValidaEmpSiso(e.RutEmpresa);

            System.Xml.XmlDocument xDocumento = new System.Xml.XmlDocument();

           

            if (sRespuesta != null )
            {

                xDocumento.LoadXml(sRespuesta);

                //var xmlData = xDocumento.SelectSingleNode("//Data");
                
                XMLReader readXML = new XMLReader();
                var data = readXML.ReturnListOfEmpresa(xDocumento);

                if (data[0].Codigo == 1)
                {
                    return RedirectToAction("Index", "Encuesta");
                }

                //return View(data.ToList());
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I like games.";

            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Hola que tal!!!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}