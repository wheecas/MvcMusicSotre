using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class AlbumEditViewModel
    {
        public Album AlbumToEdit { get; set; }

        public SelectList Genres { get; set; }

        public SelectList Artists { get; set; }
    }
}