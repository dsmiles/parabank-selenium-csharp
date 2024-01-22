using OpenQA.Selenium;

namespace ParaBankFramework.Pages
{
    public class LocationsPage : BasePage
    {
        private const string Title = "Contact Parasoft";
        private readonly IWebDriver _driver;

        public LocationsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void Goto()
        {
            Menus.Solutions.Locations();
        }

        public bool IsAt()
        {
            return _driver.Title.Contains(Title);
        }
    }
}
