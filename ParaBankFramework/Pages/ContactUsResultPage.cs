using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class ContactUsResultPage : BasePage
    {
        private const string Title = "ParaBank | Customer Care";
        private const string ContactMessage = "A Customer Care Representative will be contacting you.";
        
        private readonly IWebDriver _driver;

        // Locators

        // Methods

        public ContactUsResultPage(IWebDriver driver)
            : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public bool IsAt()
        {
            return _driver.Title.Contains(Title);
        }

        public bool IsConfirmationDisplayed()
        {
            return _driver.PageSource.Contains(ContactMessage);
        }
    }
}
