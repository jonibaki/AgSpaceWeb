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

        public void clickInnovationMenu(IWebElement we) {
            we.Click();
        }
        public string getTitle() {
            return WebDriver.Title;
        }
    
    }

}
