using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Generators;
using ParaBankFramework.Pages;
using ParaBankFramework.Support;

namespace ParaBankFramework.Navigation
{
    // You only see the Account Services menu when you are logged in - left menu

    public class AccountServicesMenu
    {
        // Member varibles
        private const string Title = "ParaBank | Accounts Overview";
        private readonly IWebDriver _driver;

        // Properties

        // Locators
        [FindsBy(How = How.LinkText, Using = "Open New Account")]
        private IWebElement openNewAccountLink;

        [FindsBy(How = How.LinkText, Using = "Accounts Overview")]
        private IWebElement accountsOverviewLink;

        [FindsBy(How = How.LinkText, Using = "Transfer Funds")]
        private IWebElement transferFundsLink;

        [FindsBy(How = How.LinkText, Using = "Bill Pay")]
        private IWebElement payBillLink;

        [FindsBy(How = How.LinkText, Using = "Find Transactions")]
        private IWebElement findTransactionsLink;

        [FindsBy(How = How.LinkText, Using = "Update Contact Info")]
        private IWebElement updateContactInfoLink;

        [FindsBy(How = How.LinkText, Using = "Request Loan")]
        private IWebElement requestLoanLink;

        [FindsBy(How = How.LinkText, Using = "Log Out")]
        private IWebElement logOutLink;

        // Methods
        public AccountServicesMenu(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public OpenAccountPage OpenNewAccount()
        {
            openNewAccountLink.Click();
            return new OpenAccountPage(_driver);
        }

        public AccountOverviewPage AccountsOverview()
        {
            accountsOverviewLink.Click();
            return new AccountOverviewPage(_driver);
        }

        public TransferFundsPage TransferFunds()
        {
            transferFundsLink.Click();
            return new TransferFundsPage(_driver);
        }

        public PayBillPage PayBill()
        {
            payBillLink.Click();
            return new PayBillPage(_driver);
        }

        public FindTransactionsPage FindTransactions()
        {
            findTransactionsLink.Click();
            return new FindTransactionsPage(_driver);
        }

        public UpdateProfilePage UpdateContactInfo()
        {
            updateContactInfoLink.Click();
            return new UpdateProfilePage(_driver);
        }

        public RequestLoanPage RequestLoan()
        {
            requestLoanLink.Click();
            return new RequestLoanPage(_driver);
        }

        public HomePage LogOut()
        {
            if (logOutLink.Exists())
            {
                logOutLink.Click();
            }
            return new HomePage(_driver);
        }
    }
}
