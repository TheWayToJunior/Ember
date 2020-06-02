using Ember.Server;
using Ember.Server.Controllers;
using Ember.Shared;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Ember.XUnitTest
{
    public class TestNewsController
    {
        private IQueryable<NewsPost> GetPosts()
        {
            return new List<NewsPost>()
            {
                new NewsPost
                {
                    Id = 1,
                    Time = DateTime.Now,
                    Category = CategoryMode.Repair
                },
                 new NewsPost
                {
                    Id = 2,
                    Time = DateTime.Now,
                    Category = CategoryMode.Events
                },
                  new NewsPost
                {
                    Id = 3,
                    Time = DateTime.Now,
                    Category = CategoryMode.Ecology
                },
            }
            .AsQueryable<NewsPost>();
        }

        [Fact]
        public async Task GetAll_ReturnsOkResult()
        {
            // Arrange
            var mock = new Mock<INewsService>();

            mock.Setup(repo => repo.GetAll()).Returns(GetPosts());

            NewsController controller = new NewsController(mock.Object);

            // Act
            var okResult = await controller.GetAll(new Pagination());

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public async Task GetAll_ReturnsAllItems()
        {
            // Arrange
            var mock = new Mock<INewsService>();

            mock.Setup(repo => repo.GetAll()).Returns(GetPosts());

            NewsController controller = new NewsController(mock.Object);

            var pagination = new Pagination() { QuantityPerPage = 3};

            // Act
            var okResult = (await controller.GetAll(pagination)).Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<NewsPost>>(okResult.Value);

            Assert.Equal(pagination.QuantityPerPage, items.Count);
        }

        [Fact]
        public async Task GetAll_ReturnsAllItemsByCategory()
        {
            // Arrange

            int countItemsByCategoryPerPage = 1;
            var mock = new Mock<INewsService>();

            mock.Setup(repo => repo.GetAll()).Returns(GetPosts());

            NewsController controller = new NewsController(mock.Object);

            // Act
            var okResult = (await controller.GetAll(new Pagination() { QuantityPerPage = 1, Page = 1}, CategoryMode.Repair))
                .Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<NewsPost>>(okResult.Value);

            Assert.Equal(countItemsByCategoryPerPage, items.Count);
        }

        [Fact]
        public async Task GetById__ReturnsOkResul()
        {
            // Arrange
            int testId = 1;

            var mock = new Mock<INewsService>();

            mock.Setup(repo => repo.GetById(testId)).Returns(Task.Run(() => GetPosts().First(n => n.Id == testId)));

            NewsController controller = new NewsController(mock.Object);

            // Act
            var okResult = await controller.Get(testId);

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public async Task GetById_ReturnsItem()
        {
            // Arrange
            int testId = 1;

            var mock = new Mock<INewsService>();

            mock.Setup(repo => repo.GetById(testId)).Returns(Task.Run(() => GetPosts().First(n => n.Id == testId)));

            NewsController controller = new NewsController(mock.Object);

            // Act
            var okResult = (await controller.Get(testId)).Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<NewsPost>(okResult.Value);

            Assert.Equal(testId, items.Id);
        }

        [Fact]
        public async Task GetById_ReturnsNotFoundResult()
        {
            // Arrange
            int testId = 5;

            var mock = new Mock<INewsService>();

            mock.Setup(repo => repo.GetById(testId)).Returns(Task.Run(() => GetPosts().First(n => n.Id == testId)));

            NewsController controller = new NewsController(mock.Object);

            // Act
            var result = await controller.Get(testId);

            // Assert
            var item = Assert.IsType<NotFoundResult>(result.Result);
        }
    }
}
