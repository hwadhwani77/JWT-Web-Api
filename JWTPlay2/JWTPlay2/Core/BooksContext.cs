using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using JWTPlay2.Models;

namespace JWTPlay2.Core
{
    public class BooksContext : IdentityDbContext
    {
        public BooksContext() : base("BooksContext")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}