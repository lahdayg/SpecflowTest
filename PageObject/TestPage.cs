using OpenQA.Selenium;
using SpecFlowProject1.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.PageObject
{
    class TestPage
    {
        public TestPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement HelloSignIn => driver.FindElement(By.XPath("//span[text()='Hello, Sign in']"));


        public void ClickOnHelloSignIn()
        {
            HelloSignIn.Click();
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }






    }
}
