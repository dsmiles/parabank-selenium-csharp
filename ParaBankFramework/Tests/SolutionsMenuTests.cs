using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParaBankFramework.Navigation;
using ParaBankFramework.Pages;
using ParaBankFramework.Selenium;

namespace ParaBankFramework.Tests
{
    [TestClass]
    public class SolutionsMenuTests : BaseTest
    {
        // TODO - Refactor the repeated code and variables to [TestInitialize] method

        [TestMethod]
        public void SolutionsMenu_Goto_About_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            // Act
            var aboutPage = homePage.Menus.Solutions.About();

            // Assert
            Assert.IsTrue(aboutPage.IsAt(), "Not at About Us page");
        }

        [TestMethod]
        public void SolutionsMenu_Goto_Services_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            // Act
            var servicesPage = homePage.Menus.Solutions.Services();

            // Assert
            Assert.IsTrue(servicesPage.IsAt(), "Not at Services page");
        }

        [TestMethod]
        public void SolutionsMenu_Goto_Products_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            // Act
            var productsPage = homePage.Menus.Solutions.Products();

            // Assert
            Assert.IsTrue(productsPage.IsAt(), "Not at ParaSoft Products page");
        }

        [TestMethod]
        public void SolutionsMenu_Goto_Locations_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            // Act
            var locationsPage = homePage.Menus.Solutions.Locations();

            // Assert
            Assert.IsTrue(locationsPage.IsAt(), "Not at ParaSoft Locations page");
        }

        [TestMethod]
        public void SolutionsMenu_Goto_Admin_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            // Act
            var adminPage = homePage.Menus.Solutions.Admin();
            
            // Assert
            Assert.IsTrue(adminPage.IsAt(), "Not at Administration page");
        }
    }
}
