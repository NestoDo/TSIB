#pragma checksum "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efcb6079e3f02d2c6cd891529def66516de15e26"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Empleados</h4>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n                Nombre\r\n            </label>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-4");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "Input");
            __builder.AddAttribute(15, "id", "firstName");
            __builder.AddAttribute(16, "class", "form-control form-control-sm");
            __builder.AddAttribute(17, "placeholder", "Nombre");
            __builder.AddAttribute(18, "maxlength", "50");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                                                                                                             SearchFirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchFirstName = __value, SearchFirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n            ");
            __builder.AddMarkupContent(23, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n                Apellido\r\n            </label>\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-sm-4");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "id", "lastName");
            __builder.AddAttribute(29, "class", "form-control form-control-sm");
            __builder.AddAttribute(30, "placeholder", "Apellido");
            __builder.AddAttribute(31, "maxlength", "50");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                                                                                                              SearchLastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchLastName = __value, SearchLastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group row");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.AddMarkupContent(40, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n                Estatus\r\n            </label>\r\n\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-sm-4");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "select");
            __builder.AddAttribute(45, "class", "form-control form-control-sm");
            __builder.AddAttribute(46, "name", "Estatus");
            __builder.AddAttribute(47, "id", "status");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                                                                                                     SearchIsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchIsActive = __value, SearchIsActive));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "true");
            __builder.AddContent(53, "Activo");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "false");
            __builder.AddContent(57, "Inactivo");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "todo");
            __builder.AddContent(61, "Todo");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n            ");
            __builder.AddMarkupContent(65, "<div class=\"col-sm-6\">\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-group row d-flex justify-content-between");
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "btn btn-primary btn-sm");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                                                                 EmployeeSearch_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(75, "<span class=\"oi oi-magnifying-glass\" aria-hidden=\"true\"></span> Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(77);
            __builder.AddAttribute(78, "href", "/employeeedit");
            __builder.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(80, "\r\n                    ");
                __builder2.AddMarkupContent(81, "<button class=\"btn btn-primary btn-sm\"><span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Agregar</button>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n");
#nullable restore
#line 53 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 56 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "    ");
            __builder.OpenElement(89, "table");
            __builder.AddAttribute(90, "class", "table table-hover table-sm table-bordered");
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.AddMarkupContent(92, @"<thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nombre</th>
                <th scope=""col"">Apellido</th>
                <th scope=""col"">Telefono</th>
                <th scope=""col"">Departamento</th>
                <th scope=""col"">Estatus</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(93, "tbody");
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 73 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
             foreach (var employee in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                ");
            __builder.OpenElement(96, "tr");
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.OpenElement(98, "th");
            __builder.AddAttribute(99, "scope", "row");
            __builder.AddContent(100, 
#nullable restore
#line 76 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                                     employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenElement(102, "td");
            __builder.AddContent(103, 
#nullable restore
#line 77 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                         employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                    ");
            __builder.OpenElement(105, "td");
            __builder.AddContent(106, 
#nullable restore
#line 78 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                    ");
            __builder.OpenElement(108, "td");
            __builder.AddContent(109, 
#nullable restore
#line 79 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                         employee.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.OpenElement(111, "td");
            __builder.AddContent(112, 
#nullable restore
#line 80 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                         employee.Department.LongDesc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 81 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                     if (@employee.IsActive)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "                        ");
            __builder.OpenElement(115, "td");
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                                                                             (() => ChangeStatus_Click(employee))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(119, "Activo ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 84 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "                        ");
            __builder.OpenElement(122, "td");
            __builder.OpenElement(123, "button");
            __builder.AddAttribute(124, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(125, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                                                                            (() => ChangeStatus_Click(employee))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(126, "Inactivo");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 88 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(128, "\r\n                    ");
            __builder.OpenElement(129, "td");
            __builder.OpenElement(130, "a");
            __builder.AddAttribute(131, "href", 
#nullable restore
#line 91 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
                                   $"/employeeedit/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(132, "class", "btn btn-primary btn-sm");
            __builder.AddContent(133, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n");
#nullable restore
#line 93 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(136, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
#nullable restore
#line 96 "C:\Users\omare\source\repos\TSIB\TSIB\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591