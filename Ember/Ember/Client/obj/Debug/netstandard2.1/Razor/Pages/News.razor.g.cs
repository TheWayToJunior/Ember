#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9947bb71cf50c3e5a1e8b7084f82eef2fe4f8320"
// <auto-generated/>
#pragma warning disable 1591
namespace Ember.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/news")]
    public partial class News : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddAttribute(4, "data-aos", true);
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "\r\n\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "news-category");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "filter-ul");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "li");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "href", "news");
            __builder.AddAttribute(19, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n                            ");
                __builder2.AddMarkupContent(22, "<span>Все</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "li");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "href", "#");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.AddMarkupContent(31, "<span>Мироприятия</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "li");
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "href", "#");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.AddMarkupContent(40, "<span>Ремонт</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "li");
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
            __builder.AddAttribute(46, "href", "#");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.AddMarkupContent(49, "<span>Экология</span>\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 33 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                 foreach (var item in posts)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                    ");
            __builder.OpenComponent<Ember.Client.Shared.NewsCard>(58);
            __builder.AddAttribute(59, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 35 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                                     item.Time

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "ImageSrc", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                                                           item.ImageSrc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                                                                                  item.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "span");
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.AddContent(66, 
#nullable restore
#line 37 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                             item.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 40 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\С#\.NET Core\Ember\Ember\Client\Pages\News.razor"
       
    void foo() { }

    NewsPost[] posts =
    {
        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-9.userapi.com/c850128/v850128254/1d36a9/B54sYaowd5E.jpg",

            Title= "Об итогах ремонтного периода.",

            Description = "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были" +
                           " разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний"

        },

        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-28.userapi.com/c204516/v204516299/3b411/0qjhwQo15mw.jpg",

            Title= "Внимание произвадятся работы!!!",

            Description = "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были"+
                        "разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний"+
                        "период 2019-2020 годов, выполнение которых обеспечит гарантированный пуск и бесперебойную"
        },

        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-26.userapi.com/c206624/v206624328/1cfc1/QhLJ8tTkLC8.jpg",

            Title= "Инвестиционная программа 2019 года",

            Description = "В рамках инвестиционной программы 2019 года СПП \"Уголек\" ГП \"Донбасстеплоэнерго\""+
                        " выполнило ряд мероприятий по ремонту котельных. Котельная N 3 - замена котлов, монтаж"+
                        " системы водоочистки, установка дымовой трубы."

        },

        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-11.userapi.com/c857016/v857016695/75e15/jvemse0yWlE.jpg",

            Title= "Об итогах ремонтного периода.",

            Description = "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были" +
                           " разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний" +
                           " период 2019-2020 годов, выполнение которых обеспечит гарантированный пуск и бесперебойную"

        },

        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-60.userapi.com/c850636/v850636790/1ff3b2/R0pcwT1oVsw.jpg",

            Title= "Внимание произвадятся работы!!!",

            Description = "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были"+
                        "разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний"+
                        "период 2019-2020 годов, выполнение которых обеспечит гарантированный пуск и бесперебойную"
        },

        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-28.userapi.com/c854224/v854224084/12aa7f/aJlUY851MCw.jpg",

            Title= "Инвестиционная программа 2019 года",

            Description = "В рамках инвестиционной программы 2019 года СПП \"Уголек\" ГП \"Донбасстеплоэнерго\""+
                        " выполнило ряд мероприятий по ремонту котельных. Котельная N 3 - замена котлов, монтаж"+
                        " системы водоочистки, установка дымовой трубы."

        },

        new NewsPost
        {
            Time = DateTime.Now,

            ImageSrc="https://sun9-35.userapi.com/c851028/v851028124/196804/0j89FAqJ5Wg.jpg",

            Title= "Об итогах ремонтного периода.",

            Description = "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были" +
                           " разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний" +
                           " период 2019-2020 годов, выполнение которых обеспечит гарантированный пуск и бесперебойную"

        },
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591