using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Support;

namespace ParaBankFramework.Pages
{
    public class LoginErrorPage
    {
        // Member variables
        private const string Title = "ParaBank | Error";
        private const string ErrorHeading = "Error!";
        private const string InvalidCredentialsMessage = "The username and password could not be verified.";
        private const string BlankCredentialsMessage = "Please enter a username and password.";
        private readonly string _url = BaseAddress.Url;
        private readonly IWebDriver _driver;
        
        // Properties

        // Locators
        [FindsBy(How = How.CssSelector, Using = "h1.title")]
        private IWebElement errorHeadingElement;

        [FindsBy(How = How.CssSelector, Using = "p.error")] 
        private IWebElement errorTextElement;

        // Methods
        public LoginErrorPage(IWebDriver driver)
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
            // assertTitle | ParaBank | Error | 
            return _driver.Title.Equals(Title);
        }

        public bool IsInvalidCredentials()
        {
            return CheckErrorMessage(InvalidCredentialsMessage);
        }

        public bool IsMissingCredentials()
        {
            return CheckErrorMessage(BlankCredentialsMessage);
        }

        public string GetErrorText()
        {
            return errorTextElement.Text;
        }

        private bool CheckErrorMessage(string error)
        {
            // assertText | css=h1.title | Error!
            var b1 = errorHeadingElement.Text.Equals(ErrorHeading);

            // assertText | css=p.error | <error>
            var b2 = errorTextElement.Text.Equals(error);

            return b1 && b2;
        }
    }
}