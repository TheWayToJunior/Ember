#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Shared\Intro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edccbd8cc30aa0e175c309eada6ec22672a8bcc9"
// <auto-generated/>
#pragma warning disable 1591
namespace Ember.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using BlazorComponentUtilities;

#line default
#line hidden
#nullable disable
    public partial class Intro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "intro");
            __builder.AddMarkupContent(2, "\r\n    <div class=\"filter\"></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "banner");
            __builder.AddAttribute(5, "style", " background-image:" + " url(\'" + (
#nullable restore
#line 5 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Intro.razor"
                                                        ImgSource

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "banner-content");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddContent(10, 
#nullable restore
#line 7 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Intro.razor"
             ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, @"<div class=""banner-buttom"">
                <a class=""btn btn-solid"" href=""#"">
                    <i class=""material-icons icon"">
                        supervisor_account
                    </i>
                    Личный кабинет
                </a>
            </div>
            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "scroll-indicator");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Intro.razor"
                                                    () => JSRuntime.ScrollToElementId(BodyId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(16, "\r\n                <span></span>\r\n                <span></span>\r\n                <span></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Intro.razor"
       
    [Parameter]
    public string BodyId { get; set; }

    [Parameter]
    public string ImgSource { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
