using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Catalogo.Domain.Entities;
using Catalogo.DataAccess;

namespace Catalogo.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}