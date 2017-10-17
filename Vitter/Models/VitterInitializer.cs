using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Vitter.Models
{
    public class VitterInitializer 
        : DropCreateDatabaseAlways<VitterDB>
    {
        protected override void Seed(VitterDB context)
        {
            var videos = new List<Video>
            {
                new Video()
                {
                    Title = "My First Video",
                    Description = "Video test first video",
                    Owner = "TestUser"
                },
                new Video()
                {
                    Title = "My Second Video",
                    Description = "Video test second video",
                    Owner = "TestUser"
                }
            };

            var hashtags = new List<Hashtag>
            {
                new Hashtag()
                {
                    Name = "Test video"
                },
                new Hashtag()
                {
                    Name = "Test video2"
                }

            };

            videos[0].Hashtags.Add(hashtags[0]);
            videos[1].Hashtags.Add(hashtags[0]);
            videos[1].Hashtags.Add(hashtags[1]);

            videos.ForEach(v => context.Videos.Add(v));
            context.SaveChanges();

            var comments = new List<Comment>
            {
                new Comment()
                {
                    Subject = "This video sucks",
                    Body = "It realy sucks bad.",
                    VideoID = 1
                }
            };

            comments.ForEach(c => context.Comments.Add(c));
            context.SaveChanges();
        }
    }
}