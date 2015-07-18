# Models
```C#
        public class Photo
        {
            public int PhotoID { get; set; }
            public string Title { get; set; }
            public byte[] PhotoFile { get; set; }
            public string Description { get; set; }
            public DateTime CreateDate { get; set; }
            public virtual List<Comment> Comments { get; set; } // notice the VIRTUAL  = lazy Loading
            // This is a relationship to a 0..* Comments
        }

```

Model should provide metadata so that it is centralized.

This is performed through attributes 

```C# 

        public class Photo
        {
            [DisplayName("Picture")]
            public byte[] PhotoFile { get; set; }

            [DataType(DataType.DateTime)]
            [DisplayName("Create Date")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
            public DateTime CreateDate { get; set; }
        }

}

       public class Person
       {
           public int PersonID { get; set; }

           [Required(ErrorMessage = "Pleae enter a name.")]
           public string Name { get; set; }

           [Range(0, 400)]
           public int Height { get; set; }

           [Required]
           [DataType(DataType.EmailAddress)]
           public string EmailAddress { get; set; }
       }

`````

Google *datatype emailaddress msdn*

This will take you to the library documentation

Rooute data 
Query string
Inside the filled form

Model Binders are the ones that connect data

I do not have to connect the fields

MVC Model Binders will provide dump that data into parameters that match my class

parameter enter

remember to enter
*using System.ComponentModel.DataAnnotations;*
```C# 

Add class

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Session
    {
        public Int32 SessionID { get; set; }

        public String Title { get; set; }

        public String Abstract { get; set; }

        public Int32 SpeakerID { get; set; }

        public Speaker // create the class with Control + " . "

    }
}

```

Why Dispaly as attribute instead of typing it into the view

Validation 
It lives with the model instead of harcoding it into the site


## Metadata for Patial Class

if the class was generated from SQL then you would have a partial class

You can create a separate class for metadata specifying the name of each object with the attributes above it.

Then reference as MetadataType on top of the partial class as pass the name of you metadata class.

Also called a **buddy class**
```C#

    [MetadataType(typeof(SpeakerMetadata))]
    public partial class Speaker
    {

    }

    public class SpeakerMetadata
    {
        [Required()]
        public Object Name { get; set; }
    }

```

Now review the second class that was generated with control + . then added parameters

```C#

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Conference.Models
{
    public class Speaker // remember to add "public"
    {
        public Int32 SpeakerID { get; set; }

        [Required(ErrorMessage = "{0} is required")] // the {0} will display the value of Name
        [Display(Name = "Speaker")]
        public String Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }

        public virtual List<Session> Sessions { get; set; } // VIRUTAL = lazy Loading
    }


}

```

## Entity Framework

ID or ClassID are used as the primary key
Virtual = Lazy loading

## Context Initializer

```C#
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class ConferenceContextinitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context) // this Seed(...) was autocompleted by VS also adding below
        {
            base.Seed(context); // <= this was added by Visual Studio. after the above Seed method
            //This line however was not included in the final file in the course.
        }
    }
}
````
Here Seed(ConferenceContext context) is the context that should be overridden with data

Below you find the context initializer that will provide the Seed methods.

Notice that this was called **~/Migrations/Configuration.Seed** in the 
Knockout tutorial
http://www.asp.net/web-api/overview/data/using-web-api-with-entity-framework/part-3

```c#
// from tutorial
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class ConferenceContextinitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            context.Sessions.Add(
                new Session()
                {
                    Title = "I want Spaghetti",
                    Abstract = "The life and time of a spaghetti lover",
                    Speaker = context.Speakers.Add(
                                new Speaker()
                                {
                                    Name = "Jon Galloway",
                                    EmailAddress = "jon@nowhere.com"
                                })

                });
            context.SaveChanges();
            //base.Seed(context); // this was autogenerated by VS but no included according to the tutorial
        }
        
    }
}
`````
Then you open **Global.asax.cs** which seems equivalent to the ~/Migrations/Configuration.Seed in the KO.js tutorial

making sure you add the proper using statements

```C#

using Conference.Models; // To add the Model for the Conference
using System;
using System.Collections.Generic;
using System.Data.Entity; // control + dot
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Conference
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<ConferenceContext>(new ConferenceContextinitializer());
            
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }
}

```
MVC4 course mentions the use of a repositor when in production.

Dunno exactly what they mean right now.

Model is supposed to take care of the queries



````C#
////// vis-a-vis Knockout tutorial
// add the line below to the Configuration.cs
using BookService.Models;
// Then in Migrations/Configuration.Seed add below
// note that ~/Migrations is not listed in the MVA tutorial for MVC web app

protected override void Seed(BookService.Models.BookServiceContext context)
{
    context.Authors.AddOrUpdate(x => x.Id,
        new Author() { Id = 1, Name = "Jane Austen" },
        new Author() { Id = 2, Name = "Charles Dickens" },
        new Author() { Id = 3, Name = "Miguel de Cervantes" }
        );

    context.Books.AddOrUpdate(x => x.Id,
        new Book() { Id = 1, Title = "Pride and Prejudice", Year = 1813, AuthorId = 1, 
            Price = 9.99M, Genre = "Comedy of manners" },
        new Book() { Id = 2, Title = "Northanger Abbey", Year = 1817, AuthorId = 1, 
            Price = 12.95M, Genre = "Gothic parody" },
        new Book() { Id = 3, Title = "David Copperfield", Year = 1850, AuthorId = 2, 
            Price = 15, Genre = "Bildungsroman" },
        new Book() { Id = 4, Title = "Don Quixote", Year = 1617, AuthorId = 3, 
            Price = 8.95M, Genre = "Picaresque" }
        );
}
```

