#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\ScrollLine.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88ac85598dc4de8f94126e555c3acc935ffae34"
// <auto-generated/>
#pragma warning disable 1591
namespace Ember.Client.Shared.Main.Components
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
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Main;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Main.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Shared.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Ember.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using BlazorComponentUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class ScrollLine : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "scroll-Line__block container");
            __builder.AddAttribute(2, "id", "line");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "line");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "line-scroll");
            __builder.AddAttribute(9, "style", "max-height:" + (
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\ScrollLine.razor"
                                                    maxHeight

#line default
#line hidden
#nullable disable
            ) + ";" + " height:" + " " + (
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\ScrollLine.razor"
                                                                        height

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", 
#nullable restore
#line 8 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\ScrollLine.razor"
                 ContentClassCss

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddContent(15, 
#nullable restore
#line 9 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\ScrollLine.razor"
         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<div class=\"dot\">\r\n            <div class=\"dot-scroll\"></div>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Main\Components\ScrollLine.razor"
       
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string ContentClassCss { get; set; }

    private DotNetObjectReference<Line> objRef;
    private Line scrollLine;

    private string maxHeight;
    private string height;

    protected override void OnInitialized()
    {
        scrollLine = new Line();

        scrollLine.Changed += () => ChangedComponent();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            objRef = DotNetObjectReference.Create(scrollLine);

            await JsRuntime.InvokeVoidAsync("scrollLineOn", objRef, "line");
        }
    }

    private void ChangedComponent()
    {
        maxHeight = scrollLine.MaxHeight.ToString().Replace(',', '.') + "px";

        height = scrollLine.Height.ToString().Replace(',', '.') + "px";

        StateHasChanged();
    }

    public async void Dispose()
    {
        await JsRuntime.InvokeVoidAsync("scrollLineOff");
        objRef?.Dispose();
    }

    public class Line
    {
        public event Action Changed;

        public decimal Height { get; private set; }
        public decimal MaxHeight { get; private set; }

        [JSInvokable]
        public void SetHeight(JsonElement height)
        {
            Height = height.GetDecimal();
            Changed?.Invoke();
        }

        [JSInvokable]
        public void SetMaxHeight(JsonElement maxHeight)
        {
            MaxHeight = maxHeight.GetDecimal();
            Changed?.Invoke();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
