#pragma checksum "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc61ba2687a916c106caf5ae789154e5fb757448"
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
    public partial class Category : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "filter-ul");
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 3 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor"
     foreach (var link in links)
	{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "li");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor"
                         async () => await SelectedLinkInternal(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", 
#nullable restore
#line 7 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor"
                        link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 8 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor"
                       link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\t \r\n");
#nullable restore
#line 11 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\С#\.NET Core\Ember\Ember\Client\Shared\Category.razor"
       
    [Parameter]
    public CategoryMode CurrentCategory { get; set; }

    [Parameter]
    public IEnumerable<(string text, CategoryMode category)> Links { get; set; }

    [Parameter]
    public EventCallback<CategoryMode> SelectedLink { get; set; }

    List<LinkModel> links;

    protected override void OnParametersSet()
    {
        LoadPages();
    }

    private async Task SelectedLinkInternal(LinkModel link)
    {
        if (link.Active)
        {
            return;
        }

        await SelectedLink.InvokeAsync(link.Category);
    }

    private void LoadPages()
    {
        links = new List<LinkModel>();

        foreach (var linck in Links)
        {
            links.Add(new LinkModel(linck.text, linck.category) 
            { 
                Active = CurrentCategory == linck.Item2
            });
        }
    }

    class LinkModel
    {
        public LinkModel(string text, CategoryMode сategory)
        {
            Category = сategory;
            Text = text;
        }

        public string Text { get; set; }

        public CategoryMode Category{ get; set; }

        public bool Active { get; set; } = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
