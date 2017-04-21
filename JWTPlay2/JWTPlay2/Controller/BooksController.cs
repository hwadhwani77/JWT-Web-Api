using JWTPlay2.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace JWTPlay2.Controller
{
    public class BooksController : ApiController
    {

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            using (var context = new BooksContext())
            {
                return Ok(await context.Books.Include(x => x.Reviews).ToListAsync());
            }
        }
    }
}
