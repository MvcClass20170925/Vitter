using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Vitter.Models
{
    public class Video
    {
        public int VideoID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public byte[] VideoFile { get; set; }
        public string Mimetype { get; set; }

        public string Owner { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Hashtag> Hashtags { get; set; }

        public Video()
        {
            Comments = new List<Comment>();
            Hashtags = new List<Hashtag>();
        }
    }
}