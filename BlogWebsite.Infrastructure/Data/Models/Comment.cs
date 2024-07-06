using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebsite.Infrastructure.Data.Models
{
    public class Comment
    {
        public string Author { get; set; }

        public string Content { get; set; }

        public DateTime PublishedDate { get; set; }



    }
}
