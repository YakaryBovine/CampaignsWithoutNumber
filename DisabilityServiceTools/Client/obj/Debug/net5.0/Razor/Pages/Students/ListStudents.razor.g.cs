#pragma checksum "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc2fe7bc4573b77d0964cb7c7d67748d82406c8e"
// <auto-generated/>
#pragma warning disable 1591
namespace DisabilityServiceTools.Client.Pages.Students
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#nullable restore
#line 1 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using DisabilityServiceTools.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\_Imports.razor"
using DisabilityServiceTools.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
using DisabilityServiceTools.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
using DisabilityServiceTools.Shared.RequestFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
using DisabilityServiceTools.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/liststudents")]
    public partial class ListStudents : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudTooltip>(0);
            __builder.AddAttribute(1, "Text", "Create Student");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudLink>(4);
                __builder2.AddAttribute(5, "Href", "/createStudent");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudFab>(8);
                    __builder3.AddAttribute(9, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                       Icons.Filled.Add

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                                Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 11 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                                                       Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(12, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __Blazor.DisabilityServiceTools.Client.Pages.Students.ListStudents.TypeInference.CreateMudTable_0(__builder, 15, 16, 
#nullable restore
#line 15 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                        new Func<TableState, Task<TableData<Student>>>(GetServerData)

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 16 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                 true

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 16 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                   Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 16 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 17 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                     25

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 18 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                       true

#line default
#line hidden
#nullable disable
            , 22, (__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudText>(24);
                __builder2.AddAttribute(25, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 20 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, "Students");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudSpacer>(29);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTextField<string>>(31);
                __builder2.AddAttribute(32, "OnDebounceIntervalElapsed", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 22 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                                 OnSearch

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(33, "Placeholder", "Search");
                __builder2.AddAttribute(34, "Adornment", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Adornment>(
#nullable restore
#line 22 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                                                                           Adornment.Start

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "AdornmentIcon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                      Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "IconSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 23 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                                                              Size.Small

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Class", "mt-0");
                __builder2.AddAttribute(38, "DebounceInterval", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 24 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                                                500

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n    ");
            }
            , 40, (__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(42);
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Student>>(44);
                    __builder3.AddAttribute(45, "SortLabel", "studentid");
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(47, "<b>Student ID</b>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(49);
                __builder2.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Student>>(51);
                    __builder3.AddAttribute(52, "SortLabel", "firstname");
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(54, "<b>First Name</b>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(56);
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTableSortLabel<Student>>(58);
                    __builder3.AddAttribute(59, "SortLabel", "surname");
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(61, "<b>Surname</b>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
            }
            , 63, (context) => (__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(65);
                __builder2.AddAttribute(66, "DataLabel", "Student ID");
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(68, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudLink>(69);
                    __builder3.AddAttribute(70, "Href", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                             $"studentdetails/{context.Id}"

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 33 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
__builder4.AddContent(72, context.StudentId);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(75);
                __builder2.AddAttribute(76, "DataLabel", "First Name");
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 35 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
__builder3.AddContent(78, context.FirstName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(80);
                __builder2.AddAttribute(81, "DataLabel", "Surname");
                __builder2.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 36 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
__builder3.AddContent(83, context.Surname);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n    ");
            }
            , 85, (__builder2) => {
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTablePager>(87);
                __builder2.AddAttribute(88, "PageSizeOptions", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 39 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                                         _pageSizeOption

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "RowsPerPageString", "Students per page");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n    ");
            }
            , 91, (__value) => {
#nullable restore
#line 17 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
                _table = __value;

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Zak\RiderProjects\DisabilityServiceTools\DisabilityServiceTools\Client\Pages\Students\ListStudents.razor"
       
    private MudTable<Student> _table;
    private StudentParameters _studentParameters = new StudentParameters();
    private readonly int[] _pageSizeOption = { 25, 50, 100 };

    [Inject]
    public IStudentClientRepository Repository { get; set; }

    private async Task<TableData<Student>> GetServerData(TableState state)
    {
        _studentParameters.PageSize = state.PageSize;
        _studentParameters.PageNumber = state.Page + 1;

        _studentParameters.OrderBy = state.SortDirection == SortDirection.Descending ?
            state.SortLabel + " desc" :
            state.SortLabel;

        var response = await Repository.GetStudents(_studentParameters);

        return new TableData<Student>
        {
            Items = response.Items,
            TotalItems = response.MetaData.TotalCount
        };
    }

    private void OnSearch(string searchTerm)
    {
        _studentParameters.SearchTerm = searchTerm;
        _table.ReloadServerData();
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.DisabilityServiceTools.Client.Pages.Students.ListStudents
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::MudBlazor.TableState, global::System.Threading.Tasks.Task<global::MudBlazor.TableData<T>>> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Int32 __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::System.Action<global::MudBlazor.MudTable<T>> __arg10)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "ServerData", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "RightAlignSmall", __arg3);
        __builder.AddAttribute(__seq4, "RowsPerPage", __arg4);
        __builder.AddAttribute(__seq5, "FixedHeader", __arg5);
        __builder.AddAttribute(__seq6, "ToolBarContent", __arg6);
        __builder.AddAttribute(__seq7, "HeaderContent", __arg7);
        __builder.AddAttribute(__seq8, "RowTemplate", __arg8);
        __builder.AddAttribute(__seq9, "PagerContent", __arg9);
        __builder.AddComponentReferenceCapture(__seq10, (__value) => { __arg10((global::MudBlazor.MudTable<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
