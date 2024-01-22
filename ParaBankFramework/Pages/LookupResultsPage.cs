using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Generators;
using ParaBankFramework.Support;

namespace ParaBankFramework.Pages
{
    public class LookupResultsPage
    {
        // Member variables
        private const string PageTitle = "ParaBank | Customer Lookup";
        private const string HeadingSuccess = "Customer Lookup";
        private const string BodyTextSuccess = "Your login information was located successfully. You are now logged in.";

        private readonly string _url = BaseAddress.Url + "/lookup.htm";
        private readonly IWebDriver _driver;

        // Locators
        [FindsBy(How = How.CssSelector, Using = "h1.title")] 
        private IWebElement htmlHeadingTitle;

        [FindsBy(How = How.CssSelector, Using = "#rightPanel > p")] 
        private IWebElement bodyText;

        [FindsBy(How = How.XPath, Using = "//div[@id='rightPanel']/p[2]")] 
        private IWebElement searchResultText;
      
        // Methods
        public LookupResultsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(PageTitle);
        }

        public bool IsResultLastRegisteredCustomer()
        {
            var b1 = searchResultText.Text.Contains(CustomerGenerator.LastGeneratedCustomer.Username);
            var b2 = searchResultText.Text.Contains(CustomerGenerator.LastGeneratedCustomer.Password);
            return b1 && b2;
        }
    }
}
