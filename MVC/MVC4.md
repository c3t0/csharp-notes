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

Notice that URL will be the name of the Controller  without the Controller part
Then will be the name of whatever methods/action you wish to take.

This will send you to the View of the same name.

The router will be searching for the View of the same name as the controller + the following directories
* ~/Views/Home
* ~/Views/Shared

and any of the following extensions
* .aspx
* .ascx
* .cshtml
* .vbhtml


ViewBag is a container
a dynamic object you can create your property on the fly
Whatever you want to send to the view you can toss in there


