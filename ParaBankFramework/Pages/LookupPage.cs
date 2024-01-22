using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Generators;
using ParaBankFramework.Support;

namespace ParaBankFramework.Pages
{
    public class LookupPage
    {
        // Member variables
        private const string PageTitle = "ParaBank | Customer Lookup";
        private readonly string _url = BaseAddress.Url + "/lookup.htm";
        private readonly IWebDriver _driver;

        // Locators
        [FindsBy(How = How.Id, Using = "firstName")] 
        private IWebElement firstNameField;
        
        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement lastNameField;

        [FindsBy(How = How.Id, Using = "address.street")]
        private IWebElement addressStreetField;

        [FindsBy(How = How.Id, Using = "address.city")]
        private IWebElement addressCityField;

        [FindsBy(How = How.Id, Using = "address.state")]
        private IWebElement addressStateField;

        [FindsBy(How = How.Id, Using = "address.zipCode")]
        private IWebElement addressZipcodeField;

        [FindsBy(How = How.Id, Using = "ssn")]
        private IWebElement ssnTextField;

        [FindsBy(How = How.XPath, Using = "//input[@value='Find My Login Info']")]
        private IWebElement findLoginButton;

        // Methods
        public LookupPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            _driver.Navigate().GoToUrl(_url);
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(PageTitle);
        }

        public LookupResultsPage LookupLastRegisteredCustomer()
        {
            var customer = CustomerGenerator.LastGeneratedCustomer;

            firstNameField.SendKeys(customer.Firstname);
            lastNameField.SendKeys(customer.Lastname);
            addressStreetField.SendKeys(customer.AddressStreet);
            addressCityField.SendKeys(customer.AddressCity);
            addressStateField.SendKeys(customer.AddressState);
            addressZipcodeField.SendKeys(customer.AddresZipcode);
            ssnTextField.SendKeys(customer.Ssn);

            findLoginButton.Click();

            return new LookupResultsPage(_driver);
        }

        public LookupErrorPage LookupLastRegisteredCustomerExpectingFailure()
        {
            var customer = CustomerGenerator.LastGeneratedCustomer;

            firstNameField.SendKeys("");
            lastNameField.SendKeys(customer.Lastname);
            addressStreetField.SendKeys(customer.AddressStreet);
            addressCityField.SendKeys(customer.AddressCity);
            addressStateField.SendKeys(customer.AddressState);
            addressZipcodeField.SendKeys(customer.AddresZipcode);
            ssnTextField.SendKeys(customer.Ssn);

            findLoginButton.Click();

            return new LookupErrorPage(_driver);
        }
    }
}
