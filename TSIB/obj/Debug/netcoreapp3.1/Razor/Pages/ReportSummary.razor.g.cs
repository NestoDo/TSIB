#pragma checksum "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad40b2e3419c022d2a4b2cbaeec0e8bfb35450c"
// <auto-generated/>
#pragma warning disable 1591
namespace TSIB.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using TSIB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\omare\source\repos\TSIB\TSIB\_Imports.razor"
using TSIB.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/reportsummary")]
    public partial class ReportSummary : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Reporte Acumulado</h4>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 8 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header");
            __builder.AddMarkupContent(8, "\r\n\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group row");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"employeeId\" class=\"col-sm-2 col-form-label\">\r\n                    Empleado\r\n                </label>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-sm-4");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "style", "padding-left:0; padding-right:0; border-left:0; border-right:0; border:none; outline:0px;");
            __builder.AddAttribute(18, "class", "form-control form-control-sm");
            __builder.AddAttribute(19, "name", "EmployeeId");
            __builder.AddAttribute(20, "id", "employeeId");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
                                                                                                                                                                                                                  EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EmployeeId = __value, EmployeeId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "0");
            __builder.AddContent(26, "Todos");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 21 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
                         foreach (var employee in Employees)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "                            ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", 
#nullable restore
#line 23 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
                                            employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, 
#nullable restore
#line 23 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
                                                                  employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " ");
            __builder.AddContent(33, 
#nullable restore
#line 23 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
                                                                                      employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 24 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n                ");
            __builder.AddMarkupContent(38, "<label for=\"date\" class=\"col-sm-2 col-form-label\">\r\n                    Fecha Final\r\n                </label>\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-sm-4");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "date");
            __builder.AddAttribute(44, "id", "date");
            __builder.AddAttribute(45, "name", "date");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
                                                                          Date

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(47, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Date = __value, Date, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 39 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\ReportSummary.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591