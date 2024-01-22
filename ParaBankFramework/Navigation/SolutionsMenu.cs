using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Pages;

namespace ParaBankFramework.Navigation
{
    // Solutions Menu - header panel / left menu

    public class SolutionsMenu
    {
        // Member variables
        private readonly IWebDriver _driver;
        
        // Locators specific to the solutions menu - they do link to the same as the items in footer navigation panel

        [FindsBy (How = How.XPath, Using = ".//*[@id='headerPanel']/ul[1]/li[2]/a")]
        private IWebElement aboutUsLink;

        [FindsBy (How = How.XPath, Using = ".//*[@id='headerPanel']/ul[1]/li[3]/a")]
        private IWebElement servicesLink;

        [FindsBy (How = How.XPath, Using = ".//*[@id='headerPanel']/ul[1]/li[4]/a")]
        private IWebElement productsLink;

        [FindsBy (How = How.XPath, Using = ".//*[@id='headerPanel']/ul[1]/li[5]/a")]
        private IWebElement locationsLink;

        [FindsBy (How = How.XPath, Using = ".//*[@id='headerPanel']/ul[1]/li[6]/a")]
        private IWebElement adminPageLink;

        // Methods
        public SolutionsMenu(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public AboutUsPage About()
        {
            aboutUsLink.Click();
            return new AboutUsPage(_driver);
        }

        public ServicesPage Services()
        {
            servicesLink.Click();
            return new ServicesPage(_driver);
        }

        public ProductsPage Products()
        {
            productsLink.Click();
            return new ProductsPage(_driver);
        }

        public LocationsPage Locations()
        {
            locationsLink.Click();
            return new LocationsPage(_driver);
        }

        public AdminPage Admin()
        {
            adminPageLink.Click();
            return new AdminPage(_driver);
        }
    }
}
