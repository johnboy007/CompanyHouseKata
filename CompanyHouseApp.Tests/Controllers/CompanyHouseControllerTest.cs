using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyHouseApp;
using CompanyHouseApp.Controllers;

namespace CompanyHouseApp.Tests.Controllers
{
    [TestClass]
    public class CompanyHouseControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new CompanyHouseController();

            // Act
            var result = controller.Index("radio") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        
    }
}
