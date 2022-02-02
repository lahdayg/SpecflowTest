using SpecFlowProject1.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestStepDefinitions
    {
        TestPage testPage;

        public TestStepDefinitions()
        {
            testPage = new TestPage();
        }







        [Given(@"I navigate to www\.google\.com")]
        public void GivenINavigateToWww_Google_Com()
        {
            testPage.NavigateToWebsite();

        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            throw new PendingStepException();
        }

        

    }
}
