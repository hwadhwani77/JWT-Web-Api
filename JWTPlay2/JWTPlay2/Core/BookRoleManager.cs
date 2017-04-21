using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWTPlay2.Core
{
    public class BookRoleManager : RoleManager<IdentityRole>
    {
        public BookRoleManager() : base(new BookRoleStore())
        {

        }
    }
}