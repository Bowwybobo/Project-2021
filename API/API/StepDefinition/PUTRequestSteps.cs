using System;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class PUTRequestSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;


        [Given(@"I already created item id (.*)")]
        public void GivenIAlreadyCreatedItemId(int p0)
        {
            client = new RestClient("http://localhost:8000/locations/4");
            client.Timeout = -1;
            request = new RestRequest(Method.PUT);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ3Mzk5OSwiZXhwIjoxNjExNDc3NTk5fQ.firy52y6S4YWvbqWuNojwYpcU9-crejVlSvyOuplUV0");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"id\": 4,\r\n    \"name\": \"Location005\"\r\n}", ParameterType.RequestBody);
            response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        

        [Then(@"I should be able to do an update on it")]
        public void ThenIShouldBeAbleToDoAnUpdateOnIt()
        {
            Assert.That(response.StatusCode.ToString() == "OK");
        }
    }
}
