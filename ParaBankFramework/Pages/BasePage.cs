using OpenQA.Selenium;
using ParaBankFramework.Navigation;

namespace ParaBankFramework.Pages
{
    public abstract class BasePage
    {
        // Member variables

        // Uses composition to model the navigation menus - solutions, account services and footer menus
        public Menus Menus;

        // Uses composition to model the login state of the applcation (logged in true/false)
        public LoginState State;

        // Properties

        // Locators

        // Methods
        protected BasePage(IWebDriver driver)
        {
            Menus = new Menus(driver);
            State = new LoginState(driver);
        }
    }
}