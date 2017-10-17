using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vitter.Models
{
    public class VitterDB : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
    }
}