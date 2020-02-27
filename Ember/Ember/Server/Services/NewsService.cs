using Ember.Server.Data;
using Ember.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ember.Server.Services
{
    public class NewsService : INewsService
    {
        private readonly ApplicationDbContext context;

        public NewsService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IQueryable<NewsPost> GetAll() => context.Posts;

        public async Task<NewsPost> GetById(int id) => await context.Posts.FindAsync(id);

        public async Task<NewsPost> AddAsync(NewsPost post)
        {
            if (post == null)
            {
                throw new ArgumentNullException(nameof(post));
            }

            var saved = await context.Posts.AddAsync(post);

            await context.SaveChangesAsync()
                .ConfigureAwait(true);

            return saved.Entity as NewsPost;
        }
    }
}
