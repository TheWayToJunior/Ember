#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Shared\NewsCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd02d1494a646d7b9bc75c4d47b72c96c18c9c3"
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
#line 12 "D:\С#\.NET Core\Ember\Ember\Client\_Imports.razor"
using BlazorComponentUtilities;

#line default
#line hidden
#nullable disable
    public partial class NewsCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-sm-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "news-card-img");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "class", "img-responsive");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\Shared\NewsCard.razor"
                                              ImageSrc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "news-content");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<span class=\"news-lable\">News</span>\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "news-meta");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "time");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "#");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.AddMarkupContent(27, "<i class=\"material-icons\">\r\n                            query_builder\r\n                        </i>\r\n                        ");
            __builder.AddContent(28, 
#nullable restore
#line 16 "D:\С#\.NET Core\Ember\Ember\Client\Shared\NewsCard.razor"
                         Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddMarkupContent(31, "<a href=\"#\">Подробнее</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "h2");
            __builder.AddAttribute(35, "class", "news-header");
            __builder.AddContent(36, 
#nullable restore
#line 21 "D:\С#\.NET Core\Ember\Ember\Client\Shared\NewsCard.razor"
                                     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "p");
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.AddContent(40, 
#nullable restore
#line 23 "D:\С#\.NET Core\Ember\Ember\Client\Shared\NewsCard.razor"
                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\С#\.NET Core\Ember\Ember\Client\Shared\NewsCard.razor"
       
    public int Id { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string ImageSrc { get; set; }

    [Parameter]
    public DateTime Date { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
