using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParaBankFramework.Generators;
using ParaBankFramework.Selenium;
using ParaBankFramework.Support;

namespace ParaBankFramework.Tests
{
    public class BaseTest
    {
        [TestInitialize]
        public void Init()
        {
            Browser.Initialize();               // Initialise web browser related stuff
            Browser.Goto(BaseAddress.Url);      // Load the web site ready for testing
            CustomerGenerator.Initialize();     // Initalise the fake data generator
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Quit();
        }
    }
}