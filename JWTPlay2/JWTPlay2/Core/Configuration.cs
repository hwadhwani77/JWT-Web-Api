using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity.Migrations;

namespace JWTPlay2.Core
{
    public class Configuration : DbMigrationsConfiguration<BooksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }
    }
}