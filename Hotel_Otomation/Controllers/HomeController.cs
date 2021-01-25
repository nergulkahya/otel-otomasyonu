using Hotel_Otomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Otomation.Controllers
{
    public class HomeController : Controller
    {
        private Hotel_2019_DbEntities db = new Hotel_2019_DbEntities();
        public ActionResult Index()
        {
            List<Rooms> rooms = db.Rooms.ToList();
            return View(rooms);
        }
      
        public ActionResult About()
        {
            List<Abouts> abouts = db.Abouts.ToList();
            return View(abouts);
        }

        public ActionResult Rooms()
        {
            List<Rooms> rooms = db.Rooms.ToList();
            return View(rooms);
        }
        public ActionResult Gallery()
        {
            List<Galleries> galleries = db.Galleries.ToList();
            return View(galleries);
        }
       
        public ActionResult Contact()
        {
            return View();
        }
    }
}