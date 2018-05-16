using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    /// <summary>
    /// 艺术家
    /// </summary>
    public class Artist
    {
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
    }
}