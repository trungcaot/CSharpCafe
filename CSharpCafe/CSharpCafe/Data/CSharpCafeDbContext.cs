using CSharpCafe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpCafe.Data
{
    public class CSharpCafeDbContext : DbContext
    {
        public CSharpCafeDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
