using Ember.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ember.Server
{
    public interface INewsService
    {
        IEnumerable<NewsPost> GetAllNews();

        NewsPost GetNewsById(int id);
    }
}
