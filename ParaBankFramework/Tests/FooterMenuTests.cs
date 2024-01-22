using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParaBankFramework.Pages;
using ParaBankFramework.Selenium;

namespace ParaBankFramework.Tests
{
    [TestClass]
    public class FooterMenuTests : BaseTest
    {
        // TODO - Refactor the repeated code and variables to [TestInitialize] method

        [TestMethod]
        public void FooterMenu_Goto_Home_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            // Act
            homePage.Menus.Footer.Home();

            // Assert
            Assert.IsTrue(homePage.IsAt(), "Not at home page");
        }

        [TestMethod]
        public void FooterMenu_Goto_About_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            // Act
            var aboutPage = homePage.Menus.Footer.About();

            // Assert
            Assert.IsTrue(aboutPage.IsAt(), "Not at about us page");
        }

        [TestMethod]
        public void FooterMenu_Goto_Services_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            // Act
            var servicesPage = homePage.Menus.Footer.Services();

            // Assert
            Assert.IsTrue(servicesPage.IsAt(), "Not at services page");
        }

        [TestMethod]
        public void FooterMenu_Goto_Products_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            // Act
            var productsPage = homePage.Menus.Footer.Products();

            // Assert
            Assert.IsTrue(productsPage.IsAt(), "Not at parasoft products page");
        }

        [TestMethod]
        public void FooterMenu_Goto_Locations_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            // Act
            var locationsPage = homePage.Menus.Footer.Locations();
            
            // Assert
            Assert.IsTrue(locationsPage.IsAt(), "Not at parasoft locations page");
        }

        [TestMethod]
        public void FooterMenu_Goto_Forum_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            // Act
            var forumPage = homePage.Menus.Footer.Forum();

            // Assert
            Assert.IsTrue(forumPage.IsAt(), "Not at user forum page");
        }

        [TestMethod]
        public void FooterMenu_Goto_SiteMap_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            // Act
            var siteMapPage = homePage.Menus.Footer.SiteMap();

            // Assert
            Assert.IsTrue(siteMapPage.IsAt(), "Not at site map page");
        }

        [TestMethod]
        public void FooterMenu_Goto_Contact_Page_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            // Assert
            var contactPage = homePage.Menus.Footer.Contact();

            // Assert
            Assert.IsTrue(contactPage.IsAt(), "Not at contact us page");
        }
    }
}
