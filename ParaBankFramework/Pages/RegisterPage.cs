using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Generators;
using ParaBankFramework.Support;

namespace ParaBankFramework.Pages
{
    public class RegisterPage : BasePage
    {
        // Member variables
        private const string Title = "ParaBank | Register for Free Online Account Access";
        private readonly string _url = BaseAddress.Url + "/register.htm";
        private readonly IWebDriver _driver;

        // Properties

        // Locators
        [FindsBy(How = How.Id, Using = "customer.firstName")] 
        private IWebElement firstnameField;

        [FindsBy(How = How.Id, Using = "customer.lastName")] 
        private IWebElement lastnameField;

        [FindsBy(How = How.Id, Using = "customer.address.street")]
        private IWebElement addressStreetField;

        [FindsBy(How = How.Id, Using = "customer.address.city")]
        private IWebElement addressCityField;

        [FindsBy(How = How.Id, Using = "customer.address.state")]
        private IWebElement addressStateField;

        [FindsBy(How = How.Id, Using = "customer.address.zipCode")]
        private IWebElement addressZipcodeField;

        [FindsBy(How = How.Id, Using = "customer.phoneNumber")]
        private IWebElement phonenumberField;

        [FindsBy(How = How.Id, Using = "customer.ssn")]
        private IWebElement ssnField;

        [FindsBy(How = How.Id, Using = "customer.username")]
        private IWebElement usernameField;

        [FindsBy(How = How.Id, Using = "customer.password")]
        private IWebElement passwordField;

        [FindsBy(How = How.Id, Using = "repeatedPassword")]
        private IWebElement repeatedPasswordField;

        [FindsBy(How = How.XPath, Using = "//input[@value='Register']")]
        private IWebElement registerButton;

        // Methods
        public RegisterPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            // TODO - Refactor this method
            // Register link only displayed on home page when customer is logged out
            // Should I throw an exception since it's unreachable if customer logged in ??
            _driver.Navigate().GoToUrl(_url);
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }

        public CustomerCreatedPage RegisterNewCustomer()
        {
            // Populate text fields with generated customer data
            var customer = CustomerGenerator.Generate();

            firstnameField.SendKeys(customer.Firstname);
            lastnameField.SendKeys(customer.Lastname);
            addressStreetField.SendKeys(customer.AddressStreet);
            addressCityField.SendKeys(customer.AddressCity);
            addressStateField.SendKeys(customer.AddressState);
            addressZipcodeField.SendKeys(customer.AddresZipcode);
            phonenumberField.SendKeys(customer.Phonenumber);
            ssnField.SendKeys(customer.Ssn);
            usernameField.SendKeys(customer.Username);
            passwordField.SendKeys(customer.Password);
            repeatedPasswordField.SendKeys(customer.Password);

            registerButton.Click();

            return new CustomerCreatedPage(_driver);
        }

        public void RegisterNewCustomerWithIncompleteData()
        {
            // TODO 
        }
    }
}