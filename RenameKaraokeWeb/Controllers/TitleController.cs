using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenameKaraokeWeb.Controllers
{
    public class TitleController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Table(HttpPostedFileBase songList)
        {
            // 1) parse file
            // 2) build model
            // 3) pass model to view -    return View(model);

            return View();
        }
    }
}