using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vitter.Models
{
    public class Comment
    {
        public int CommentID { get; set; }

        public string Subject { get; set; }
        public string Body { get; set; }

        public string UserName { get; set; }

        public int VideoID { get; set; }

        public virtual Video Video { get; set; }
    }
}