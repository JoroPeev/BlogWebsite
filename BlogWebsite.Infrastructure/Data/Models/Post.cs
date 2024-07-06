using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebsite.Infrastructure.Data.Models
{
    public class Post
    {
        public string Article { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
