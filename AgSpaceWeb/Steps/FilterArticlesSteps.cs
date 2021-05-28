using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace AgSpaceWeb.Steps
{
    [Binding]
    public class FilterArticlesSteps
    {
        HomePage home = null;
        IWebDriver webDriver = null;

        private IList<IWebElement> GetAllCheckListItems(string filterName) {
            IList<IWebElement> filterItems = webDriver.FindElements(By.CssSelector("form#search-filter-form-167.searchandfilter>ul>li"));
            Console.WriteLine(filterItems.Count);

            IList<IWebElement> filtered = null;

            foreach (IWebElement we in filterItems)
            {
                Console.WriteLine(we);
                /*   string name = we.FindElement(By.TagName("h4").Text;*/
                /*  if (true){
                      // put inner list in a different list
                      break;
                  }*/
                //then in a loop pick individual item and assert it with different parameters
                switch (filterName) {
                    case "Product":
                        //inner loop and add and break;
                        break;
                    case "Market":
                        //inner loop and add and break;
                        break;
                    case "communication":
                        //inner loop and add and break;
                        break;

                }
            }
            return filtered;


        }

        [Given(@"I browse AgSpace website")]
        public void GivenIBrowseAgSpaceWebsite()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://ag-space.com/");
            webDriver.Manage().Window.Maximize();
            home = new HomePage(webDriver);
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
            IList<IWebElement> filterItems = webDriver.FindElements(By.CssSelector("form#search-filter-form-167.searchandfilter>ul>li"));

            IList<IWebElement> filtered = null;

            int counter = 1;
            foreach (IWebElement we in filterItems)
            {
               
                if (counter != 1) {
                    string value = String.Format($"//*[@id=\"search-filter-form-167\"]/ul/li[{counter}]/h4");
                    string product = we.FindElement(By.XPath(value)).Text;
                    if (product == "Product")
                    {
                        // put inner list in a different list
                        filtered = we.FindElements(By.ClassName("sf-input-checkbox"));
                        break;
                    }

                }
                counter++;
            }

/*            foreach (IWebElement w in filtered)
            {
                if (!w.Selected)
                {
                    w.Click();
                }
            }*/



        }

        [Then(@"I filtered product related articles")]
        [Obsolete]
        public void ThenIFilteredProductRelatedArticles()
        {
            //IWebElement aCardContainer = webDriver.FindElement(By.ClassName("uk-width-2-3@m uk-grid-margin uk-first-column"));
            IWebElement aCardContainer = webDriver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/div/div[2]"));
            //IWebElement aCardContainer = webDriver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/div/div[2]/div[1]"));
            //webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IList <IWebElement> resultCards = aCardContainer.FindElements(By.ClassName("uk-first-column"));

            // loop all the cards and call boolean func and check the assertion for all the criteria
            Console.WriteLine(resultCards.Count);
            foreach (IWebElement el in resultCards) {
                Console.WriteLine(el);  
            }
            Console.WriteLine(resultCards.Count);

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
/*        [AfterScenario]
        public void closeDrive()
        {

            webDriver.Quit();
        }*/

    }
}
