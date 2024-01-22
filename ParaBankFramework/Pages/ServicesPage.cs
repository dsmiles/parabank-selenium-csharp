using OpenQA.Selenium;

namespace ParaBankFramework.Pages
{
    public class ServicesPage : BasePage
    {
        private const string Title = "ParaBank | Services";
        private readonly IWebDriver _driver;

        public ServicesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void Goto()
        {
            Menus.Solutions.Services();
        }

        public bool IsAt()
        {
            return _driver.Title.Contains(Title);
        }
    }
}
