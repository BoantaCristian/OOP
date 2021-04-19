using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }

        public Post(string Title, string Description)
        {
            this.Title = Title;
            this.Description = Description;
            this.Date = DateTime.UtcNow;
            this.Rating = 0;
        }

        public void UpVote()
        {
            Rating++;
        }
        public void DownVote()
        {
            Rating--;
        }
    }
}
