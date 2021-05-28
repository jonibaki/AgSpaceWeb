using AgSpaceWeb.Hook;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

/*
    INCOMPLETE STEPS
 */
namespace AgSpaceWeb.Steps
{
    [Binding]
    public class FilterArticlesSteps
    {
        HomePage home = null;
        IWebDriver webDriver = null;

        private IList<IWebElement> GetAllCheckListItems( string filterHeaderName) {
               IList<IWebElement> filterItems = webDriver.FindElements(By.CssSelector("form#search-filter-form-167.searchandfilter>ul>li"));

            IList<IWebElement> filtered = null;

            int counter = 1;
            foreach (IWebElement we in filterItems)
            {

                if (counter != 1)
                {
                    string value = String.Format($"//*[@id=\"search-filter-form-167\"]/ul/li[{counter}]/h4");
                    string product = we.FindElement(By.XPath(value)).Text;
                    if (product == filterHeaderName)
                    {

                        filtered = we.FindElements(By.ClassName("sf-input-checkbox"));
                        break;
                    }

                }
                counter++;
            }




            return filtered;


        }

        [Given(@"I browse AgSpace website")]
        public void GivenIBrowseAgSpaceWebsite()
        {
            home = AgSpaceHooks.home;
            webDriver = AgSpaceHooks.webDriver;

        }
        
        [When(@"I click What's New from Nav bar")]
        public void WhenIClickWhatSNewFromNavBar()
        {
            IWebElement navWhatsNew = webDriver.FindElement(By.Id("menu-item-120"));
            home.ClickNavMenu(navWhatsNew);
        }

        [Then(@"I navigate What's New page")]
        public void ThenINavigateWhatSNewPage()
        {
            string title = home.getTitle();
            Assert.AreEqual(title, "What's new - AgSpace");
        }


        [When(@"I toggle on only product")]
        public void WhenIToggleOnOnlyProduct()
        {
            IList<IWebElement> filtered = GetAllCheckListItems("Product");

            foreach (IWebElement w in filtered)
            {
                if (!w.Selected)
                {
                    w.Click();
                }
            }
            Thread.Sleep(500);

        }

        [Then(@"I filtered product related articles")]
        public void ThenIFilteredProductRelatedArticles()
        {
      
            IList<IWebElement> resultCards = null;
            IWebElement aCardContainer = null;
            try
            {
                aCardContainer = webDriver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/div/div[2]/div[1]"));
                resultCards = aCardContainer.FindElements(By.XPath("./*"));
            }
            catch (Exception ex)
            {
                aCardContainer = webDriver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/div/div[2]/div[1]"));
                resultCards = aCardContainer.FindElements(By.XPath("./*"));
            }

            if (resultCards.Count != 0) {
                foreach (IWebElement el in resultCards)
                {
                    
                    Console.WriteLine(el.FindElement(By.TagName("a")).Text);
                }

            }

            //assert against img name
            //assert aginast card title
            
            //Dummy Assertion
            Assert.AreEqual(0, resultCards.Count);
   

        }

        [When(@"I toggle on only market")]
        public void WhenIToggleOnOnlyMarket()
        {
           
        }
        
        [When(@"I toogle on only communication")]
        public void WhenIToogleOnOnlyCommunication()
        {
       
        }
        
        [When(@"I toogle on only date range")]
        public void WhenIToogleOnOnlyDateRange()
        {
           
        }
        
        [When(@"I toogle on multiple categories")]
        public void WhenIToogleOnMultipleCategories()
        {
           
        }
        

        
        [Then(@"I filtered market related articles")]
        public void ThenIFilteredMarketRelatedArticles()
        {
           
        }
        
        [Then(@"I filtered communication related articles")]
        public void ThenIFilteredCommunicationRelatedArticles()
        {
         
        }
        
        [Then(@"I filtered date range related article")]
        public void ThenIFilteredDateRangeRelatedArticle()
        {
          
        }
        
        [Then(@"I filtered multiple categories related articles")]
        public void ThenIFilteredMultipleCategoriesRelatedArticles()
        {
            
        }

    }
}
