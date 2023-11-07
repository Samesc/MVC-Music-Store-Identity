using MVC_Music_Store_Identity.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC_Music_Store_Identity.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        // GET: Store
        public ActionResult Index()
        {
            try
            {
                var genres = storeDB.Genres.ToList();
                return View(genres);
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Store/Details/5
        public ActionResult Browse(string genre)
        {
            try
            {

                var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);
                return View(genreModel);
            }
            catch
            {
                return View("Error");
            }
        }
        // GET: Store/Details/id
        public ActionResult Details(int id)
        {
            try
            {
                var album = storeDB.Albums.Find(id);
                return View(album);
            }
            catch
            {
                return View("Error");
            }
        }

        //
        // GET: /Store/GenreMenu

        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            try
            {
                var genres = storeDB.Genres.ToList();
                return PartialView(genres);
            }
            catch
            {
                return View("Error");
            }
        }
    }
}