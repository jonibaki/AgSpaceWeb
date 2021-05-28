using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgSpaceWeb
{
    public class HomePage
    {
        public IWebDriver WebDriver { get; }
        public HomePage(IWebDriver wd) {
            WebDriver = wd;
        }

        public void ClickNavMenu(IWebElement we) {
            we.Click();
        }

        public void ClickButton(IWebElement we)
        {
            we.Click();
        }
        public string getTitle() {
            return WebDriver.Title;
        }
    
    }

}
