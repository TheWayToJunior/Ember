using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ember.Client.Helpers
{
    public static class JsHelper
    {
        public static ValueTask<bool> ScrollToElementId(this IJSRuntime JSRuntime, string elementId)
        {
            return JSRuntime.InvokeAsync<bool>("scrollToElementId", elementId);
        }

        public static async Task IndexInit(this IJSRuntime JSRuntime)
        {
            await JSRuntime.InvokeVoidAsync("indexInit");
        }

        public static async Task InitMap(this IJSRuntime JSRuntime)
        {
            await JSRuntime.InvokeVoidAsync("initMap");
        }
    }
}
