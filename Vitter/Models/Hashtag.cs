using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vitter.Models
{
    public class Hashtag
    {
        public int HashtagID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Video> Videos { get; set; }

        public Hashtag()
        {
            Videos = new List<Video>();
        }
    }
}