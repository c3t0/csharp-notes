# Models
```C#
        public class Photo
        {
            public int PhotoID { get; set; }
            public string Title { get; set; }
            public byte[] PhotoFile { get; set; }
            public string Description { get; set; }
            public DateTime CreateDate { get; set; }
            public virtual List<Comment> Comments { get; set; } // notice the VIRTUAL
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