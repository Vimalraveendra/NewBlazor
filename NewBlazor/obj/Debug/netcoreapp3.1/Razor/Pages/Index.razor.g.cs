#pragma checksum "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5e1e69a8e8ff1911dae0c75ef0db8db4d1a7b69"
// <auto-generated/>
#pragma warning disable 1591
namespace NewBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using NewBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/_Imports.razor"
using NewBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/Index.razor"
     headingText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\n ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "Counter:");
            __builder.AddContent(5, 
#nullable restore
#line 6 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/Index.razor"
             count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/Index.razor"
                                          Increment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Click me!");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n\n");
            __builder.AddMarkupContent(12, "<h3 class=\"bg-info text-white\">Select Your City</h3>\n\n");
            __builder.OpenComponent<NewBlazor.Pages.SelectCity>(13);
            __builder.AddAttribute(14, "MyCity", "Warsaw");
            __builder.AddAttribute(15, "MyBackground", "bg-warning");
            __builder.AddAttribute(16, "myCustomEvent", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 12 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/Index.razor"
                                                                      HandleCustom

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "Weather", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(18, "Moderate and Humid");
            }
            ));
            __builder.AddAttribute(19, "Elevation", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(20, "14m");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\n");
            __builder.OpenElement(22, "label");
            __builder.AddContent(23, 
#nullable restore
#line 17 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/Index.razor"
        SelectedCity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n\n");
            __builder.OpenComponent<NewBlazor.Pages.NewCity>(25);
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(27, " Commercial Capital of London");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/Index.razor"
      

    private string headingText = "Welcome to Blazor";
    private int count = 0;

    public void Increment()
    {
        count++;
    }

    public string SelectedCity;
    public void HandleCustom(string newValue)
    {
        SelectedCity = newValue;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
