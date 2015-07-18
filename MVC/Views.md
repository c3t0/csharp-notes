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
