using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParaBankFramework.Pages;
using ParaBankFramework.Selenium;

namespace ParaBankFramework.Tests
{
    [TestClass]
    public class RegisterTests : BaseTest
    {
        // TODO - Refactor the repeated code and variables to [TestInitialize] method

        [TestMethod]
        public void Register_CanRegisterNewCustomer_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            var registerPage = homePage.ClickRegister();
            registerPage.Goto();
            
            // Act
            var customerCreatedPage = registerPage.RegisterNewCustomer();

            // Assert
            Assert.IsTrue(customerCreatedPage.IsAt(), "Not at Customer Created page");
            Assert.IsTrue(customerCreatedPage.State.IsLoggedInAsLastRegisteredCustomer(), "Customer not registered successfully");
        }

        [TestMethod]
        public void Register_CanRegisterNewCustomerAndLogIn_ResultSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            var registerPage = homePage.ClickRegister();     
            registerPage.Goto();    
            
            var customerCreatedPage = registerPage.RegisterNewCustomer();
            homePage = customerCreatedPage.Menus.AccountServices.LogOut();
            
            var loginPage = homePage.Login();
            loginPage.Goto();

            // Act
            var accountOverviewPage = loginPage.LogInAsLastRegisteredCustomer();

            // Assert
            Assert.IsTrue(accountOverviewPage.State.IsLoggedInAsLastRegisteredCustomer(), "Cannot login as last registered customer");
        }

        [TestMethod]
        public void Register_CanRegisterNewCustomerAndLogout_ResultSuccess()
        {
            // Arrange
            var registerPage = new RegisterPage(Browser.Driver);
            registerPage.Goto();

            var customerCreatedPage = registerPage.RegisterNewCustomer();

            // Act
            var homePage = customerCreatedPage.Menus.AccountServices.LogOut();

            // Assert - verify customer can log out
            Assert.IsFalse(homePage.State.IsLoggedIn(), "Customer not logged out");
        }
    }
}


