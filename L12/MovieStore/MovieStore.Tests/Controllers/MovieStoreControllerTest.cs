using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Controllers;
using System.Web.Mvc;
using System.Net;
using MovieStore.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;

namespace MovieStore.Tests.Controllers
{
    [TestClass]
    public class MovieStoreControllerTest
    {
        //INDEX
        [TestMethod]
        public void MovieStore_Index_TestView()
        {
            //Arrange
            MoviesController controller = new MoviesController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        //CREATE
        [TestMethod]
        public void MovieStore_IndexRedirect_Success()
        {
            //Arrange
            MoviesController controller = new MoviesController();

            //Act
            var result = controller.IndexRedirect(1) as RedirectToRouteResult;

            //Assert
            Assert.AreEqual("Create", result.RouteValues["action"]);
            Assert.AreEqual("HomeController", result.RouteValues["controller"]);

        }

        //EDIT
        [TestMethod]
        public void MovieStore_Edit_TestView()
        {
            //Arrange
            //Step 1
            Mock<MovieStoreDbContext> mockContext = new Mock<MovieStoreDbContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            //step 2
            //use list instead of the db
            var list = new List<Movie>
            {
                new Movie() {MovieId=1, Title="Jaws"},
                new Movie() {MovieId=2, Title="Jurassic Park" }
            }.AsQueryable();

            //Step3 connect dbset and list
            mockSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(list.ElementType);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(list.Expression);

            //step4 connect dbset to context
            mockContext.Setup(db => db.Movies).Returns(mockSet.Object);

            //step5 send the mock context to controller
            //Controller neeeds a mock object
            MoviesController controller = new MoviesController(mockContext.Object);

            //Act
            ViewResult result = controller.ListFromDb() as ViewResult;
            List<Movie> resultModel = result.Model as List<Movie>;

            //Assert
            Assert.IsNotNull(result);
        }

        //DELETE
        [TestMethod]
        public void MovieStore_Delete_TestView()
        {
            //Arrange
            //Step 1
            Mock<MovieStoreDbContext> mockContext = new Mock<MovieStoreDbContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();

            //step 2
            //use list instead of the db
            var list = new List<Movie>
            {
                new Movie() {MovieId=1, Title="Jaws"},
                new Movie() {MovieId=2, Title="Jurassic Park" }
            }.AsQueryable();

            //Step3 connect dbset and list
            mockSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(list.ElementType);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(list.Expression);

            //step4 connect dbset to context
            mockContext.Setup(db => db.Movies).Returns(mockSet.Object);

            //step5 send the mock context to controller
            //Controller neeeds a mock object
            MoviesController controller = new MoviesController(mockContext.Object);

            //Act
            ViewResult result = controller.ListFromDb() as ViewResult;
            List<Movie> resultModel = result.Model as List<Movie>;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MovieStore_ListOfMovies()
        {
            //Arrange
            MoviesController controller = new MoviesController();

            //Act
            var result = controller.ListOfMovies();

            //Assert
            Assert.AreEqual("Terminator 1", result[0].Title);
            Assert.AreEqual("Terminator 2", result[1].Title);
            Assert.AreEqual("Terminator 3", result[2].Title);
        }

        [TestMethod]
        public void MovieStore_IndexRedirect_BadRequest()
        {
            //Arrange
            MoviesController controller = new MoviesController();

            //Act
            var result = controller.IndexRedirect(0) as HttpStatusCodeResult;

            //Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, (HttpStatusCode) result.StatusCode);

        }

        [TestMethod]
        public void MovieStore_ListFromDb()
        {
            //Arrange
            //Step 1
            Mock<MovieStoreDbContext> mockContext = new Mock<MovieStoreDbContext>();
            Mock<DbSet<Movie>> mockSet = new Mock<DbSet<Movie>>();
  
            //step 2
            //use list instead of the db
            var list = new List<Movie>
            {
                new Movie() {MovieId=1, Title="Jaws"},
                new Movie() {MovieId=2, Title="Jurassic Park" }
            }.AsQueryable();

            //Step3 connect dbset and list
            mockSet.As<IQueryable<Movie>>().Setup(m => m.GetEnumerator()).Returns(list.GetEnumerator());
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Provider).Returns(list.Provider);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.ElementType).Returns(list.ElementType);
            mockSet.As<IQueryable<Movie>>().Setup(m => m.Expression).Returns(list.Expression);

            //step4 connect dbset to context
            mockContext.Setup(db => db.Movies).Returns(mockSet.Object);

            //step5 send the mock context to controller
            //Controller neeeds a mock object
            MoviesController controller = new MoviesController(mockContext.Object);
            
            //Act
            ViewResult result = controller.ListFromDb() as ViewResult;
            List<Movie> resultModel = result.Model as List<Movie>;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Jaws", resultModel[0].Title);
            Assert.AreEqual("Jurassic Park", resultModel[1].Title);
        }
    }
}
