using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Selenium;

namespace ParaBankFramework.Pages
{
    public class AccountOverviewPage : BasePage
    {
        // Member variables
        private const string Title = "ParaBank | Accounts Overview";
        private readonly IWebDriver _driver;
        
        // Properties

        // Locators

        // Methods
        public AccountOverviewPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            Menus.AccountServices.AccountsOverview();
        }

        public bool IsAt()
        {
            //return _driver.Title.Equals(Title);
            return Browser.Title.Equals(Title);
        }
    }
}