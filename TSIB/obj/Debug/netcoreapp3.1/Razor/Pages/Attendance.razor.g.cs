#pragma checksum "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae135f64d3facbb4e363bb73349cd388d0eb057e"
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
            __builder.AddMarkupContent(0, "<h4>Asistencia</h4>\r\n");
#nullable restore
#line 4 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
 if (Attendances == null || AttendanceTypes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 7 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
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
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group row");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"monthId\" class=\"col-sm-2 col-form-label\">\r\n                    Mes\r\n                </label>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-sm-4");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "select");
            __builder.AddAttribute(17, "class", "form-control form-control-sm");
            __builder.AddAttribute(18, "name", "Mes");
            __builder.AddAttribute(19, "id", "monthId");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                      Month

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Month = __value, Month));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "option");
            __builder.AddAttribute(24, "value", "1");
            __builder.AddContent(25, "Enero");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "2");
            __builder.AddContent(29, "Febrero");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "3");
            __builder.AddContent(33, "Marzo");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "4");
            __builder.AddContent(37, "Abril");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "5");
            __builder.AddContent(41, "Mayo");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "6");
            __builder.AddContent(45, "Junio");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "7");
            __builder.AddContent(49, "Julio");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "8");
            __builder.AddContent(53, "Agosto");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "9");
            __builder.AddContent(57, "Septiembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "10");
            __builder.AddContent(61, "Octubre");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "11");
            __builder.AddContent(65, "Noviembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                        ");
            __builder.OpenElement(67, "option");
            __builder.AddAttribute(68, "value", "12");
            __builder.AddContent(69, "Diciembre");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n                ");
            __builder.AddMarkupContent(73, "<label for=\"yearId\" class=\"col-sm-2 col-form-label\">\r\n                    Año\r\n                </label>\r\n\r\n                ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-sm-4");
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "select");
            __builder.AddAttribute(78, "class", "form-control form-control-sm");
            __builder.AddAttribute(79, "name", "Año");
            __builder.AddAttribute(80, "id", "yearId");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                     Year

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Year = __value, Year));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "option");
            __builder.AddAttribute(85, "value", "2015");
            __builder.AddContent(86, "2015");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                        ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", "2016");
            __builder.AddContent(90, "2016");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", "2017");
            __builder.AddContent(94, "2017");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "option");
            __builder.AddAttribute(97, "value", "2018");
            __builder.AddContent(98, "2018");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "option");
            __builder.AddAttribute(101, "value", "2019");
            __builder.AddContent(102, "2019");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                        ");
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", "2020");
            __builder.AddContent(106, "2020");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "2021");
            __builder.AddContent(110, "2021");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", "2022");
            __builder.AddContent(114, "2022");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.OpenElement(116, "option");
            __builder.AddAttribute(117, "value", "2023");
            __builder.AddContent(118, "2023");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.OpenElement(120, "option");
            __builder.AddAttribute(121, "value", "2024");
            __builder.AddContent(122, "2024");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.OpenElement(124, "option");
            __builder.AddAttribute(125, "value", "2025");
            __builder.AddContent(126, "2025");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                        ");
            __builder.OpenElement(128, "option");
            __builder.AddAttribute(129, "value", "2026");
            __builder.AddContent(130, "2026");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                        ");
            __builder.OpenElement(132, "option");
            __builder.AddAttribute(133, "value", "2027");
            __builder.AddContent(134, "2027");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                        ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", "2028");
            __builder.AddContent(138, "2028");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                        ");
            __builder.OpenElement(140, "option");
            __builder.AddAttribute(141, "value", "2029");
            __builder.AddContent(142, "2029");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                        ");
            __builder.OpenElement(144, "option");
            __builder.AddAttribute(145, "value", "2030");
            __builder.AddContent(146, "2030");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                        ");
            __builder.OpenElement(148, "option");
            __builder.AddAttribute(149, "value", "2031");
            __builder.AddContent(150, "2031");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                        ");
            __builder.OpenElement(152, "option");
            __builder.AddAttribute(153, "value", "2032");
            __builder.AddContent(154, "2032");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                        ");
            __builder.OpenElement(156, "option");
            __builder.AddAttribute(157, "value", "2033");
            __builder.AddContent(158, "2033");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                        ");
            __builder.OpenElement(160, "option");
            __builder.AddAttribute(161, "value", "2034");
            __builder.AddContent(162, "2034");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n                        ");
            __builder.OpenElement(164, "option");
            __builder.AddAttribute(165, "value", "2035");
            __builder.AddContent(166, "2035");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n                        ");
            __builder.OpenElement(168, "option");
            __builder.AddAttribute(169, "value", "2036");
            __builder.AddContent(170, "2036");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                        ");
            __builder.OpenElement(172, "option");
            __builder.AddAttribute(173, "value", "2037");
            __builder.AddContent(174, "2037");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                        ");
            __builder.OpenElement(176, "option");
            __builder.AddAttribute(177, "value", "2038");
            __builder.AddContent(178, "2038");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                        ");
            __builder.OpenElement(180, "option");
            __builder.AddAttribute(181, "value", "2039");
            __builder.AddContent(182, "2039");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n                        ");
            __builder.OpenElement(184, "option");
            __builder.AddAttribute(185, "value", "2040");
            __builder.AddContent(186, "2040");
            __builder.CloseElement();
            __builder.AddMarkupContent(187, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n\r\n            ");
            __builder.OpenElement(191, "div");
            __builder.AddAttribute(192, "class", "form-group row");
            __builder.AddMarkupContent(193, "\r\n                ");
            __builder.AddMarkupContent(194, "<label for=\"employeeId\" class=\"col-sm-2 col-form-label\">\r\n                    Empleado\r\n                </label>\r\n                ");
            __builder.OpenElement(195, "div");
            __builder.AddAttribute(196, "class", "col-sm-4");
            __builder.AddMarkupContent(197, "\r\n                    ");
            __builder.OpenElement(198, "select");
            __builder.AddAttribute(199, "style", "padding-left:0; padding-right:0; border-left:0; border-right:0;");
            __builder.AddAttribute(200, "class", "form-control form-control-sm");
            __builder.AddAttribute(201, "name", "EmployeeId");
            __builder.AddAttribute(202, "id", "employeeId");
            __builder.AddAttribute(203, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                                                                                        EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(204, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => EmployeeId = __value, EmployeeId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(205, "\r\n                        ");
            __builder.OpenElement(206, "option");
            __builder.AddAttribute(207, "value", "0");
            __builder.AddContent(208, "Todos");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n");
#nullable restore
#line 78 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                         foreach (var employee in Employees)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(210, "                            ");
            __builder.OpenElement(211, "option");
            __builder.AddAttribute(212, "value", 
#nullable restore
#line 80 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                            employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(213, 
#nullable restore
#line 80 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                  employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(214, " ");
            __builder.AddContent(215, 
#nullable restore
#line 80 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                      employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n");
#nullable restore
#line 81 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(217, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n\r\n\r\n            ");
            __builder.OpenElement(221, "div");
            __builder.AddAttribute(222, "class", "form-group row d-flex justify-content-between");
            __builder.AddMarkupContent(223, "\r\n                ");
            __builder.OpenElement(224, "div");
            __builder.AddMarkupContent(225, "\r\n                    ");
            __builder.OpenElement(226, "button");
            __builder.AddAttribute(227, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(228, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                     AttendanceSearch_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(229, "<span class=\"oi oi-magnifying-glass\" aria-hidden=\"true\"></span> Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(230, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(233, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(234, "\r\n");
            __builder.AddContent(235, "    ");
            __builder.OpenElement(236, "table");
            __builder.AddAttribute(237, "class", "table table-hover table-sm table-bordered");
            __builder.AddMarkupContent(238, "\r\n        ");
            __builder.OpenElement(239, "thead");
            __builder.AddMarkupContent(240, "\r\n            ");
            __builder.OpenElement(241, "tr");
            __builder.AddMarkupContent(242, "\r\n                ");
            __builder.AddMarkupContent(243, "<th scope=\"col\" style=\"font-family: Arial, Helvetica, sans-serif;\">Empleado</th>\r\n\r\n");
#nullable restore
#line 102 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                 for (int i = 1; i <= Days; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(244, "                    ");
            __builder.OpenElement(245, "th");
            __builder.AddAttribute(246, "scope", "col");
            __builder.AddContent(247, 
#nullable restore
#line 104 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                     i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(248, "\r\n");
#nullable restore
#line 105 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(249, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(250, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(251, "\r\n        ");
            __builder.OpenElement(252, "tbody");
            __builder.AddMarkupContent(253, "\r\n\r\n            ");
            __builder.OpenElement(254, "tr");
            __builder.AddMarkupContent(255, "\r\n                <th scope=\"col\"></th>\r\n\r\n");
#nullable restore
#line 114 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                 for (int i = 1; i <= Days; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(256, "                    ");
            __builder.AddMarkupContent(257, "<th scope=\"col\">\r\n                        Mierc\r\n                    </th>\r\n");
#nullable restore
#line 120 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(258, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(259, "\r\n\r\n\r\n");
#nullable restore
#line 125 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
             foreach (var attendance in AttendancesViewModel)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(260, "                ");
            __builder.OpenElement(261, "tr");
            __builder.AddMarkupContent(262, "\r\n                    ");
            __builder.OpenElement(263, "th");
            __builder.AddAttribute(264, "scope", "row");
            __builder.AddContent(265, 
#nullable restore
#line 128 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                     attendance.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(266, "\r\n\r\n");
#nullable restore
#line 130 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                     for (int i = 1; i < attendance.Attendance.Length; i++)
                    {

                        int iDay = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(267, "                        ");
            __builder.OpenElement(268, "td");
            __builder.AddAttribute(269, "style", "padding-left:0; padding-right:0;");
            __builder.AddMarkupContent(270, "\r\n\r\n                            ");
            __builder.OpenElement(271, "select");
            __builder.AddAttribute(272, "style", "padding-left:0; padding-right:0; border-left:0; border-right:0;");
            __builder.AddAttribute(273, "class", "form-control form-control-sm");
            __builder.AddAttribute(274, "name", "AttendanceType");
            __builder.AddAttribute(275, "id", "attendanceTypeId");
            __builder.AddAttribute(276, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 136 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                                                                                                                                                                              (() => SaveAttenndace_Click(attendance, Convert.ToInt32(Year), Convert.ToInt32(Month), iDay))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(277, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 136 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                                                                                                          attendance.Attendance[iDay]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(278, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => attendance.Attendance[iDay] = __value, attendance.Attendance[iDay]));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(279, "\r\n");
#nullable restore
#line 137 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                 foreach (var attendanceType in AttendanceTypes)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(280, "                                    ");
            __builder.OpenElement(281, "option");
            __builder.AddAttribute(282, "value", 
#nullable restore
#line 139 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                    attendanceType.AttendanceTypeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(283, 
#nullable restore
#line 139 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                      attendanceType.ShortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(284, "\r\n");
#nullable restore
#line 140 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(285, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(286, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(287, "\r\n");
#nullable restore
#line 143 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(288, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(289, "\r\n");
#nullable restore
#line 145 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(290, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(291, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(292, "\r\n");
#nullable restore
#line 148 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
