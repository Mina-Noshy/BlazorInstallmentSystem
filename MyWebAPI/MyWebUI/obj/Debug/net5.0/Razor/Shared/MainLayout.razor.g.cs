#pragma checksum "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3095e1810979123116e1b394547820b548e95071"
// <auto-generated/>
#pragma warning disable 1591
namespace MyWebUI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebModels.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebModels.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebModels.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using MyWebUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-zq7d4gqgj8");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-zq7d4gqgj8");
            __builder.OpenComponent<MyWebUI.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-zq7d4gqgj8");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-zq7d4gqgj8><a href=\"http://eastaria.com\" target=\"_blank\" class=\"ml-md-auto\" b-zq7d4gqgj8>Eastaria</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-zq7d4gqgj8");
            __builder.AddContent(15, 
#nullable restore
#line 14 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
