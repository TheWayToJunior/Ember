using Ember.Server;
using Ember.Server.Controllers;
using Ember.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace Ember.XUnitTest
{
    public class TestNewsController
    {
        INewsService service;
        NewsController contriller;

        public TestNewsController()
        {
            service = new Server.Services.NewsService();
            contriller = new NewsController(service);
        }

        [Fact]
        public void GetAll_ReturnsOkResult()
        {
            // Act
            var okResult = contriller.GetAll();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetAll_ReturnsAllItems()
        {
            // Act
            var okResult = contriller.GetAll().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<NewsPost>>(okResult.Value);

            Assert.Equal(7, items.Count);
        }

        [Fact]
        public void GetById__ReturnsOkResul()
        {
            int testId = 1;

            // Act
            var okResult = contriller.Get(testId);

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetById_ReturnsAllItems()
        {
            int testId = 1;

            // Act
            var okResult = contriller.Get(testId).Result as OkObjectResult;

            // Assert
            var item = Assert.IsType<NewsPost>(okResult.Value);

            Assert.Equal(testId, item.Id);
        }
    }
}
