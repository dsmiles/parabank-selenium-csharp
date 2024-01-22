using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParaBankFramework.Pages;
using ParaBankFramework.Selenium;

namespace ParaBankFramework.Tests
{
    [TestClass]
    public class AccountMenuTests : BaseTest
    {
        // TODO - Refactor the repeated code and variables to [TestInitialize] method

        [TestMethod]
        public void AccountMenu_Goto_OpenNewAccountPage_ResultSuccess()
        {
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();    
            
            var loginPage = homePage.Login();
            loginPage.Goto();   

            var overviewPage = loginPage.LoginAsDefaultCustomer();
            overviewPage.Goto();

            var openAccountPage = overviewPage.Menus.AccountServices.OpenNewAccount();

            Assert.IsTrue(openAccountPage.IsAt(), "Not at Open New Account page");
        }

        [TestMethod]
        public void AccountMenu_Goto_AccountOverviewPage_ResultSuccess()
        {
            var homePage = new HomePage(Browser.Driver);
            homePage.Goto();

            var loginPage = homePage.Login();
            loginPage.Goto();

            var overviewPage = loginPage.LoginAsDefaultCustomer();
            overviewPage.Goto();

            Assert.IsTrue(overviewPage.IsAt(), "Not at Accounts Overview page");
        }

        [TestMethod]
        public void AccountMenu_Goto_TransferFundsPage_ResultSuccess()
        {
            var loginPage = new LoginPage(Browser.Driver);
            
            loginPage.Goto();

            var overviewPage = loginPage.LoginAsDefaultCustomer();

            var transferFundsPage = overviewPage.Menus.AccountServices.TransferFunds();

            transferFundsPage.TransferTheMoney();
            
            Assert.IsTrue(transferFundsPage.IsAt(), "Not at Transfer Funds page");
        }

        [TestMethod]
        public void AccountMenu_Goto_BillPay_Page_ResultSuccess()
        {
            var loginPage = new LoginPage(Browser.Driver);

            loginPage.Goto();

            var overviewPage = loginPage.LoginAsDefaultCustomer();

            var payBillPage = overviewPage.Menus.AccountServices.PayBill();

            Assert.IsTrue(payBillPage.IsAt(), "Not at Pay Bill page");
        }

        [TestMethod]
        public void AccountMenu_Goto_FindTransactionsPage_ResultSuccess()
        {
            var loginPage = new LoginPage(Browser.Driver);

            loginPage.Goto();

            var overviewPage = loginPage.LoginAsDefaultCustomer();

            var findTransactionsPage = overviewPage.Menus.AccountServices.FindTransactions();

            Assert.IsTrue(findTransactionsPage.IsAt(), "Not at Find Transactions page");
        }

        [TestMethod]
        public void AccountMenu_Goto_UpdateContactInfoPage_ResultSuccess()
        {
            var loginPage = new LoginPage(Browser.Driver);

            loginPage.Goto();

            var overviewPage = loginPage.LoginAsDefaultCustomer();

            var updateProfilePage = overviewPage.Menus.AccountServices.UpdateContactInfo();

            Assert.IsTrue(updateProfilePage.IsAt(), "Not at Update Contact Information page");
        }

        [TestMethod]
        public void AccountMenu_Goto_RequestLoanPage_ResultSuccess()
        {
            var loginPage = new LoginPage(Browser.Driver);
        
            loginPage.Goto();

            var overviewPage = loginPage.LoginAsDefaultCustomer();

            var loanPage = overviewPage.Menus.AccountServices.RequestLoan();

            Assert.IsTrue(loanPage.IsAt(), "Not at Request Loan page");
        }

        [TestMethod]
        public void AccountMenu_Goto_Logout_ResultSuccess()
        {
            var loginPage = new LoginPage(Browser.Driver);

            loginPage.Goto();

            var overviewPage = loginPage.LoginAsDefaultCustomer();

            var homePage = overviewPage.Menus.AccountServices.LogOut();

            Assert.IsTrue(homePage.IsAt(), "Not at Home Ppage");
        }
    }
}
