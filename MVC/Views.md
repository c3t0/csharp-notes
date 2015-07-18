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

@model IEnumerable<MyWebsite.Models.Product>
<h1>Product Catalog</h1>
@foreach(var Product in Model)
{
<div>Name: @Product.Name</div>
}
