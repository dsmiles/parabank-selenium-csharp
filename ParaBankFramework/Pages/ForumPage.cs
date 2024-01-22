using OpenQA.Selenium;

namespace ParaBankFramework.Pages
{
    public class ForumPage : BasePage
    {
        private const string Title = "Parasoft Forum (Powered by Invision Power Board)";
        private readonly IWebDriver _driver;

        public ForumPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void Goto()
        {
            Menus.Footer.Forum();
        }

        public bool IsAt()
        {
            return _driver.Title.Contains(Title);
        }
    }
}
