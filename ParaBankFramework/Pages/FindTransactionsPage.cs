using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class FindTransactionsPage : BasePage
    {
         // Member variables
        private const string Title = "ParaBank | Find Transactions";
        private readonly IWebDriver _driver;
        
        // Properties

        // Locators

        // Methods
        public FindTransactionsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            Menus.AccountServices.FindTransactions();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }
    }
}