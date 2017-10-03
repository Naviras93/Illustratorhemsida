using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ExamensArbete.DAL;
using ExamensArbete.Models;

namespace ExamensArbete.Controllers
{
    public class ImagesController : Controller
    {
        private GalleryContext db = new GalleryContext();

        // GET: Images
        public ActionResult Gallery(string searchString)
        {
            var images = db.Images.Include(i => i.Tag);

            if (!String.IsNullOrEmpty(searchString))
            {
                images = db.Images.Include(i => i.Tag).Where(i => i.Tag.TagName.Equals(searchString));
            }

            images = images.OrderByDescending(i => i.DateAdded);

            return View(images.ToList());
        }
    }
}
