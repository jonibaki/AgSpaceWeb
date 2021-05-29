using AgSpaceWeb.Hook;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;


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
                    Console.WriteLine(product);

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


        [When(@"I toggle on only Product (.*)")]
        public void WhenIToggleOnOnlyProduct(int p0)
        {
            IList<IWebElement> filtered = GetAllCheckListItems("Product");

            for (int i = 0; i < filtered.Count; i++) {
                if (i == p0) {
                    filtered[i].Click();
                    break;
                }
            
            }

            Thread.Sleep(1000);

        }


        [Then(@"I filtered product related articles with '(.*)' and '(.*)'")]
        public void ThenIFilteredProductRelatedArticlesWithAnd(string pName, string pImgName)
        {

            IList<IWebElement> resultCards = null;
            IWebElement aCardContainer = null;
            try
            {
                aCardContainer = webDriver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/div/div[2]/div[1]"));
                ((IJavaScriptExecutor)webDriver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                resultCards = aCardContainer.FindElements(By.XPath("./*"));
            }
            catch (Exception ex)
            {
                aCardContainer = webDriver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/div/div[2]/div[1]"));
                resultCards = aCardContainer.FindElements(By.XPath("./*"));
            }

            Thread.Sleep(600);
            Console.WriteLine(resultCards.Count);
            if (resultCards.Count != 0)
            {
                foreach (IWebElement el in resultCards)
                {
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    string title = el.FindElement(By.ClassName("text-block")).Text;
                    string[] imgPath = el.FindElement(By.XPath("//span[@class='source']")).FindElement(By.TagName("img")).GetAttribute("src").Split("/");
                
                    Assert.AreEqual(true, title.Contains(pName) || imgPath[imgPath.Length - 1].Contains(pImgName));
                }
            }
            else
            {
                Assert.AreEqual(0, resultCards.Count);
            }
        }

        [Given(@"I refresh AgSpace website")]
        public void GivenIRefreshAgSpaceWebsite()
        {
            home = AgSpaceHooks.home;
            webDriver = AgSpaceHooks.webDriver;
        }

        [Given(@"I navigate to What's New page")]
        public void GivenINavigateToWhatSNewPage()
        {
            IWebElement navWhatsNew = webDriver.FindElement(By.Id("menu-item-120"));
            home.ClickNavMenu(navWhatsNew);
        }

        [When(@"I toggle on only Market (.*)")]
        public void WhenIToggleOnOnlyMarket(int p0)
        {
            IList<IWebElement> filtered = GetAllCheckListItems("Market");
            for (int i = 0; i < filtered.Count; i++)
            {
                if (i == p0)
                {
                    filtered[i].Click();
                    break;
                }

            }

            Thread.Sleep(1000);
        }

        [Then(@"I filtered Market related articles with '(.*)'")]
        public void ThenIFilteredMarketRelatedArticlesWith(string tagName)
        {
            string className = "\'tags\'";
            checkForOutputAssertion(className, tagName);
        }


        [Given(@"I land AgSpace website")]
        public void GivenILandAgSpaceWebsite()
        {
            home = AgSpaceHooks.home;
            webDriver = AgSpaceHooks.webDriver;
        }

        [Given(@"I click to What's New page")]
        public void GivenIClickToWhatSNewPage()
        {
            IWebElement navWhatsNew = webDriver.FindElement(By.Id("menu-item-120"));
            home.ClickNavMenu(navWhatsNew);
        }

        [When(@"I toggle on only Communication (.*)")]
        public void WhenIToggleOnOnlyCommunication(int p0)
        {
            IList<IWebElement> filtered = GetAllCheckListItems("Type of communication");
            for (int i = 0; i < filtered.Count; i++)
            {
                if (i == p0)
                {
                    filtered[i].Click();
                    break;
                }

            }

            Thread.Sleep(1000);
        }

        [Then(@"I filtered Communication related articles with '(.*)'")]
        public void ThenIFilteredCommunicationRelatedArticlesWith(string comCategory)
        {
            string className = "\'category\'";
            checkForOutputAssertion(className, comCategory);

        }
        public void checkForOutputAssertion(string clsName, string checkBoxName) {
            IList<IWebElement> resultCards = null;
            IWebElement aCardContainer = null;
            try
            {
                aCardContainer = webDriver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/div/div[2]/div[1]"));
                ((IJavaScriptExecutor)webDriver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                resultCards = aCardContainer.FindElements(By.XPath("./*"));
            }
            catch (Exception ex)
            {
                aCardContainer = webDriver.FindElement(By.XPath("//*[@id=\"main\"]/section[2]/div/div/div[2]/div[1]"));
                resultCards = aCardContainer.FindElements(By.XPath("./*"));
            }

            Thread.Sleep(600);
            if (resultCards.Count != 0)
            {
                foreach (IWebElement el in resultCards)
                {
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    string xPathStr = String.Format($"//span[@class={clsName}]");
                    string strValue = el.FindElement(By.XPath(xPathStr)).Text;
                    Assert.AreEqual(true, strValue.Equals(checkBoxName));
                }
            }
            else
            {
                Assert.AreEqual(0, resultCards.Count);
            }
        }
    }
}
