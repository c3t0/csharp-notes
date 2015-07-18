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
