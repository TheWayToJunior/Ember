using Ember.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ember.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<NewsPost> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            string descriotion = "Согласно Правил подготовки теплового хозяйства к отопительному сезону предприятием были" +
                                  " разработаны мероприятия по подготовке объектов теплоснабжения к работе в осеннее-зимний";

            builder.Entity<NewsPost>().HasData(
                    new NewsPost[]
                    {
                        new NewsPost
                        {
                            Id = 1,
                            Time = DateTime.Now,
                            ImageSrc="https://sun9-9.userapi.com/c850128/v850128254/1d36a9/B54sYaowd5E.jpg",
                            Title= "Об итогах ремонтного периода.",
                            Description = descriotion,
                            Category = CategoryMode.Repair
                        },

                        new NewsPost
                        {
                            Id = 2,
                            Time = DateTime.Now,
                            ImageSrc="https://sun9-28.userapi.com/c204516/v204516299/3b411/0qjhwQo15mw.jpg",
                            Title= "Внимание произвадятся работы!!!",
                            Description = descriotion + descriotion,
                            Category =  CategoryMode.Repair
                        },

                        new NewsPost
                        {
                            Id = 3,
                            Time = DateTime.Now,
                            ImageSrc="https://sun9-35.userapi.com/c851028/v851028124/196804/0j89FAqJ5Wg.jpg",
                            Title= "Инвестиционная программа 2019 года",
                             Description = descriotion,
                             Category =  CategoryMode.Ecology
                        },

                        new NewsPost
                        {
                            Id = 4,
                            Time = DateTime.Now,
                            ImageSrc="https://sun9-11.userapi.com/c857016/v857016695/75e15/jvemse0yWlE.jpg",
                            Title= "Об итогах ремонтного периода.",
                            Description = descriotion,
                            Category = CategoryMode.Events
                        },

                        new NewsPost
                        {
                            Id = 5,
                            Time = DateTime.Now,
                            ImageSrc="https://sun9-60.userapi.com/c850636/v850636790/1ff3b2/R0pcwT1oVsw.jpg",
                            Title= "Внимание произвадятся работы!!!",
                             Description = descriotion,
                            Category = CategoryMode.Events
                        },

                        new NewsPost
                        {
                            Id = 6,
                            Time = DateTime.Now,
                            ImageSrc="https://sun9-28.userapi.com/c854224/v854224084/12aa7f/aJlUY851MCw.jpg",
                            Title= "Инвестиционная программа 2019 года",
                             Description = descriotion,
                             Category = CategoryMode.Ecology
                        },

                        new NewsPost
                        {
                            Id = 7,
                            Time = DateTime.Now,
                            ImageSrc="https://sun9-26.userapi.com/c206624/v206624328/1cfc1/QhLJ8tTkLC8.jpg",
                            Title= "Об итогах ремонтного периода.",
                             Description = descriotion,
                            Category = CategoryMode.Events
                        }
                    });

            base.OnModelCreating(builder);
        }
    }
}
