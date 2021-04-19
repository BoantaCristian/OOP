using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("First post", "Description of the post");

            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DownVote();

            Console.WriteLine("Title: " + post.Title);
            Console.WriteLine("Description: " + post.Description);
            Console.WriteLine("Date: " + post.Date);
            Console.WriteLine("Rating: " + post.Rating);

            Console.Read();
        }
    }
}
