using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AgSpaceWeb.Steps
{
    [Binding]
    public sealed class WebPageNavSteps
    {
        HomePage home = null;
        IWebDriver webDriver = null;

        [Given(@"I browse the agSpace website for Innovation")]
        public void GivenIBrowseTheAgSpaceWebsiteForInnovation()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }

        [When(@"I click the Innovation")]
        public void WhenIClickTheInnovation()
        {
            IWebElement navInnovation  = webDriver.FindElement(By.Id("menu-item-28"));
            home.ClickNavMenu(navInnovation);
        }


        [Then(@"I land on Innovation page")]
        public void ThenILandOnInnovationPage()
        {
            string title = home.getTitle();
            Assert.AreEqual(title, "Innovation - AgSpace");
        }

        [Given(@"I browse the agSpace website for Big Data")]
        public void GivenIBrowseTheAgSpaceWebsiteForBigData()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }
        [When(@"I click the Big Data")]
        public void WhenIClickTheBigData()
        {
            IWebElement navBigData = webDriver.FindElement(By.Id("menu-item-31"));
            home.ClickNavMenu(navBigData);
        }

        [Then(@"I land on Big Data page")]
        public void ThenILandOnBigDataPage()
        {
            string title = home.getTitle();
            Assert.AreEqual(title, "Big Data - AgSpace");
        }

        [Given(@"I browse the agSpace website for Observation")]
        public void GivenIBrowseTheAgSpaceWebsiteForObservation()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }

        [When(@"I click the Earth Observation")]
        public void WhenIClickTheEarthObservation()
        {
            IWebElement navObservation = webDriver.FindElement(By.Id("menu-item-34"));
            home.ClickNavMenu(navObservation);
        }

        [Then(@"I land on Earth Observation  page")]
        public void ThenILandOnEarthObservationPage()
        {
            string title = home.getTitle();
            Assert.AreEqual(title, "Earth observation - AgSpace");
        }

        [Given(@"I browse the agSpace website for Contour")]
        public void GivenIBrowseTheAgSpaceWebsiteForContour()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }



        [When(@"I click the Contour")]
        public void WhenIClickTheContour()
        {
            IWebElement navContour = webDriver.FindElement(By.Id("menu-item-37"));
            home.ClickNavMenu(navContour);
        }

        [Then(@"I land on Contour page")]
        public void ThenILandOnContourPage()
        {
            string title = home.getTitle();
            Assert.AreEqual(title, "Contour - AgSpace");
        }

        [Given(@"I browse the agSpace website for Grid")]
        public void GivenIBrowseTheAgSpaceWebsiteForGrid()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }

        [When(@"I click the Grid")]
        public void WhenIClickTheGrid()
        {
            IWebElement navGrid = webDriver.FindElement(By.Id("menu-item-40"));
            home.ClickNavMenu(navGrid);
        }

        [Then(@"I land on Grid page")]
        public void ThenILandOnGridPage()
        {
            string title = home.getTitle();
            Assert.AreEqual(title, "Grid - AgSpace");
        }




        [Given(@"I browse the agSpace website for What's New")]
        public void GivenIBrowseTheAgSpaceWebsiteForWhatSNew()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }

        [When(@"I click the What's New")]
        public void WhenIClickTheWhatSNew()
        {
            IWebElement navWhatsNew = webDriver.FindElement(By.Id("menu-item-120"));
            home.ClickNavMenu(navWhatsNew);
        }

        [Then(@"I land on What's New page")]
        public void ThenILandOnWhatSNewPage()
        {
            string title = home.getTitle();
            Assert.AreEqual(title, "What's new - AgSpace");
        }

        [Given(@"I browse the agSpace website for Contact")]
        public void GivenIBrowseTheAgSpaceWebsiteForContact()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }

        [When(@"I click the Contact")]
        public void WhenIClickTheContact()
        {
            IWebElement navContact = webDriver.FindElement(By.Id("menu-item-43"));
            home.ClickNavMenu(navContact);
        }

        [Then(@"I land on Contact page")]
        public void ThenILandOnContactPage()
        {
            string title = home.getTitle();
            Assert.AreEqual(title, "Contact - AgSpace");
        }


/*        [AfterScenario]
        public void closeDrive()
        {

            webDriver.Close();
        }
*/


    }
}
