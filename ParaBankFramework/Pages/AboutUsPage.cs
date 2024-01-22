using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class AboutUsPage : BasePage
    {
        // Member variables
        private const string PageTitle = "ParaBank | About Us";
        private readonly IWebDriver _driver;

        // Properties

        // Locators

        // Methods
        public AboutUsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Goto()
        {
            Menus.Solutions.About();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(PageTitle);
        }
    }
}