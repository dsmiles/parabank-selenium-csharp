using OpenQA.Selenium;

namespace ParaBankFramework.Pages
{
    public class ProductsPage : BasePage
    {
        private const string Title = "Software Testing Tools & Products - Parasoft";
        private readonly IWebDriver _driver;

        public ProductsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void Goto()
        {
            Menus.Solutions.Products();
        }

        public bool IsAt()
        {
            return _driver.Title.Contains(Title);
        }
    }
}
