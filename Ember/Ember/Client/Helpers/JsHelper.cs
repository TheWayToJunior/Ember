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

        public static async ValueTask IndexInit(this IJSRuntime JSRuntime)
        {
            await JSRuntime.InvokeVoidAsync("indexInit");
        }

        public static async ValueTask InitMap(this IJSRuntime JSRuntime)
        {
            await JSRuntime.InvokeVoidAsync("initMap");
        }

        public static async ValueTask SetInLocalStorage(this IJSRuntime JSRuntime, string key, string value)
        {
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
        }

        public static async ValueTask<string> GetFromLocalStorage(this IJSRuntime JSRuntime, string key)
        {
            return await JSRuntime.InvokeAsync<string>("localStorage.getItem", key);
        }

        public static async ValueTask RemoveItem(this IJSRuntime JSRuntime, string key)
        {
            await JSRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }
    }
}
