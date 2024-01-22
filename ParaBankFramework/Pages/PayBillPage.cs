using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class PayBillPage : BasePage
    {
        // Member variables
        private const string Title = "ParaBank | Bill Pay";
        private readonly IWebDriver _driver;
        
        // Properties

        // Locators

        // Methods
        public PayBillPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            Menus.AccountServices.PayBill();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }
    }
}
