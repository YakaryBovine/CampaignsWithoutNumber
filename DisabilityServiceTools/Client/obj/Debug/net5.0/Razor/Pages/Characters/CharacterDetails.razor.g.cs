#pragma checksum "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adcaa0e87411c5613f2e75ee73e438de3cd9697b"
// <auto-generated/>
#pragma warning disable 1591
namespace CampaignsWithoutNumber.Client.Pages.Characters
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using CampaignsWithoutNumber.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
using CampaignsWithoutNumber.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/characterdetails/{Id}")]
    public partial class CharacterDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardHeader>(3);
                __builder2.AddAttribute(4, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudText>(6);
                    __builder3.AddAttribute(7, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
                           Typo.h4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Class", "mb-4");
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 8 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
__builder4.AddContent(10, Character.Name);

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(13);
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(16);
                    __builder3.AddAttribute(17, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 12 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
                       Typo.body1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(19, "\r\n            ");
                        __builder4.AddMarkupContent(20, "<strong>Name:</strong> ");
#nullable restore
#line 13 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
__builder4.AddContent(21, Character.Name);

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(22, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(24);
                    __builder3.AddAttribute(25, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 15 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
                       Typo.body1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(27, "\r\n            ");
                        __builder4.AddMarkupContent(28, "<strong>Class:</strong> ");
#nullable restore
#line 16 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
__builder4.AddContent(29, Character.ClassName);

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(30, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(32);
                    __builder3.AddAttribute(33, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 18 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
                       Typo.body1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(35, "\r\n            ");
                        __builder4.AddMarkupContent(36, "<strong>Level:</strong> ");
#nullable restore
#line 19 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
__builder4.AddContent(37, Character.Level);

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(38, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(40);
                    __builder3.AddAttribute(41, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 21 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
                       Typo.body1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(43, "\r\n            ");
                        __builder4.AddMarkupContent(44, "<strong>Hit points:</strong> ");
#nullable restore
#line 22 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
__builder4.AddContent(45, Character.HitPoints);

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(46, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(48);
                    __builder3.AddAttribute(49, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 24 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
                       Typo.body1

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(51, "\r\n            ");
                        __builder4.AddMarkupContent(52, "<strong>Attack bonus:</strong> ");
#nullable restore
#line 25 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
__builder4.AddContent(53, Character.AttackBonus);

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(54, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Zak\RiderProjects\CampaignsWithoutNumber\DisabilityServiceTools\Client\Pages\Characters\CharacterDetails.razor"
       
    private Character Character { get; set; } = new();

    [Parameter]
    public string Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Character = await _httpClient.GetFromJsonAsync<Character>($"api/character/details/{Id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
    }
}
#pragma warning restore 1591
