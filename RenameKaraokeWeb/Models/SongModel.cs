
using System.Collections.Generic;

namespace RenameKaraokeWeb.Models
{
    public class SongModel
    {
        public string ID { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
    }

    public class SongRecord
    {
        public List<SongModel> SongRecords { get; set; }
    }
}