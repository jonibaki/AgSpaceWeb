using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AgSpaceWeb.Hook
{
    [Binding]
    public sealed class AgSpaceHooks
    {
        public static HomePage home = null;
        public static IWebDriver webDriver = null;

        [BeforeFeature]
        public static void BeforeScenario()
        {
            /*            webDriver = new ChromeDriver();
                        webDriver.Navigate().GoToUrl("https://ag-space.com/");
                        webDriver.Manage().Window.Maximize();
                        home = new HomePage(webDriver);*/
            Console.WriteLine("Before");
        }

        [AfterFeature]
        public static void AfterScenario()
        {
            Console.WriteLine("After");
            /*            webDriver.Quit();*/
        }
    }
}
