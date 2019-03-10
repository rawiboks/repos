using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStackOverPostEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post
                ("How to code", "I need some help with coding...");
            string read;

            do
            {
                read = Console.ReadLine();
                if (read == "up")
                    post.UpVote();
                else if (read == "down")
                    post.DownVote();
                else if (read == "result")
                    Console.WriteLine
                        ("The post raiting is: " + post.ShowRating());
            } while (read!="exit");
        }
    }
}
