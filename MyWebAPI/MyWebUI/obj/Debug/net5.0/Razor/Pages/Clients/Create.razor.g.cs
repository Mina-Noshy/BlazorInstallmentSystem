#pragma checksum "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7366d4e4ae4681aa4536d5e851a7b38a6ac0537"
// <auto-generated/>
#pragma warning disable 1591
namespace MyWebUI.Pages.Clients
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div><h4>اضافة عميل</h4></div>");
#nullable restore
#line 7 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
 if (_client == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MyWebUI.Shared.Loading>(1);
            __builder.AddAttribute(2, "Title", "Create Client");
            __builder.AddAttribute(3, "Message", "please wait...");
            __builder.CloseComponent();
#nullable restore
#line 10 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                  _client

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.AddMarkupContent(10, "<h3>العميل</h3>\r\n    <hr>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group row");
                __builder2.AddMarkupContent(15, "<label class=\"col-sm-2 col-form-label\">\r\n            الاسم\r\n        </label>\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "name");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "placeholder", "اسم العميل");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                    _client.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _client.Name = __value, _client.Name))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _client.Name));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MyWebUI.Pages.Clients.Create.TypeInference.CreateValidationMessage_0(__builder3, 26, 27, 
#nullable restore
#line 26 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                          () => _client.Name

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group row");
                __builder2.AddMarkupContent(31, "<label class=\"col-sm-2 col-form-label\">\r\n            العنوان\r\n        </label>\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "addressDetails");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "العنوان (مدينة,حى,شارع)");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                    _client.AddressDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _client.AddressDetails = __value, _client.AddressDetails))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _client.AddressDetails));
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MyWebUI.Pages.Clients.Create.TypeInference.CreateValidationMessage_1(__builder3, 42, 43, 
#nullable restore
#line 37 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                          () => _client.AddressDetails

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group row");
                __builder2.AddMarkupContent(47, "<label class=\"col-sm-2 col-form-label\">\r\n           رقم الهاتف\r\n        </label>\r\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "id", "phone_1");
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "placeholder", "رقم الهاتف المحمول");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                    _client.Phone_1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _client.Phone_1 = __value, _client.Phone_1))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _client.Phone_1));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MyWebUI.Pages.Clients.Create.TypeInference.CreateValidationMessage_2(__builder3, 58, 59, 
#nullable restore
#line 48 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                          () => _client.Phone_1

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n    ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group row");
                __builder2.AddMarkupContent(63, "<label class=\"col-sm-2 col-form-label\">\r\n            رقم الهاتف\r\n        </label>\r\n        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "id", "phone_2");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "placeholder", "رقم الهاتف المحمول");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                    _client.Phone_2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _client.Phone_2 = __value, _client.Phone_2))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _client.Phone_2));
                __builder2.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MyWebUI.Pages.Clients.Create.TypeInference.CreateValidationMessage_3(__builder3, 74, 75, 
#nullable restore
#line 59 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                          () => _client.Phone_2

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group row");
                __builder2.AddMarkupContent(79, "<label class=\"col-sm-2 col-form-label\">\r\n            رقم الهاتف\r\n        </label>\r\n        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(82);
                __builder2.AddAttribute(83, "id", "phone_3");
                __builder2.AddAttribute(84, "class", "form-control");
                __builder2.AddAttribute(85, "placeholder", "رقم الهاتف المحمول");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                    _client.Phone_3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _client.Phone_3 = __value, _client.Phone_3))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _client.Phone_3));
                __builder2.AddAttribute(89, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MyWebUI.Pages.Clients.Create.TypeInference.CreateValidationMessage_4(__builder3, 90, 91, 
#nullable restore
#line 70 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                          () => _client.Phone_3

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n    ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group row");
                __builder2.AddMarkupContent(95, "<label class=\"col-sm-2 col-form-label\">\r\n            البريد الالكترونى\r\n        </label>\r\n        ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                __builder2.AddAttribute(99, "id", "email");
                __builder2.AddAttribute(100, "class", "form-control");
                __builder2.AddAttribute(101, "placeholder", "البريد الالكترونى");
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                    _client.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _client.Email = __value, _client.Email))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _client.Email));
                __builder2.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MyWebUI.Pages.Clients.Create.TypeInference.CreateValidationMessage_5(__builder3, 106, 107, 
#nullable restore
#line 81 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                          () => _client.Email

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n    ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "form-group row");
                __builder2.AddMarkupContent(111, "<label class=\"col-sm-2 col-form-label\">\r\n            فاكس\r\n        </label>\r\n        ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(114);
                __builder2.AddAttribute(115, "id", "fax");
                __builder2.AddAttribute(116, "class", "form-control");
                __builder2.AddAttribute(117, "placeholder", "رقم الفاكس");
                __builder2.AddAttribute(118, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 91 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                    _client.Fax

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(119, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _client.Fax = __value, _client.Fax))));
                __builder2.AddAttribute(120, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _client.Fax));
                __builder2.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MyWebUI.Pages.Clients.Create.TypeInference.CreateValidationMessage_6(__builder3, 122, 123, 
#nullable restore
#line 92 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
                                          () => _client.Fax

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n    ");
                __builder2.AddMarkupContent(125, "<div><button type=\"submit\" class=\"btn btn-success\">اضافة العميل</button>\r\n        <a href=\"/clients/list\" class=\"btn btn-primary\">الغاء</a></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 102 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "F:\Projects\Web\InstallmentManagementSystem\MyWebAPI\MyWebUI\Pages\Clients\Create.razor"
       

    [Inject]
    public IClientService _service { get; set; }

    [Inject]
    public NavigationManager _navigation { get; set; }

    public Client _client { get; set; } = new Client();

    protected async override Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }

    private async Task HandleValidSubmit()
    {
        await _service.Add(_client);
        _navigation.NavigateTo("/clients/list");
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MyWebUI.Pages.Clients.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591