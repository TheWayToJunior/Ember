#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Intro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa76aa18db0febda31e368e5d06f517b68191f70"
// <auto-generated/>
#pragma warning disable 1591
namespace Ember.Client.Shared.Main
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
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Main;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Main.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using BlazorComponentUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Intro.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
#line 10 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Intro.razor"
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
#line 12 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Intro.razor"
             ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.AddMarkupContent(15, @"<div class=""banner-buttom"">
                        <a class=""btn btn-solid waves-effect"" href=""account"">
                            <i class=""material-icons icon"">
                                supervisor_account
                            </i>
                            Личный кабинет
                        </a>
                    </div>
                ");
            }
            ));
            __builder.AddAttribute(16, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "banner-buttom");
                __builder2.AddMarkupContent(20, "\r\n                        ");
                __builder2.OpenElement(21, "a");
                __builder2.AddAttribute(22, "class", "btn btn-solid waves-effect");
                __builder2.AddAttribute(23, "href", "javascript: void(0)");
                __builder2.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Intro.razor"
                                                                                                     () => Modal.Show<Auth.Login>("Login")

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.AddMarkupContent(26, "<i class=\"material-icons icon\">\r\n                                supervisor_account\r\n                            </i>\r\n                            Личный кабинет\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "scroll-indicator");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Intro.razor"
                                                    () => JSRuntime.ScrollToElementId(BodyId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                <span></span>\r\n                <span></span>\r\n                <span></span>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Intro.razor"
       
    [Parameter]
    public string BodyId { get; set; }

    [Parameter]
    public string ImgSource { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
