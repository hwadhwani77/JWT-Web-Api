using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTPlay2.Core
{
    public class BookUserManager : UserManager<IdentityUser>
    {
        public BookUserManager() : base(new BookUserStore())
        {

        }
    }
}