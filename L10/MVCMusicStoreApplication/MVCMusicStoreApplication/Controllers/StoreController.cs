using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: Store
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var albums = db.Albums.Where(a => a.GenreId == id);
            if (albums == null)
            {
                return HttpNotFound();
            }
            return View(albums.ToList());
        }

        public ActionResult Browse()
        {
            try
            {
                var genres = db.Genres.OrderBy(g => g.Name);
                return View(genres.ToList());
            }
            catch (Exception ex)
            {
                return View(ex.ToString());
            }
        }
  
        public ActionResult Details(int? id)
        {
            return View();
        }
    }
}