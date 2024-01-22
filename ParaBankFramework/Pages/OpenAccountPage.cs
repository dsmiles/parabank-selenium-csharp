using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class OpenAccountPage : BasePage
    {
        // Member variables
        private const string Title = "ParaBank | Open Account";
        private readonly IWebDriver _driver;
        
        // Properties

        // Locators

        // Methods
        public OpenAccountPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            Menus.AccountServices.OpenNewAccount();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }
    }
}
