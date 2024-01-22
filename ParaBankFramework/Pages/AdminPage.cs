using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public  class AdminPage : BasePage
    {
        // Member variables
        private const string Title = "ParaBank | Administration";
        private readonly IWebDriver _driver;

        // Properties

        // Locators

        // Methods
        public AdminPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void GoTo()
        {
            Menus.Solutions.Admin();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }
    }
}