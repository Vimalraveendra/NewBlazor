#pragma checksum "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e357d81c483a26cd5fa290fa711feee999de24c"
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
    public partial class SelectCity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group" + " p-2" + " " + (
#nullable restore
#line 1 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
                            MyBackground

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(2, "\n    ");
            __builder.AddMarkupContent(3, "<label for=\"city\">City</label>\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "name", "city");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "disabled", true);
            __builder.AddAttribute(10, "selected", true);
            __builder.AddContent(11, "Select City");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 5 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
         foreach (string City in Cities)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 7 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
                            City

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "selected", 
#nullable restore
#line 7 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
                                              City==MyCity

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
                                                                        HandleSelect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, 
#nullable restore
#line 7 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
                                                                                       City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 8 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n\n\n\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "panel-body");
            __builder.AddContent(25, 
#nullable restore
#line 15 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
                         Weather

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "panel-body");
            __builder.AddContent(29, 
#nullable restore
#line 16 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
                         Elevation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/Users/vimalraveendran/Desktop/blazor/NewBlazor/NewBlazor/Pages/SelectCity.razor"
       

    public string[] Cities = new string[] { "Washington DC", "Warsaw", "London" };
    [Parameter]
    public string MyCity { get; set; }

    [Parameter]
    public string MyBackground { get; set; }



    [Parameter]
    public RenderFragment Weather { get; set; }
    [Parameter]
    public RenderFragment Elevation { get; set; }


    [Parameter]
    public EventCallback<string> myCustomEvent { get; set; }

    public async Task HandleSelect(ChangeEventArgs e)
    {
        string SelectedValue = e.Value as string;
        await myCustomEvent.InvokeAsync(SelectedValue);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
