using OpenQA.Selenium;

namespace ParaBankFramework.Pages
{
    public class SiteMapPage : BasePage
    {
        private const string Title = "ParaBank | Site Map";
        private readonly IWebDriver _driver;

        public SiteMapPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void Goto()
        {
            Menus.Footer.SiteMap();
        }

        public bool IsAt()
        {
            return _driver.Title.Contains(Title);
        }
    }
}
