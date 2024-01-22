using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Generators;
using ParaBankFramework.Support;

namespace ParaBankFramework.Pages
{
    public class LoginState
    {
        // Member variables
        private readonly IWebDriver _driver;

        // Locators
        [FindsBy(How = How.ClassName, Using = "smallText")] 
        private IWebElement welcomeElement;

        [FindsBy(How = How.LinkText, Using = "Log Out")]
        private IWebElement logOutLink;

        // Methods
        public LoginState(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public bool IsLoggedIn()
        {
            return logOutLink.Exists();
        }

        public bool IsLoggedInAsLastRegisteredCustomer()
        {
            return IsLoggedIn() && IsLoggedInAsCustomer(CustomerGenerator.LastGeneratedCustomer);
        }

        public bool IsLoggedInAsCustomer(Customer customer)
        {
            return IsLoggedIn() && IsLoggedInAs(customer.Firstname, customer.Lastname);
        }

        public bool IsLoggedInAs(string firstname, string lastname)
        {
            return IsLoggedIn() && welcomeElement.Text.Contains(firstname + " " + lastname);
        }
    }
}
