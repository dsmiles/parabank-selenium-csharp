using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Generators;
using ParaBankFramework.Support;

namespace ParaBankFramework.Pages
{
    public class CustomerCreatedPage : BasePage
    {
        // Member variables
        private const string Title = "ParaBank | Customer Created";
        private const string BodyText = "Your account was created successfully. You are now logged in.";
        
        private readonly string _url = BaseAddress.Url + "/register.htm";
        private readonly IWebDriver _driver;

        // Properties

        // Locators
        [FindsBy(How = How.CssSelector, Using = "h1")] 
        private IWebElement h1Title;

        [FindsBy(How = How.CssSelector, Using = "#rightPanel > p")] 
        private IWebElement bodyText;
 /*
    // We should be at Customer Created page
    Assert.AreEqual("ParaBank | Customer Created", driver.Title, "Not at new customer created page");        

    // Check first and last name of logged in user - in left hand panel
    Assert.AreEqual("Welcome Fred Bloggs", driver.FindElement(By.ClassName("smallText")).Text, "Welcome message does not match logged on user");

    // Check username for logged in user - in right hand panel
    Assert.AreEqual("Welcome fredbloggs", driver.FindElement(By.CssSelector("h1.title")).Text, "Welcome [username] does not match new username");
 */

        // Methods
        public CustomerCreatedPage(IWebDriver driver) : base(driver)
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
    }
}



