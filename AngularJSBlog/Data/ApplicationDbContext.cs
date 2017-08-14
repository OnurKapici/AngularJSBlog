using AngularJSBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularJSBlog.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("name=ApplicationDbConnectionString")
        {
            
        }

        public DbSet<Post> Posts { get; set; }

    }
}