using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignStackOverPostEx
{
    class Post
    {
        private string _title { get; set; }
        private string _description { get; set; }
        private DateTime _timeCreated { get; set; }
        private int VoteRating { get; set; }

        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _timeCreated = DateTime.Now;
        }

        public void UpVote()
        {
            VoteRating++;
        }

        public void DownVote()
        {
            VoteRating--;
        }

        public int ShowRating()
        {
            return VoteRating;
        }
    }
}
