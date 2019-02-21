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
                var records = csv.GetRecords<SongModel>();
                var songRecords = new SongRecord
                {
                    SongRecords = records.ToList()
                };


                // 1) parse file - Done
                // 2) build model - Done
                // 3) pass model to view -    return View(model) - Done ;

                return View(songRecords);
            }
        }
    }
}