Add **model classes** that define the **database entities**.

Then you will add **Web API controllers** that perform **CRUD** operations on those **entities**.

#Models


create Plain Old Common Language Runtime Objects **POCOS**

aka **Classes**

Right click ~/Models > Add > Class > Class.cs > enter name

This will create **Author.cs** under **~/Models**

Note the **using** statements

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookServiceV3.Models
{
    public class Author
    {
    }
}
```

When you add the attribute **[Required]** VS will suggest you add 
**using Sytem.ComponentModel.DataAnnotations;**

```C#
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookServiceV3.Models
{
    public class Author
    {
        public int Id
        {
            get;
            set;
        }
        [Required]
        public string Name
        {
            get;
            set;
        }
    }
}

```


Notice that the Model class you will have an class for the entity **Author**

The attributes of the entity in a DB are **Id** and **Name**

**Id** and **Name** are declared as **properties**

The property attribute **[Required]** will help the controller know that the view needs to reflect that.



## Navigation Properties
 Navigation properties allow you to define relationships between entities (rows in your database) in a way that makes sense in an object oriented language.
```C#
public class User
    {
        public string Name { get; set; }
    }

    public class Post
    {
        public User Author { get; set; }
    }
```
Which means we can use it in code like this:
```C#
    String.Format("{0} wrote this post", post.Author.Name);
```
What Entity Framework navigation proprieties do is to allow us to do just this with our database models. For example the above database structure could be represented as:

```C#
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public User Author { get; set; }
    } 
```
So how do Navigation Properties work?

When you are using navigation properties in your code you are asking **Entity Framework to automatically perform a SQL join** between your two tables. For example:

```C#
    context.Posts.Where(p => p.Author.Name == "Luke");

```
will be translated into the following SQL*:

```SQL
    SELECT
      p.Id,
      p.Author_Id
    FROM  Posts AS p
      INNER JOIN Users AS u ON p.Author_Id = u.Id
    WHERE u.Name = N'Luke'
```

As you can see our relationship in c# has been converted into the equivalent SQL join.
