using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ember.Server.Helpers
{
    public static class HttpContextExtensions
    {
        public static void InsertPaginationsPerPage<T>(this HttpContext httpContext, IEnumerable<T> enumerable, int quantityPerPage)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            double count = enumerable.Count();
            double pageQuantity = Math.Ceiling(count / quantityPerPage);

            httpContext.Response.Headers.Add("pageQuantity", pageQuantity.ToString());
        }
    }
}
