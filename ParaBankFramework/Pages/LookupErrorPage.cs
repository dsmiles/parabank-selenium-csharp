using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ParaBankFramework.Support;

namespace ParaBankFramework.Pages
{
    public class LookupErrorPage
    {
        // Member variables
        private const string PageTitle = "ParaBank | Customer Lookup";
        private readonly string _url = BaseAddress.Url + "/lookup.htm";
        private readonly IWebDriver _driver;

        // Locators
        [FindsBy(How = How.Id, Using = "firstName.errors")]
        private IWebElement firstNameErrors;

        [FindsBy(How = How.Id, Using = "lastName.errors")]
        private IWebElement lastNameErrors;

        [FindsBy(How = How.Id, Using = "address.street.errors")]
        private IWebElement streetErrors;

        [FindsBy(How = How.Id, Using = "address.city.errors")]
        private IWebElement cityErrors;

        [FindsBy(How = How.Id, Using = "address.state.errors")]
        private IWebElement stateErrors;

        [FindsBy(How = How.Id, Using = "address.zipCode.errors")]
        private IWebElement zipCodeErrors;

        [FindsBy(How = How.Id, Using = "ssn.errors")]
        private IWebElement ssnErrors;

        [FindsBy(How = How.ClassName, Using = "error")] 
        private IWebElement errorText;

        /*
            <span id="firstName.errors" class="error">First name is required.</span>
            <span id="lastName.errors" class="error">Last name is required.</span>
            <span id="address.street.errors" class="error">Address is required.</span>
            <span id="address.city.errors" class="error">City is required.</span>
            <span id="address.state.errors" class="error">State is required.</span>
            <span id="address.zipCode.errors" class="error">Zip Code is required.</span>
            <span id="ssn.errors" class="error">Social Security Number is required.</span>
        */

        // Methods
        public LookupErrorPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public bool IsAt()
        {
            return _driver.Title.Equals(PageTitle);
        }

        public bool IsFirstNameError()
        {
            return firstNameErrors.Exists();
        }

        public bool IsLastNameError()
        {
            return lastNameErrors.Exists();
        }

        public bool IsAddressStreetError()
        {
            return streetErrors.Exists();
        }

        public bool IsAddressStateError()
        {
            return streetErrors.Exists();
        }

        public bool IsAddressZipCodeError()
        {
            return streetErrors.Exists();
        }

        public bool IsSsnError()
        {
            return streetErrors.Exists();
        }

        public string GetErrorText()
        {
            return errorText.Text;
        }
    }
}
