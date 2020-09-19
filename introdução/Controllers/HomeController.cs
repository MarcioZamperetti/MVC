using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoASPNET_VazioComCRUD_EF6.Models;
using CRUD_EF.Models;
using introdução.Models;

namespace introdução.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Extjs()
        {
            return View();
        }       
        
    }
}
