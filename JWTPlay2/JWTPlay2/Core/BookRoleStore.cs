using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTPlay2.Core
{
    public class BookRoleStore : RoleStore<IdentityRole>
    {
        public BookRoleStore() : base(new BooksContext())
        {

        }
    }
}