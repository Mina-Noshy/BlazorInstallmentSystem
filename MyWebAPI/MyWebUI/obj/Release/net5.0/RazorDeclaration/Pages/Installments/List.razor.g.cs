// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyWebUI.Pages.Installments
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/installments/list")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 163 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
       

    [Inject]
    public IInstallmentServices _service { get; set; }

    private IEnumerable<Installment> _installments;

    private DateTime _dateTime = DateTime.UtcNow.Date;

    protected override async Task OnInitializedAsync()
    {
        _installments = await _service.GetAllToday();
    }

    private async Task GetAll()
    {
        _installments = null;
        _installments = await _service.GetAll();
    }

    private async Task GetAllReceived()
    {
        _installments = null;
        _installments = await _service.GetAllReceived();
    }

    private async Task GetAllUnreceived()
    {
        _installments = null;
        _installments = await _service.GetAllUnreceived();
    }

    private async Task GetAllToday()
    {
        _installments = null;
        _installments = await _service.GetAllToday();
    }

    private async Task GetReceivedToday()
    {
        _installments = null;
        _installments = await _service.GetReceivedToday();
    }

    private async Task GetUnreceivedToday()
    {
        _installments = null;
        _installments = await _service.GetUnreceivedToday();
    }

    private async Task GetByDay()
    {
        _installments = null;
        _installments = await _service.GetByDay(_dateTime);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591