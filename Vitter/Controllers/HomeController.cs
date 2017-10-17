using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vitter.Models;

namespace Vitter.Controllers
{
    public class HomeController : Controller
    {
        private VitterDB _context = new VitterDB();

        // GET: Home
        public ActionResult Index()
        {
            var videos = _context.Videos.ToList();

            return View( "Index", videos );
        }

        [ActionName("Hashtag")]
        public ActionResult FindByHashtag(string Hashtag)
        {
            var hashtag = (from v in _context.Hashtags
                           where v.Name == Hashtag
                           select v ).FirstOrDefault();

            if( hashtag == null )
            {
                return HttpNotFound();
            }



            return View("FindByHashtag", hashtag.Videos.ToList()  );
        }
    }
}