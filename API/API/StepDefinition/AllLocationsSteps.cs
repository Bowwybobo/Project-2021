using System;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class AllLocationsSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I have logged in on the server")]
        public void GivenIHaveLoggedInOnTheServer()
        {
            client = new RestClient("http://localhost:8000/locations");
            client.Timeout = -1;
           
        }

        
        [When(@"I test to get all locations")]
        public void WhenITestToGetAllLocations()
        {
            request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ3Mzk5OSwiZXhwIjoxNjExNDc3NTk5fQ.firy52y6S4YWvbqWuNojwYpcU9-crejVlSvyOuplUV0");
            response = client.Execute(request);

        }

        
        [Then(@"All locations should display")]
        public void ThenAllLocationsShouldDisplay()
        {
            Assert.That(response.StatusCode.ToString() == "OK");
               
        }
    }
}
