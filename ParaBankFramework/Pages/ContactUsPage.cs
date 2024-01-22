using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Faker;

namespace ParaBankFramework.Pages
{
    public class ContactUsPage : BasePage
    {
        private const string Title = "ParaBank | Customer Care";
        private const string NameIsRequired = "Name is required.";
        private const string EmailIsRequired = "Email is required.";
        private const string PhoneIsRequired = "Phone is required.";
        private const string MessageIsRequired = "Message is required.";
        private readonly IWebDriver _driver;

        // Locators

        [FindsBy(How = How.Id, Using = "name")] 
        private IWebElement nameElement;

        [FindsBy(How = How.Id, Using = "email")] 
        private IWebElement emailElement;

        [FindsBy(How = How.Id, Using = "phone")] 
        private IWebElement phoneElement;

        [FindsBy(How = How.Id, Using = "message")] 
        private IWebElement messageElement;

        [FindsBy(How = How.XPath, Using = "//input[@value='Send to Customer Care']")] 
        private IWebElement
            sendButtonElement;

        // input error locators

        // Using this I can check the correct number of invalid elements
        // after submitting the form and I have access to each one if required

        [FindsBy(How = How.ClassName, Using = "error")]
        private IList<IWebElement> invalidInputElements { get; set; }

        // Methods

        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public bool IsAt()
        {
            return _driver.Title.Contains(Title);
        }

        private void FillInFormWithRandomData()
        {
            var fullName = Faker.Name.FullName();
            var emailAddress = Faker.Internet.Email(fullName);
            var phoneNumber = Faker.Phone.Number();
            var message = Faker.Lorem.Paragraph();

            nameElement.SendKeys(fullName);
            emailElement.SendKeys(emailAddress);
            phoneElement.SendKeys(phoneNumber);
            messageElement.SendKeys(message);
        }

        public ContactUsResultPage SubmitContactForm()
        {
            FillInFormWithRandomData();
            sendButtonElement.Click();
            return new ContactUsResultPage(_driver);
        }

        public ContactUsPage SubmitEmptyForm()
        {
            sendButtonElement.Click();
            return this;
        }

        public ContactUsPage SubmitFormWithMissingName()
        {
            FillInFormWithRandomData();
            nameElement.Clear();
            sendButtonElement.Click();
            return this;
        }

        public ContactUsPage SubmitFormWithMissingEmail()
        {
            FillInFormWithRandomData();
            emailElement.Clear();
            sendButtonElement.Click();
            return this;
        }

        public ContactUsPage SubmitFormWithMissingPhoneNumber()
        {
            FillInFormWithRandomData();
            phoneElement.Clear();
            sendButtonElement.Click();
            return this;
        }

        public ContactUsPage SubmitFormWithMissingMessage()
        {
            FillInFormWithRandomData();
            messageElement.Clear();
            sendButtonElement.Click();
            return this;
        }
        
        public int GetNumberOfErrors()
        {
            return invalidInputElements.Count;
        }

        public string GetErrorMessage()
        {
            return invalidInputElements[0].Text;
        }

        public string GetErrorMessage(int index)
        {
            if (index < 0 || index > (invalidInputElements.Count - 1))
                return null;

            return invalidInputElements[index].Text;
        }


        public bool IsNameErrorDisplayed()
        {
            return GetErrorMessage().Equals(NameIsRequired);
        }

        public bool IsEmailErrorDisplayed()
        {
            return GetErrorMessage().Equals(EmailIsRequired);
        }

        public bool IsPhoneErrorDisplayed()
        {
            return GetErrorMessage().Equals(PhoneIsRequired);
        }

        public bool IsMessageErrorDisplayed()
        {
            return GetErrorMessage().Equals(MessageIsRequired);
        }
    }
}
