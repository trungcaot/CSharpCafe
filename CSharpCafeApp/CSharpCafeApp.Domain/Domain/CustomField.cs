using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCafeApp.Domain.Domain
{
    public class CustomField
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }
    }
}
