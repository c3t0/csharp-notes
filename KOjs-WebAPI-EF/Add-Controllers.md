# Controllers

We add **Web API** controllers that support **CRUD**

* Create
* Read
* Update
* Delete

Remember you are **not** doing **SELECT** statements

Hence you will be have the following SQL equivalents

*
* 
* 

Constroller will use EF to communicate with the DB

right click "~/Controllers" > Add > Controllers

### Model class 
=> **~/Models/Authors.cs** class we just created

### Data Context class

We create a new data context

It will be have **Context** appended to the name of the service

**BookServiceV3.Models.BookServiceV3Context**

**Scaffolding** will create the controllers as shown below

##~/Controllers/AuthorsController.cs

Defines the **Web API controller**

This controller implements the **REST API**

It is used by clients to perform **CRUD** on authors

``` C#

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BookServiceV3.Models;

namespace BookServiceV3.Controllers
{
    public class AuthorsController : ApiController
    {
        private BookServiceV3Context db = new BookServiceV3Context();

        // GET: api/Authors
        public IQueryable<Author> GetAuthors()
        {
            return db.Authors;
        }

        // GET: api/Authors/5
        [ResponseType(typeof(Author))]
        public async Task<IHttpActionResult> GetAuthor(int id)
        {
            Author author = await db.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }

            return Ok(author);
        }

        // PUT: api/Authors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAuthor(int id, Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != author.Id)
            {
                return BadRequest();
            }

            db.Entry(author).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Authors
        [ResponseType(typeof(Author))]
        public async Task<IHttpActionResult> PostAuthor(Author author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Authors.Add(author);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = author.Id }, author);
        }

        // DELETE: api/Authors/5
        [ResponseType(typeof(Author))]
        public async Task<IHttpActionResult> DeleteAuthor(int id)
        {
            Author author = await db.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }

            db.Authors.Remove(author);
            await db.SaveChangesAsync();

            return Ok(author);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AuthorExists(int id)
        {
            return db.Authors.Count(e => e.Id == id) > 0;
        }
    }
}

```

## ~/Models/BookServiceContext.cs

During run time will manage the entity objects for the entire **BookServiceV3**

This is within the namespace **BookServiceV3.Models**

Populating objects with data from Database

Change Tracking

Persist data to the database

Note that it inherits from **DbContext**


```C#
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookServiceV3.Models
{
    public class BookServiceV3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BookServiceV3Context() : base("name=BookServiceV3Context")
        {
        }

        public System.Data.Entity.DbSet<BookServiceV3.Models.Author> Authors { get; set; }
    }
}

````
