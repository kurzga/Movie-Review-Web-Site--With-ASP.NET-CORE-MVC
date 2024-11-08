using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmSitesi.Controllers
{
    public class GenreController : Controller
    {
        // GET: Genre
        public ActionResult Genres()
        {
            return View();
        }
        public ActionResult Horror()
        {
            return View();
        }
        public ActionResult Comedy()
        {
            return View();
        }
    }
}