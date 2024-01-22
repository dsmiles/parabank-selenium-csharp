using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class UpdateProfilePage : BasePage
    {
         // Member variables
        private const string Title = "ParaBank | Update Profile";
        private readonly IWebDriver _driver;
        
        // Properties

        // Locators

        // Methods
        public UpdateProfilePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            Menus.AccountServices.UpdateContactInfo();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }
    }
}