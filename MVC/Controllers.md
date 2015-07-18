# Controllers

**MVCHandler** -> calls **Execute()** method
Controller factory -> create **Controller** object

**ControllerActionInvoker** determines values to be passed to action as paratmeters
a.k.a **Model Binder** [[Models.md]]

**ControllerActionInvoker** returns action

When the user navigates to a URL it is actually calling the **ControllerActionInvoker**

Which is used on a method on an action.

This means that users are calling methods on our controller

So we need a mechanism to create an instance of that **controller** and go find the appropriate **method**?? (or did he mean Model?)


## Action for a Controller

Writing an action for a Controller includes
* Create **public method**
* Return a class that derives from **ActionResult** method
* Add **parameters** to the method
* insert code to perform operation and **return** the result

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "I want some spaghetti!";
            ViewBag.Spaghetti = 5;
            return View();
        }

        public ActionResult Spaghetti()
        {
            return View();
        }


    }
}

```
### Create **public method**

```C#
public class HomeController : Controller
```

### Return a class that derives from **ActionResult**

### Add **parameters** to the method

using parameters

```C#

http://www.advendureworks.com/session/getsessionbytitle?title=MVC101
// default model binder ?title=MVC101

//below we are returning ActionResult
//labeled "public"
//Our method name is "GetSessionByTitle
//The parameter here is (string title)

        public ActionResult GetSessionByTitle(string title)
        //down blew we are doing "stuff"
        {
            var query = from s in context.Sessions
                        where s.Title == title
                        select s
                Photo session = query.FirstOrDefault();
                return View("Details", session); // This is the helper methods return View
                // it fetches the View that matches the method name "GetSessonByTitle"
                //in this case we specified the View named "Details"
                //The second parameter is the object that we loaded "session"
                //the object "session" is what is passed to the View called "Details"
        }



``` 


### insert code to perform operation and **return** the result


### Repository
When implementing a repository for production 

GetseSessionByTitle would be retrieve by ID from repo
