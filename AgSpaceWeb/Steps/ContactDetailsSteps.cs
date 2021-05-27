using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AgSpaceWeb.Steps
{
    [Binding]
    public class ContactDetailsSteps
    {
        HomePage home = null;
        IWebDriver webDriver = null;
        [Given(@"I browse agSpace web page")]
        public void GivenIBrowseAgSpaceWebPage()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }
        
        [When(@"I click contact from nav menu")]
        public void WhenIClickContactFromNavMenu()
        {
            IWebElement navContact = webDriver.FindElement(By.Id("menu-item-43"));
            home.clickNavMenu(navContact);
        }
        
        [Then(@"Verify contact (.*) and (.*) details")]
        public void ThenVerifyContactAndDetails(string number, string email)
        {
            IList<IWebElement> contactElements = webDriver.FindElements(By.ClassName("contact-el"));
            string callAgSpace="", emailAgSpace ="";

            foreach (IWebElement we in contactElements)
            {

                if (we.FindElement(By.TagName("p")).Text == "Call AgSpace:")
                {

                    callAgSpace = we.FindElement(By.TagName("a")).Text;
                }
                else if (we.FindElement(By.TagName("p")).Text == "Email AgSpace:")
                {

                    emailAgSpace = we.FindElement(By.TagName("a")).Text;
                }

            }

            Assert.AreEqual(number, callAgSpace);
            Assert.AreEqual(email, emailAgSpace);
        }

        [AfterScenario]
        public void closeDrive()
        {
            webDriver.Close();
        }

    }
}
