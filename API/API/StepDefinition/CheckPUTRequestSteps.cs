using System;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class CheckPUTRequestSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;


        [Given(@"I have performed a put request")]
        public void GivenIHavePerformedAPutRequest()
        {
            client = new RestClient("http://localhost:8000/locations/4");
            client.Timeout = -1;
            
        }
        

        [When(@"I check to see by performing a GET request")]
        public void WhenICheckToSeeByPerformingAGETRequest()
        {
            request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ3Mzk5OSwiZXhwIjoxNjExNDc3NTk5fQ.firy52y6S4YWvbqWuNojwYpcU9-crejVlSvyOuplUV0");
            response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        

        [Then(@"I should see the updated id")]
        public void ThenIShouldSeeTheUpdatedId()
        {
            Assert.That(response.StatusCode.ToString() == "OK");
        }
    }
}
