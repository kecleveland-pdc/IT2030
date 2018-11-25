using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore.Controllers;
using System.Web.Mvc;
using MovieStore.Models;
using System.Collections.Generic;

namespace MovieStore.Tests.Controllers
{
    [TestClass]
    public class MovieStoreControllerTest
    {
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
    }
}
