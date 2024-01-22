using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Pages;

namespace ParaBankFramework.Navigation
{
    public class FooterMenu
    {
        // Member varibles
        private readonly IWebDriver _driver;

        // Properties

        // Locators
        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement homeLink;

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'About Us')])[2]")] 
        private IWebElement aboutUsLink;
            
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Services')])[2]")] 
        private IWebElement servicesLink;
    
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Products')])[2]")] 
        private IWebElement productsLink;

        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Locations')])[2]")] 
        private IWebElement locationsLink;
            
        [FindsBy(How = How.LinkText, Using = "Forum")] 
        private IWebElement forumLink;

        [FindsBy(How = How.LinkText, Using = "Site Map")] 
        private IWebElement siteMapLink;
        
        [FindsBy(How = How.LinkText, Using = "Contact Us")] 
        private IWebElement contactUsLink;

        // Methods
        public FooterMenu(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public HomePage Home()
        {
            homeLink.Click();
            return new HomePage(_driver);
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

        public ForumPage Forum()
        {
            forumLink.Click();
            return new ForumPage(_driver);
        }

        public SiteMapPage SiteMap()
        {
            siteMapLink.Click();
            return new SiteMapPage(_driver);
        }

        public ContactUsPage Contact()
        {
            contactUsLink.Click();
            return new ContactUsPage(_driver);
        }
    }
}
