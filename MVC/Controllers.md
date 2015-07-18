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


## Passing data to View
http://rachelappel.com/when-to-use-viewbag-viewdata-or-tempdata-in-asp.net-mvc-3-applications
1. **Model** ViewData
2. **ViewBag**
3. **TempData**

* Model -> View("data")
    - strongly typed
    - more complex
* ViewBag is dynamic and only for that action.
    - Alias for view data
    - perfect for sending messages to the view
* TempData also available on the next page


```C#
using Conference.Models; // this is the models namespace for your project Conference
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class SessionController : Controller
    {
        //
        // GET: /Session/

        public ActionResult Index() //Index is the name of the acction
            // also the name of the View that return will be looking for if no View is specified
        {
            ConferenceContext context = new ConferenceContext();
            List<Session> sessions = context.Sessions.ToList();

            return View("Index", sessions);
        }

    }
}

```


## Forms in MVC

1. One action to give you the form that will be an object
2. Another action to take the info and process it behind the scenes to the db
3. 

```C#
 // a web form needs two steps
        // 1) send the form in a View
        // 2) received the filled form and process it

        //Step 1 of Form

        [HttpPost()] //GET: Session/Create -- not sure this is needed since signatures are different.
        public ActionResult Create() // a form in a View called create for you to fill
        {
            return View() // nothing here because I only want to make sure that we return the form
                // empty will return a View called "Create" with the form in it.
        }

        //Step 2 of Form

        [HttpPost()] //POST: Session/Create  -- not sure this is needed since signatures are different
        public ActionResult Create(Session session) //this will have a brand new session.
            // (Session session) this is model binding
        {
            // we add this at the end
            // the "if" statment is to validate data
            if (!ModelState.IsValid) // look for .IsValid on MSDN website
            {
                return View(session); // since not-valid then return the "session" that contains the bad data
            }
            ConferenceContext context = new ConferenceContext(); //we create a new object of tyep ConferenceContext
            //ConferenceContext has to objects Sessions + Speakers
            //Sessions AND speakers have several Properties
            //e.g. [SessionID, Title, Abstract, SpeakerID, Speaker]

            context.Sessions.Add(session); //we only receive one parameter "session"
            //session object is what we add

            context.SaveChanges(); // important

            //we add this so that the user receives some sort of message acknowledging the action taken
            TempData["Message"] = "Created " + session.Title;


            // we need to return a View
            // could be "Index" or maybe someother view different than "Create"

            return RedirectToAction("Index"); // this takes you back to the full list
        
            // but we get no notification so we use TempData above the return statement
        }

        // so an action of the same name will perform differently
        //this is an overloaded method
        //If no parameters then return empty form
        //if parameters are sent aka you have session object filled with form info
        // then process parameter to database

```

## TRY & CATCH

For the FORM

## Filters

Allow us to change the behavior of the action.

* Authorization
* Logging
* Caching

Four types

1. Authorization
2. Action
3. Result
4. Exception

Based on route and it will change

unsurprisingly they are **attributes** to the class or the action method

```C#
[Authorize(Roles = "Administrators")]
````
Global setting are configured in 
###~/App_Start/FilerConfig.cs

```C#
using System.Web;
using System.Web.Mvc;

namespace Conference
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
```

That filer is living in the **~/Filters** directory

e/g require SSL in the entire website

```C#
            filters.Add(new RequireHttpsAttribute());

```
