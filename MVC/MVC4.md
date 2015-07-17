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
            return View(); // the view returned
        }

    }
}
```
