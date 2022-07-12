using System;
using Xunit;
using SportsStore.Controllers;
using SportsStore.Models;
using SportsStore.Repository;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace SportsStore.Tests
{
    public class ProductTests
    {
        [Fact]
        public void IsControlDataNotNull()
        {
            //arrange             
            var mock = new Mock<IStoreRepository>();
            mock.SetupGet<IEnumerable<Product>>(m => m.Products).Returns(new Product[]{
                new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },
            }.AsQueryable());
            var homeController = new HomeController(mock.Object);
            //act 
            IEnumerable<Product> result =
                (homeController.Index() as ViewResult).ViewData.Model
                as IEnumerable<Product>;
            //assert
            Assert.NotNull(result);
        }


        //can paginate : 

        [Fact]
        public void CanPaginate()
        {
            //Arrange 
            var mock = new Mock<IStoreRepository>();
            mock.SetupGet(m => m.Products).Returns(
              (new Product[]{
                    new Product {ProductID = 1, Name = "P1"},
                    new Product {ProductID = 2, Name = "P2"},
                    new Product {ProductID = 3, Name = "P3"},
                    new Product {ProductID = 4, Name = "P4"},
                    new Product {ProductID = 5, Name = "P5"}
              }).AsQueryable()
            );
            var homeController = new HomeController(mock.Object);
            homeController.PageSize = 3;
            //Act 
            IEnumerable<Product> result = (homeController.Index(2) as ViewResult)?.Model as IEnumerable<Product>;            
            //Assert 
            Assert.Equal(2,result.Count());
        }
    }
}
