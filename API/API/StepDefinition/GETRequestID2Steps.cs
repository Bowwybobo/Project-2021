using System;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class GETRequestID2Steps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;


        [Given(@"I have looged into the API server")]
        public void GivenIHaveLoogedIntoTheAPIServer()
        {
            client = new RestClient("http://localhost:8000/locations");
            client.Timeout = -1;
            
        }


        [When(@"I perform a new GET request")]
        public void WhenIPerformANewGETRequest()
        {
            request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ3Mzk5OSwiZXhwIjoxNjExNDc3NTk5fQ.firy52y6S4YWvbqWuNojwYpcU9-crejVlSvyOuplUV0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"id\": 2,\r\n    \"name\": \"Location002\"\r\n}", ParameterType.RequestBody);
            response = client.Execute(request);
            Console.WriteLine(response.Content);
        }



        [Then(@"I should see the ID displayed under all locations")]
        public void ThenIShouldSeeTheIDDisplayedUnderAllLocations()
        {
            Assert.That(response.StatusCode.ToString() == "OK");
        }
    }
}
