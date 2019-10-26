using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCafeApp.Domain.Models
{
    public class Category
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string UrlSlug { get; set; }

        public virtual string Description { get; set; }

        public virtual IList<Post> Posts { get; set; }

    }
}
