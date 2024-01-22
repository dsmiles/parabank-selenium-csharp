using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class HomePage : BasePage
    {
        // Member variables
        private const string Title = "ParaBank | Welcome | Online Banking";
        private readonly IWebDriver _driver;

        // Properties

        // Locators - When customer NOT logged in 
        [FindsBy(How = How.LinkText, Using = "Forgot login info?")] 
        private IWebElement forgotLoginLink;

        [FindsBy(How = How.LinkText, Using = "Register")] 
        private IWebElement registerLink;

        // Methods
        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Goto()
        {
            Menus.Footer.Home();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }

        public LoginPage Login()
        {
            return new LoginPage(_driver);
        }

        public LookupPage ClickForgotLogin()
        {
            forgotLoginLink.Click();
            return new LookupPage(_driver);
        }

        public RegisterPage ClickRegister()
        {
            registerLink.Click();
            return new RegisterPage(_driver);
        }
    }
}
