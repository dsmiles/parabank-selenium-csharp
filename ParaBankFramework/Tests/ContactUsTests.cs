using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParaBankFramework.Pages;
using ParaBankFramework.Selenium;

namespace ParaBankFramework.Tests
{
    [TestClass]
    public class ContactUsTests : BaseTest
    {
        // TODO - Refactor the repeated code and variables to [TestInitialize] method

        [TestMethod]
        public void CanSubmitCompletedFormReturnSuccess()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            var contactUsPage = homePage.Menus.Footer.Contact();

            // Act
            var contactSubmittedPage = contactUsPage.SubmitContactForm();

            // Assert
            Assert.IsTrue(contactSubmittedPage.IsAt());
            Assert.IsTrue(contactSubmittedPage.IsConfirmationDisplayed());
        }


        [TestMethod]
        public void CannotSubmitEmptyFormDisplaysError()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            var contactUsPage = homePage.Menus.Footer.Contact();

            // Act - submit form with four empty fields
            contactUsPage = contactUsPage.SubmitEmptyForm(); 

            // Assert - we should get four errors displayed
            Assert.IsTrue(contactUsPage.IsAt());
            Assert.AreEqual(4, contactUsPage.GetNumberOfErrors(), "Did not get expected number of errors");
        }


        [TestMethod]
        public void CannotSubmitFormWithMissingNameDisplaysError()
        {
            // Arrange
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            var contactUsPage = homePage.Menus.Footer.Contact();

            // Act
            contactUsPage = contactUsPage.SubmitFormWithMissingName();

            // Assert
            Assert.IsTrue(contactUsPage.IsAt());
            Assert.IsTrue(contactUsPage.IsNameErrorDisplayed());
        }

        [TestMethod]
        public void CannotSubmitFormWithMissingEmailDisplaysError()
        {
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            var contactUsPage = homePage.Menus.Footer.Contact();

            // Act
            contactUsPage = contactUsPage.SubmitFormWithMissingEmail();
            
            // Assert
            Assert.IsTrue(contactUsPage.IsAt());
            Assert.IsTrue(contactUsPage.IsEmailErrorDisplayed());
        }

        [TestMethod]
        public void CannotSubmitFormWithMissingPhoneDisplaysError()
        {
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            var contactUsPage = homePage.Menus.Footer.Contact();

            // Act
            contactUsPage = contactUsPage.SubmitFormWithMissingPhoneNumber();

            // Assert
            Assert.IsTrue(contactUsPage.IsAt());
            Assert.IsTrue(contactUsPage.IsPhoneErrorDisplayed());
        }

        [TestMethod]
        public void CannotSubmitFormWithMissingMessageDisplaysError()
        {
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();
            
            var contactUsPage = homePage.Menus.Footer.Contact();
            contactUsPage = contactUsPage.SubmitFormWithMissingMessage();

            Assert.IsTrue(contactUsPage.IsAt());
            Assert.IsTrue(contactUsPage.IsMessageErrorDisplayed());
        }
    }
}


