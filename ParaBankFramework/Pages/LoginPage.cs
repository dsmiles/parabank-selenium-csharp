using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Generators;
using ParaBankFramework.Support;

namespace ParaBankFramework.Pages
{
    public class LoginPage
    {
        // Member variables
        private const string Title = "ParaBank | Welcome | Online Banking";
        private readonly string _url = BaseAddress.Url;
        private readonly IWebDriver _driver;
        
        // Properties

        // Locators
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement usernameField;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordField;

        [FindsBy(How = How.CssSelector, Using = "input.button")]
        private IWebElement loginButton;

        // Methods
        public LoginPage(IWebDriver driver)
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
            return _driver.Title.Equals(Title);
        }

        public AccountOverviewPage LoginAs(string username, string password)
        {
            Login(username, password);
            return new AccountOverviewPage(_driver);
        }

        public LoginErrorPage LoginAsInvalid(string username, string password)
        {
            Login(username, password);
            return new LoginErrorPage(_driver);
        }

        public AccountOverviewPage LoginAs(Customer customer)
        {
            Login(customer.Username, customer.Password);
            return new AccountOverviewPage(_driver);
        }

        public AccountOverviewPage LogInAsLastRegisteredCustomer()
        {
            Login(CustomerGenerator.LastGeneratedCustomer.Username,CustomerGenerator.LastGeneratedCustomer.Password);
            return new AccountOverviewPage(_driver);
        }

        public AccountOverviewPage LoginAsDefaultCustomer()
        {
            Login("john", "demo");
            return new AccountOverviewPage(_driver);
        }

        private void Login(string username, string password)
        {
            Goto();

            usernameField.Clear();
            usernameField.SendKeys(username);

            passwordField.Clear();
            passwordField.SendKeys(password);

            loginButton.Click(); 
        }
    }
}