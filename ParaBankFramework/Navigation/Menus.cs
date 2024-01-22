//
// A simple wrapper class so that I can use a fluent "style"
// coding approach for navigating the menus.
//
// somePage.NavigateTo.SolutionsMenu.<item>
// somePage.NavigateTo.AccountServicesMenu.<item>
// somePage.NavigateTo.FooterMenu.<item>
//

using OpenQA.Selenium;

namespace ParaBankFramework.Navigation
{
    public class Menus
    {
        public SolutionsMenu Solutions;
        public AccountServicesMenu AccountServices;
        public FooterMenu Footer;

        public Menus(IWebDriver driver)
        {
            Solutions = new SolutionsMenu(driver);
            AccountServices = new AccountServicesMenu(driver);
            Footer = new FooterMenu(driver);
        }
    }
}
