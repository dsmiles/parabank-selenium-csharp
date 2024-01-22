using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class TransferFundsPage : BasePage
    {
         // Member variables
        private const string Title = "ParaBank | Transfer Funds";
        private readonly IWebDriver _driver;
        
        // Properties

        // Locators

        // Methods
        public TransferFundsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            Menus.AccountServices.TransferFunds();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }

        public void TransferTheMoney()
        {
            
        }
    }
}
