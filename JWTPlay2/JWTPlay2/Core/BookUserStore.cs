using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTPlay2.Core
{
    public class BookUserStore : UserStore<IdentityUser>
    {
        public BookUserStore() : base (new BooksContext())
        {

        }
    }
}