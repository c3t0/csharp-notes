```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; // Web and MVC namespaces

namespace MvcApplication2.Controllers //notice the dot Constrollers
{
    public class HomeController : Controller // inherits from controller
    {
        //
        // GET: /Home/

        public ActionResult Index() //Method that invokes class index
        {
            return View(); // Right click to add View
        }

    }
}
```

Adding view opens *Index.cshtml*

```C#
@{
    ViewBag.Title = "Index"; //ViewBag class?
}

<h2>Index</h2>
```
