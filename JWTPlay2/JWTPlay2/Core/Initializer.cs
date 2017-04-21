using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JWTPlay2.Core
{
    public class Initializer : MigrateDatabaseToLatestVersion<BooksContext, Configuration>
    {

    }
}