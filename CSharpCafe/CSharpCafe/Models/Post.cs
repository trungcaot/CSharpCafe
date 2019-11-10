using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpCafe.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime PublishedDate { get; set; }

        public decimal Rateing { get; set; }
        public int PostViews { get; set; }

        public string Slug { get; set; }
    }
}
