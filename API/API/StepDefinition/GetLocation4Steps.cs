using System;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class GetLocation4Steps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;


        [Given(@"I have successfully created a new ID")]
        public void GivenIHaveSuccessfullyCreatedANewID()
        {
            client = new RestClient("http://localhost:8000/locations");
            client.Timeout = -1;
            request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ3Mzk5OSwiZXhwIjoxNjExNDc3NTk5fQ.firy52y6S4YWvbqWuNojwYpcU9-crejVlSvyOuplUV0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"id\": 4,\r\n    \"name\": \"Location004\"\r\n}", ParameterType.RequestBody);
            response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        

        [Then(@"I should see it under all locations")]
        public void ThenIShouldSeeItUnderAllLocations()
        {
            Assert.That(response.StatusCode.ToString() == "OK");
        }
    }
}
