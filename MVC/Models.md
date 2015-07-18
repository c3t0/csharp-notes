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
