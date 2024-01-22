using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ParaBankFramework.Selenium
{
    public class Browser
    {
        // Member variables
        //private static IWebDriver WebDriver = new FirefoxDriver();
        private static IWebDriver _driver;

        // have the driver wait for a period of time
        //public static WebDriverWait Wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(30));
        public static WebDriverWait Wait;

        // Properties
        public static string Title
        {
            get { return _driver.Title; }
        }

        public static string PageSource
        {
            get { return _driver.PageSource; }
        }

        public static IWebDriver Driver
        {
            get { return _driver; }
        }

        // Methods
        public static void Initialize()
        {
            _driver = new FirefoxDriver();

            // have the driver wait for a period of time
            Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public static void Goto(string url)
        {
            _driver.Url = url;
        }

        public static void Close()
        {
            _driver.Close();
        }

        public static void Quit()
        {
            _driver.Quit();
        }

        public static void MaximizeWindow()
        {
            _driver.Manage().Window.Maximize();
        }

        public static WebDriverWait WaitEx()
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
    }
}