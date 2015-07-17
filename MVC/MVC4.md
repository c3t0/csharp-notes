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

**App_Start** folder has **Routing**

Look for the files RouteConfig.cs with the following contents

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",  // controller action ID if there is no ID
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                // if no controller default is HOME if no action default is INDEX
            );
        }
    }
}
```

Go to HomeController.cs
type mvcaction4 tab tab

```C#

public ActionResult Action()
        {
            return View();
        }
        
```
        


