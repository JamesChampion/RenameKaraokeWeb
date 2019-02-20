using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CsvHelper;
using RenameKaraokeWeb.Models;

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
            using (var reader = new StreamReader(songList.InputStream))
                using (var csv = new CsvReader(reader))
            {
                csv.Configuration.Delimiter = " - ";
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.MissingFieldFound = null;
                var records = csv.GetRecords<SongRecord>();
                foreach(SongRecord record in records)
                {

                    Console.WriteLine(record.ID + " " + record.Artist + " " + record.Title);
                }


            }




                // 1) parse file
                // 2) build model
                // 3) pass model to view -    return View(model);

                return View();
        }
    }
}