#pragma checksum "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/NewCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e7b38fd30342040e4e5f4401d1d5ea78998c20e"
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
    public partial class NewCity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "bg-info text-white");
            __builder.AddContent(2, 
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/NewCity.razor"
                                City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "panel-body");
            __builder.AddContent(6, 
#nullable restore
#line 2 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/NewCity.razor"
                         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/NewCity.razor"
       
    [Parameter]
    public string City { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
