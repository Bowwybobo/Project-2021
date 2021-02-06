using System;
using AutoTrader.PageObject;
using TechTalk.SpecFlow;

namespace AutoTrader.StepDef
{
    [Binding]
    public class CarSearchSteps
    {
        CarSearchPage carSearchPage;

        public CarSearchSteps()
        {
            carSearchPage = new CarSearchPage();
        }


        [Given(@"I Navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            carSearchPage.NavigateToWebsite(url);
        }

        [Given(@"I Click to accept popup message")]
        public void GivenIClickToAcceptPopupMessage()
        {
            carSearchPage.ClickAccept();
        }


        [Given(@"I Enter my postcode ""(.*)""")]
        public void GivenIEnterMyPostcode(string postcode)
        {
            carSearchPage.EnterPostCode(postcode);
        }
        

        [Given(@"I Select a national distance")]
        public void GivenISelectANationalDistance()
        {
            carSearchPage.SelectDistance();
        }
        

        [Given(@"I Select a make")]
        public void GivenISelectAMake()
        {
            carSearchPage.SelectMake();
        }
        
        

        [Given(@"I Select a body type")]
        public void GivenISelectABodyType()
        {
            carSearchPage.ClickBodyType();
        }
        

        [When(@"I Click on search")]
        public void WhenIClickOnSearch()
        {
            carSearchPage.ClickSearch();
        }
        

        [Then(@"My Results should disay")]
        public void ThenMyResultsShouldDisay()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
