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



