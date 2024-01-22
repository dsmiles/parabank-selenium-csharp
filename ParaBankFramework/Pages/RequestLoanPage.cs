using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ParaBankFramework.Pages
{
    public class RequestLoanPage : BasePage
    {
        // Member variables
        private const string Title = "ParaBank | Loan Request";
        private readonly IWebDriver _driver;

        // Properties

        // Locators

        // Methods
        public RequestLoanPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Goto()
        {
            Menus.AccountServices.RequestLoan();
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(Title);
        }
    }
}