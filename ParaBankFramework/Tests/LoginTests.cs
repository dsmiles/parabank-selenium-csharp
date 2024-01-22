using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParaBankFramework.Pages;
using ParaBankFramework.Selenium;

namespace ParaBankFramework.Tests
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        // TODO - Refactor the repeated code and variables to [TestInitialize] method

        [TestMethod]
        public void Login_WithValidCredentials_ResultSuccess()
        {
            // Arrange
            var loginPage = new LoginPage(Browser.Driver);
            loginPage.Goto();

            // Act - login as default customer
            var accountsOverview = loginPage.LoginAs("john", "demo");

            // Assert - 
            Assert.IsTrue(accountsOverview.IsAt(), "Not at Accounts Overview Page");
            Assert.IsTrue(accountsOverview.State.IsLoggedInAs("John", "Smith"), "Welcome message does not match logged on Customer");
        }

        [TestMethod]
        public void Login_WithBadUsername_ResultFailure()
        {
            // Arrange
            var loginPage = new LoginPage(Browser.Driver);
            loginPage.Goto();

            // Act
            var errorPage = loginPage.LoginAsInvalid("qwerty", "demo");

            // Assert
            Assert.IsTrue(errorPage.IsAt(), "Not at bad credentials error page");
            Assert.IsTrue(errorPage.IsInvalidCredentials(), "Did not get username and password error");  
        }

        [TestMethod]
        public void Login_WithBadPassword_ResultFailure()
        {
            // Arrange
            var loginPage = new LoginPage(Browser.Driver);
            loginPage.Goto();      

            // Act
            var errorPage = loginPage.LoginAsInvalid("john", "password");

            // Assert
            Assert.IsTrue(errorPage.IsAt(), "Not at bad credentials error page");
            Assert.IsTrue(errorPage.IsInvalidCredentials(), "Did not get username and password error");
        }

        [TestMethod]
        public void Login_WithBlankUserName_ResultFailure()
        {
            // Arrange
            var loginPage = new LoginPage(Browser.Driver);
            loginPage.Goto();

            // Act
            var errorPage = loginPage.LoginAsInvalid("", "demo");

            // Assert
            Assert.IsTrue(errorPage.IsAt(), "Not at bad credentials error page");
            Assert.IsTrue(errorPage.IsMissingCredentials(), "Did not get missing username and password error");
        }

        [TestMethod]
        public void Login_WithBlankPassword_ResultFailure()
        {
            // Arrange
            var loginPage = new LoginPage(Browser.Driver);
            loginPage.Goto();

            // Act
            var errorPage = loginPage.LoginAsInvalid("john", "");

            // Assert
            Assert.IsTrue(errorPage.IsAt(), "Not at bad credentials error page");
            Assert.IsTrue(errorPage.IsMissingCredentials(), "Did not get missing username and password error");
        }

        [TestMethod]
        public void Login_WithBlankValues_ResultFailure()
        {
            // Arrange
            var loginPage = new LoginPage(Browser.Driver);
            loginPage.Goto();

            // Act
            var errorPage = loginPage.LoginAsInvalid("", "");

            // Assert
            Assert.IsTrue(errorPage.IsAt(), "Not at bad credentials error page");
            Assert.IsTrue(errorPage.IsMissingCredentials(), "Did not get missing username and password error");
        }

        [TestMethod]
        public void Login_UserCanLogout_ResultSuccess()
        {
            // Arrange
            var loginPage = new LoginPage(Browser.Driver);
            loginPage.Goto();

            var accountOverviewPage = loginPage.LoginAsDefaultCustomer();

            // Act - Now logout
            var homePage = accountOverviewPage.Menus.AccountServices.LogOut();

            // Assert - We should be returned to home page
            Assert.IsTrue(homePage.IsAt(), "Not at home page");
            Assert.IsFalse(homePage.State.IsLoggedIn(), "Customer stil logged in");
        }
    }
}