using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class ContactController : Controller
    {
        Context ctx = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(iletisim model)
        {
            ctx.iletisims.Add(model);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}