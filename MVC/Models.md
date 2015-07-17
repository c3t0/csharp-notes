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
