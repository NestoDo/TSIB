#pragma checksum "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91e4cbbb781d55e0c7eb29d25c8c6d42d2cdf870"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/attendance")]
    public partial class Attendance : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Asistencia</h3>\r\n\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control form-control-sm");
            __builder.AddAttribute(3, "name", "Estatus");
            __builder.AddAttribute(4, "id", "status");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                  AttendanceGetData_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                        Month

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Month = __value, Month));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "value", "1");
            __builder.AddContent(11, "Enero");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", "2");
            __builder.AddContent(15, "Febrero");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "3");
            __builder.AddContent(19, "Marzo");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "4");
            __builder.AddContent(23, "Abril");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "5");
            __builder.AddContent(27, "Mayo");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "6");
            __builder.AddContent(31, "Junio");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "7");
            __builder.AddContent(35, "Julio");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "option");
            __builder.AddAttribute(38, "value", "8");
            __builder.AddContent(39, "Agosto");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "option");
            __builder.AddAttribute(42, "value", "9");
            __builder.AddContent(43, "Septiembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", "10");
            __builder.AddContent(47, "Octubre");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", "11");
            __builder.AddContent(51, "Noviembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.OpenElement(53, "option");
            __builder.AddAttribute(54, "value", "12");
            __builder.AddContent(55, "Diciembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "class", "form-control form-control-sm");
            __builder.AddAttribute(60, "name", "Estatus");
            __builder.AddAttribute(61, "id", "status");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                  AttendanceGetData_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                        Year

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Year = __value, Year));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "2015");
            __builder.AddContent(68, "2015");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "2016");
            __builder.AddContent(72, "2016");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "2017");
            __builder.AddContent(76, "2017");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", "2018");
            __builder.AddContent(80, "2018");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.OpenElement(82, "option");
            __builder.AddAttribute(83, "value", "2019");
            __builder.AddContent(84, "2019");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.OpenElement(86, "option");
            __builder.AddAttribute(87, "value", "2020");
            __builder.AddContent(88, "2020");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.OpenElement(90, "option");
            __builder.AddAttribute(91, "value", "2021");
            __builder.AddContent(92, "2021");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.OpenElement(94, "option");
            __builder.AddAttribute(95, "value", "2022");
            __builder.AddContent(96, "2022");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", "2023");
            __builder.AddContent(100, "2023");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n\r\n");
#nullable restore
#line 32 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
 if (Employees == null || Attendances == null || AttendanceTypes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(103, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 35 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "    ");
            __builder.OpenElement(105, "table");
            __builder.AddAttribute(106, "class", "table table-hover table-sm table-bordered");
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.OpenElement(108, "thead");
            __builder.AddMarkupContent(109, "\r\n            ");
            __builder.OpenElement(110, "tr");
            __builder.AddMarkupContent(111, "\r\n                ");
            __builder.AddMarkupContent(112, "<th scope=\"col\">Empleado</th>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                 for (int i = 1; i <= Days; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "                    ");
            __builder.OpenElement(114, "th");
            __builder.AddAttribute(115, "scope", "col");
            __builder.AddContent(116, 
#nullable restore
#line 45 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                     i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
#nullable restore
#line 46 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(118, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.OpenElement(121, "tbody");
            __builder.AddMarkupContent(122, "\r\n\r\n            ");
            __builder.OpenElement(123, "tr");
            __builder.AddMarkupContent(124, "\r\n                <th scope=\"col\"></th>\r\n\r\n");
#nullable restore
#line 55 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                 for (int i = 1; i <= Days; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "                    ");
            __builder.AddMarkupContent(126, "<th scope=\"col\">\r\n                        Mierco\r\n                    </th>\r\n");
#nullable restore
#line 61 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(127, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n\r\n\r\n");
#nullable restore
#line 66 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
             foreach (var attendance in AttendancesViewModel)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "                ");
            __builder.OpenElement(130, "tr");
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.OpenElement(132, "th");
            __builder.AddAttribute(133, "scope", "row");
            __builder.AddContent(134, 
#nullable restore
#line 69 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                     attendance.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n\r\n");
#nullable restore
#line 71 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                     for (int i = 1; i < attendance.Attendance.Length; i++)
                    {

                        int iDay = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(136, "                        ");
            __builder.OpenElement(137, "td");
            __builder.AddMarkupContent(138, "\r\n                            ");
            __builder.OpenElement(139, "input");
            __builder.AddAttribute(140, "type", "text");
            __builder.AddAttribute(141, "class", "form-control form-control-sm");
            __builder.AddAttribute(142, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                             (() => SaveAttenndace_Click(attendance, Convert.ToInt32(Year), Convert.ToInt32(Month), iDay))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                                                                                                         attendance.Attendance[iDay]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(144, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => attendance.Attendance[iDay] = __value, attendance.Attendance[iDay]));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 78 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n");
#nullable restore
#line 80 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(149, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n");
#nullable restore
#line 83 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
