#pragma checksum "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d684231663f4df72d4531527e355cb3f6a9a5bc"
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
#nullable restore
#line 2 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
using System.Globalization;

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
#line 5 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
 if (Attendances == null || AttendanceTypes == null || Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 8 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
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
#line 19 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
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
#line 41 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
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
            __builder.AddAttribute(199, "style", "padding-left:0; padding-right:0; border-left:0; border-right:0; border:none; outline:0px;");
            __builder.AddAttribute(200, "class", "form-control form-control-sm");
            __builder.AddAttribute(201, "name", "EmployeeId");
            __builder.AddAttribute(202, "id", "employeeId");
            __builder.AddAttribute(203, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
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
#line 79 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                         foreach (var employee in Employees)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(210, "                            ");
            __builder.OpenElement(211, "option");
            __builder.AddAttribute(212, "value", 
#nullable restore
#line 81 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                            employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(213, 
#nullable restore
#line 81 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                  employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(214, " ");
            __builder.AddContent(215, 
#nullable restore
#line 81 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                      employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n");
#nullable restore
#line 82 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
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
#line 90 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
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
            __builder.AddMarkupContent(233, "\r\n\r\n        ");
            __builder.OpenElement(234, "div");
            __builder.AddAttribute(235, "class", "card-header");
            __builder.AddMarkupContent(236, "\r\n            ");
            __builder.OpenElement(237, "div");
            __builder.AddAttribute(238, "class", "row");
            __builder.AddMarkupContent(239, "\r\n                ");
            __builder.OpenElement(240, "div");
            __builder.AddAttribute(241, "class", "col d-flex justify-content-center");
            __builder.AddMarkupContent(242, "\r\n                    ");
            __builder.OpenElement(243, "h3");
            __builder.AddAttribute(244, "class", "d-flex align-items-center");
            __builder.OpenElement(245, "span");
            __builder.AddAttribute(246, "class", "badge badge-pill badge-primary");
            __builder.AddContent(247, 
#nullable restore
#line 99 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                        MonthText

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(248, " / ");
            __builder.AddContent(249, 
#nullable restore
#line 99 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                     Year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(250, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(251, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(252, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\r\n\r\n        ");
            __builder.OpenElement(254, "div");
            __builder.AddAttribute(255, "class", "card-header");
            __builder.AddMarkupContent(256, "\r\n            ");
            __builder.OpenElement(257, "div");
            __builder.AddAttribute(258, "class", "div-table-fixed");
            __builder.AddMarkupContent(259, "\r\n                ");
            __builder.OpenElement(260, "table");
            __builder.AddAttribute(261, "class", "table table-bordered table-hover table-fixed table-responsive");
            __builder.AddMarkupContent(262, "\r\n                    ");
            __builder.OpenElement(263, "thead");
            __builder.AddMarkupContent(264, "\r\n                        ");
            __builder.OpenElement(265, "tr");
            __builder.AddAttribute(266, "class", "topheader");
            __builder.AddMarkupContent(267, "\r\n                            ");
            __builder.AddMarkupContent(268, "<th scope=\"col\" class=\"backGray\">Nombre&nbsp;del&nbsp;Empleado</th>\r\n\r\n");
#nullable restore
#line 112 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                             for (int i = 1; i <= Days; i++)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(269, "                                ");
            __builder.OpenElement(270, "th");
            __builder.AddAttribute(271, "scope", "col");
            __builder.AddAttribute(272, "class", "backGray");
            __builder.AddContent(273, 
#nullable restore
#line 114 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                  i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(274, "\r\n");
#nullable restore
#line 115 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(275, "\r\n                            <th scope=\"col\" class=\"backGray\"></th>\r\n                            <th scope=\"col\" class=\"backGray\"></th>\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(276, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(277, "\r\n                    ");
            __builder.OpenElement(278, "tbody");
            __builder.AddMarkupContent(279, "\r\n\r\n                        ");
            __builder.OpenElement(280, "tr");
            __builder.AddAttribute(281, "class", "topheader");
            __builder.AddMarkupContent(282, "\r\n                            <td scope=\"row\" class=\"backGray\"></td>\r\n\r\n");
#nullable restore
#line 127 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                             for (int i = 1; i <= Days; i++)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(283, "                                ");
            __builder.OpenElement(284, "td");
            __builder.AddAttribute(285, "class", "backGray");
            __builder.AddMarkupContent(286, "\r\n                                    ");
            __builder.AddContent(287, 
#nullable restore
#line 130 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                      
                                new CultureInfo("Es-Es").DateTimeFormat.GetDayName(new DateTime(Convert.ToInt32(YearSearch), Convert.ToInt32(MonthSearch), i).DayOfWeek).Substring(0, 3)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(288, "\r\n\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(289, "\r\n");
#nullable restore
#line 134 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(290, "\r\n                            ");
            __builder.AddMarkupContent(291, "<th scope=\"col\" class=\"backGray\">Estancias</th>\r\n                            ");
            __builder.AddMarkupContent(292, "<th scope=\"col\" class=\"backGray\">Descansos</th>\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(293, "\r\n\r\n\r\n");
#nullable restore
#line 142 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                         foreach (var attendance in AttendancesViewModel)
                        {
                            int contTypeE = 0;
                            int contTypeD = 0;

#line default
#line hidden
#nullable disable
            __builder.AddContent(294, "                            ");
            __builder.OpenElement(295, "tr");
            __builder.AddMarkupContent(296, "\r\n                                ");
            __builder.OpenElement(297, "td");
            __builder.AddAttribute(298, "class", "backGray");
            __builder.AddAttribute(299, "scope", "row");
            __builder.AddAttribute(300, "style", "font-size: 13px; padding-bottom:0px; padding-top:0px;");
            __builder.AddContent(301, 
#nullable restore
#line 147 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                                attendance.EmployeeName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(302, "\r\n\r\n");
#nullable restore
#line 149 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                 for (int i = 1; i < attendance.Attendance.Length; i++)
                                {

                                    int iDay = i;
                                    if (attendance.Attendance[iDay] == 3)
                                    {
                                        contTypeE++;
                                    }
                                    else if (attendance.Attendance[iDay] == 2)
                                    {
                                        contTypeD++;
                                    }


#line default
#line hidden
#nullable disable
            __builder.AddContent(303, "                                    ");
            __builder.OpenElement(304, "td");
            __builder.AddAttribute(305, "style", "padding-left:0; padding-right:0; padding-bottom:0px; padding-top:0px;");
            __builder.AddMarkupContent(306, "\r\n\r\n                                        ");
            __builder.OpenElement(307, "select");
            __builder.AddAttribute(308, "style", "width: 50px; padding-left: 0; padding-right: 0; border-left: 0; border-right: 0;");
            __builder.AddAttribute(309, "class", "form-control form-control-sm");
            __builder.AddAttribute(310, "name", "AttendanceType");
            __builder.AddAttribute(311, "id", "attendanceTypeId");
            __builder.AddAttribute(312, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 164 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                                                                                                                                                                                                           (() => SaveAttenndace_Click(attendance, Convert.ToInt32(Year), Convert.ToInt32(Month), iDay))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(313, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 164 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                                                                                                                                                       attendance.Attendance[iDay]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(314, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => attendance.Attendance[iDay] = __value, attendance.Attendance[iDay]));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(315, "\r\n");
#nullable restore
#line 165 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                             foreach (var attendanceType in AttendanceTypes)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(316, "                                                ");
            __builder.OpenElement(317, "option");
            __builder.AddAttribute(318, "value", 
#nullable restore
#line 167 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                attendanceType.AttendanceTypeId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(319, 
#nullable restore
#line 167 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                                                                                  attendanceType.ShortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(320, "\r\n");
#nullable restore
#line 168 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(321, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(322, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(323, "\r\n");
#nullable restore
#line 171 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(324, "\r\n                                ");
            __builder.OpenElement(325, "td");
            __builder.AddAttribute(326, "style", "padding-left:0; padding-right:0; padding-bottom:0px; padding-top:0px; font-weight:bold; text-align: center;");
            __builder.AddMarkupContent(327, "\r\n                                    ");
            __builder.AddContent(328, 
#nullable restore
#line 174 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                     contTypeE

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(329, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(330, "\r\n\r\n                                ");
            __builder.OpenElement(331, "td");
            __builder.AddAttribute(332, "style", "padding-left:0; padding-right:0; padding-bottom:0px; padding-top:0px; font-weight:bold; text-align: center;");
            __builder.AddMarkupContent(333, "\r\n                                    ");
            __builder.AddContent(334, 
#nullable restore
#line 178 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                                     contTypeD

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(335, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(336, "\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(337, "\r\n");
#nullable restore
#line 182 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(338, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(339, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(340, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(341, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(342, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(343, "\r\n");
#nullable restore
#line 188 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\Attendance.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
