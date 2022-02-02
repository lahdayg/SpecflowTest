using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Support
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver driver;
        
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}