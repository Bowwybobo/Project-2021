using System;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class Location1Steps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;


        [Given(@"I am in the server")]
        public void GivenIAmInTheServer()
        {
            client = new RestClient("http://localhost:8000/locations");
            client.Timeout = -1;
            
        }


        [When(@"I test to get the info of the above location")]
        public void WhenITestToGetTheInfoOfTheAboveLocation()
        {
         
            request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ3Mzk5OSwiZXhwIjoxNjExNDc3NTk5fQ.firy52y6S4YWvbqWuNojwYpcU9-crejVlSvyOuplUV0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"id\": 1,\r\n    \"name\": \"Location001\"\r\n}", ParameterType.RequestBody);
            response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        

        [Then(@"I should see the full info of that location")]
        public void ThenIShouldSeeTheFullInfoOfThatLocation()
        {
            Assert.That(response.Content.Length > 0);
        }

    }
}
