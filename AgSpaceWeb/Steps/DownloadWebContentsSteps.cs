using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using AgSpaceWeb.Hook;


/*
    INCOMPLETE STEPS 'THEN'
 */
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
            home = AgSpaceHooks.home;
            webDriver = AgSpaceHooks.webDriver;
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
            //Todo: check for external link on Apps Store /Play Store 
            Console.WriteLine(webDriver.Title);
        }

        [Given(@"I browse agSpace web site")]
        public void GivenIBrowseAgSpaceWebSite()
        {
            home = AgSpaceHooks.home;
            webDriver = AgSpaceHooks.webDriver;
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
            //Todo: check for external link on Apps Store /Play Store 
            Console.WriteLine(webDriver.Title);
        }
    }
}
