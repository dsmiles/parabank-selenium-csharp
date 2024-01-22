using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParaBankFramework.Pages;
using ParaBankFramework.Selenium;

namespace ParaBankFramework.Tests
{
    [TestClass]
    public class ForgotLoginTests : BaseTest
    {
        // TODO - Refactor the repeated code and variables to [TestInitialize] method

        [TestMethod]
        public void CanLookupLoginInfoForLastRegisterdCustomerResultSuccess()
        {
            // Arrange
            var registerPage = new RegisterPage(Browser.Driver);
            registerPage.Goto();

            // Register a new customer and immediately logout
            var customerCreatedPage = registerPage.RegisterNewCustomer();
            var homePage = customerCreatedPage.Menus.AccountServices.LogOut();

            // Attempt to lookup login information for last registered user
            var lookupPage = homePage.ClickForgotLogin();    
            var lookupResult = lookupPage.LookupLastRegisteredCustomer();

            // Assert
            Assert.IsTrue(lookupResult.IsAt(), "Not at Lookup Result success Page");
            Assert.IsTrue(lookupResult.IsResultLastRegisteredCustomer(), "Result did not match last registered customer");
        }

        [TestMethod]
        public void CannotLookupLoginInfoForLastRegisterdCustomerResultFailure()
        {
            // Arrange
            var registerPage = new RegisterPage(Browser.Driver);
            registerPage.Goto();

            // Register a new customer and immediately logout
            var customerCreatedPage = registerPage.RegisterNewCustomer();
            var homePage = customerCreatedPage.Menus.AccountServices.LogOut();

            // attempt to lookup login information with invalid customer info
            var lookupPage = homePage.ClickForgotLogin();
            var errorPage = lookupPage.LookupLastRegisteredCustomerExpectingFailure();

            // Assert
            Assert.IsTrue(errorPage.IsAt(), "Not at Customer Lookup page");
            Assert.IsTrue(errorPage.IsFirstNameError(), "Did not return first name error");
            Assert.AreEqual(errorPage.GetErrorText(), "First name is required.");
        }

        // TODO - Add more test methods
        // TODO - Refactor GetErrorText() and replace with IsField<Error>() type method
    }
}

