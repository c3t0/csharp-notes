# Views

```C#
@*Some more Razor examples*@

<span>Price including Sale Tax: @Model.Price * 1.2</span>>
<span>Price including Sale Tax: @(Model.Price * 1.2)</span>

@if (Model.Count > 5)
{
    <ol>
    @foreach(var item in Model)
    {
        <li>@item.Name</li>
    }
    </ol>>
}

```

when we add model

```C#

@model IEnumerable<MyWebsite.Models.Product> <-- this is where I list the object model-->
<h1>Product Catalog</h1>
@foreach(var Product in Model)
{
<div>Name: @Product.Name</div>
}
````


Create a Controller through scaffolding
This will also create the views

Controllers -> Add -> Rename > MVC read/write with EF -> Select the Model "Speaker" -> the Conference.Context -> enjoy

Below will display the list to Index()
```C#

   // GET: /Speaker/

        public ActionResult Index()
        {
            return View(db.Speakers.ToList());
        }
```

When the View is created through the Controller scaffolding

~/Views/Speaker folder will be created
* Create.cshtml
* Details.cshtml
* Delete.cshtml
* Edit.cshtml
* Index.cshtml


Delivering a **strongly typed** model object into the Index.cshtml view

```html
@model IEnumerable<Conference.Models.Speaker>

@{
    ViewBag.Title = "Index";
}

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(model => model.Name)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.EmailAddress)
        </th>
        <th></th>
    </tr>

@foreach (var item in Model) {
    <tr>
        <td>
            @Html.DisplayFor(modelItem => item.Name)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.EmailAddress)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", new { id=item.SpeakerID }) |
            @Html.ActionLink("Details", "Details", new { id=item.SpeakerID }) |
            @Html.ActionLink("Delete", "Delete", new { id=item.SpeakerID })
        </td>
    </tr>
}

</table
```




