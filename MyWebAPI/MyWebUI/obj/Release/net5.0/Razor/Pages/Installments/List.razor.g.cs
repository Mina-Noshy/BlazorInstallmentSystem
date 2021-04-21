#pragma checksum "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ad15da8935bfac7ba1e9c01d40d07723eb70185"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<h4>قائمة الاقساط</h4>\r\n\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "input-group col-md-4");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "date");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                                        _dateTime

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _dateTime = __value, _dateTime, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "input-group-append");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                                e => GetByDay()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "input-group-text text-success font-weight-bold");
            __builder.AddMarkupContent(15, "<i class=\"fa fa-search\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "style", "margin:3px;");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                                            e => GetAll()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "class", "btn btn-outline-info");
            __builder.AddMarkupContent(21, "جميع الاقساط");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "style", "margin:3px;");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                                            e => GetAllUnreceived()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "btn btn-outline-info");
            __builder.AddMarkupContent(27, "كل الاقساط الغير مستلمة");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "style", "margin:3px;");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                                            e => GetAllReceived()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-outline-info");
            __builder.AddMarkupContent(33, "كل الاقساط المستلمة");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "style", "margin:3px;");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                                            e => GetAllToday()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "class", "btn btn-outline-info");
            __builder.AddMarkupContent(39, "اقساط اليوم");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "style", "margin:3px;");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                                            e => GetUnreceivedToday()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "class", "btn btn-outline-info");
            __builder.AddMarkupContent(45, "اقساط اليوم الغير مستلمة");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "style", "margin:3px;");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                                            e => GetReceivedToday()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "class", "btn btn-outline-info");
            __builder.AddMarkupContent(51, "اقساط اليوم المستلمة");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
 if (_installments == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MyWebUI.Shared.Loading>(52);
            __builder.AddAttribute(53, "Title", "Installments List");
            __builder.AddAttribute(54, "Message", "please wait...");
            __builder.CloseComponent();
#nullable restore
#line 26 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
}
else
{

    if (_installments.Count() > 0)
    {
        int days = 0;


#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "table");
            __builder.AddAttribute(56, "class", "table table-responsive");
            __builder.AddMarkupContent(57, @"<thead><tr><th>الكود</th>
            <th>العميل</th>
            <th>قيمة القسط</th>
            <th>تاريخ الاستحقاق</th>
            <th>التاخير</th>
            <th>غرامة التاخير</th>
            <th>الاستلام</th>
            <th>خيارات</th></tr></thead>
    ");
            __builder.OpenElement(58, "tbody");
#nullable restore
#line 48 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
         foreach (var item in _installments)
        {
            if (item.DueDate.Date <= DateTime.UtcNow.Date)
            {
                days = (int)(DateTime.UtcNow - item.DueDate).TotalDays;
            }
            else
            {
                days = 0;
            }


#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "tr");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 60 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                 item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 61 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                 item.GetBill.GetClient.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 62 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                 item.AmountValue.ToString(".00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 63 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                 item.DueDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 65 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
             if (item.GetBill.DelayFineType == DelayFineTypes.سنوى)
            {
                if (days != 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "td");
            __builder.AddContent(72, 
#nullable restore
#line 70 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                          (days/365).ToString("0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(73, " سنة\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                    ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 73 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                          ((days / 365) * item.GetBill.DelayFine).ToString("0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(77, " جنيه\r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 75 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "<td>\r\n                        0 سنة\r\n                    </td>\r\n                    ");
            __builder.AddMarkupContent(79, "<td>\r\n                        0 جنيه\r\n                    </td>");
#nullable restore
#line 84 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                }
            }
            else if (item.GetBill.DelayFineType == DelayFineTypes.شهرى)
            {
                if (days != 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 91 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                          (days/30).ToString("0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(82, " شهر\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                    ");
            __builder.OpenElement(84, "td");
            __builder.AddContent(85, 
#nullable restore
#line 94 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                          ((days / 30) * item.GetBill.DelayFine).ToString("0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(86, " جنيه\r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 96 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, "<td>\r\n                        0 شهر\r\n                    </td>\r\n                    ");
            __builder.AddMarkupContent(88, "<td>\r\n                        0 جنيه\r\n                    </td>");
#nullable restore
#line 105 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                }
            }
            else
            {
                if (days != 0)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(89, "td");
            __builder.AddContent(90, 
#nullable restore
#line 112 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                          (days).ToString("0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(91, " يوم\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 115 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                          (days * item.GetBill.DelayFine).ToString("0")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(95, " جنيه\r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 117 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "<td>\r\n                        0 يوم\r\n                    </td>\r\n                    ");
            __builder.AddMarkupContent(97, "<td>\r\n                        0 جنيه\r\n                    </td>");
#nullable restore
#line 126 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
             if (item.ReceivedDate != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "td");
            __builder.AddContent(99, 
#nullable restore
#line 131 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                     item.ReceivedDate?.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.OpenElement(101, "a");
            __builder.AddAttribute(102, "href", 
#nullable restore
#line 132 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                           $"/installments/details/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(103, "class", "btn btn-primary");
            __builder.AddMarkupContent(104, "تفاصيل");
            __builder.CloseElement();
#nullable restore
#line 133 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
            }
            else
            {
                if (item.DueDate < DateTime.UtcNow)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(105, "<td class=\"text-danger\">فى انتظار السداد</td>\r\n                    ");
            __builder.OpenElement(106, "a");
            __builder.AddAttribute(107, "href", 
#nullable restore
#line 139 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                               $"/installments/details/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(108, "class", "btn btn-danger");
            __builder.AddMarkupContent(109, "تفاصيل");
            __builder.CloseElement();
#nullable restore
#line 140 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(110, "<td>ليس بعد</td>\r\n                    ");
            __builder.OpenElement(111, "a");
            __builder.AddAttribute(112, "href", 
#nullable restore
#line 144 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                               $"/installments/details/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(113, "class", "btn btn-success");
            __builder.AddMarkupContent(114, "تفاصيل");
            __builder.CloseElement();
#nullable restore
#line 145 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 148 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 151 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(115, "<div class=\"text-center\" style=\"margin:50px 10px;\"><h3>\r\n                قائمة الاقساط فارغة <br> <a href=\"/bills/create\">انشاء فاتورة الان </a></h3></div>");
#nullable restore
#line 159 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Installments\List.razor"
    }

}

#line default
#line hidden
#nullable disable
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