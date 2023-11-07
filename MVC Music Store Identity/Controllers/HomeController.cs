using MVC_Music_Store_Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Music_Store_Identity.Controllers
{
    public class HomeController : Controller
    {

        MusicStoreEntities storeDB = new MusicStoreEntities();
        public ActionResult Index()
        {
            try
            {

                var albums = GetTopSellingAlbums(6);
                return View(albums);
            }
            catch
            {

                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private List<Album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count

            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}