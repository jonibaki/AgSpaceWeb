using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AgSpaceWeb.Steps
{
    [Binding]
    public class DownloadWebContentsSteps
    {
        HomePage home = null;
        IWebDriver webDriver = null;

  
     
        [Given(@"I go to agSpace website")]
        public void GivenIGoToAgSpaceWebsite()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }

        [Given(@"I navigate to Contour page")]
        public void GivenINavigateToContourPage()
        {
            IWebElement navContour = webDriver.FindElement(By.Id("menu-item-37"));
            home.ClickNavMenu(navContour);
        }

        [When(@"I click  download button on Contour Page")]
        public void WhenIClickDownloadButtonOnContourPage()
        {
            webDriver.FindElement(By.CssSelector("div.cta-wrapper>a")).Click();
        }

        [Then(@"I download the Contour contents")]
        public void ThenIDownloadTheContourContents()
        {
            Console.WriteLine(webDriver.Title);
        }

        [Given(@"I browse agSpace web site")]
        public void GivenIBrowseAgSpaceWebSite()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
        }

        [Given(@"I navigate to Grid page")]
        public void GivenINavigateToGridPage()
        {
            IWebElement navGrid = webDriver.FindElement(By.Id("menu-item-40"));
            home.ClickNavMenu(navGrid);
        }

        [When(@"I click download button on Grid Page")]
        public void WhenIClickDownloadButtonOnGridPage()
        {
            webDriver.FindElement(By.CssSelector("div.cta-wrapper>a")).Click();
        }

        
        [Then(@"I download the Grid contents")]
        public void ThenIDownloadTheGridContents()
        {
            Console.WriteLine(webDriver.Title);
        }


        [AfterScenario]
        public void closeDrive()
        {
            webDriver.Close();
        }
    }
}
