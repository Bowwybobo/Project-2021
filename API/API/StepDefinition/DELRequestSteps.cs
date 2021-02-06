using System;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class DELRequestSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I have access to the updated record")]
        public void GivenIHaveAccessToTheUpdatedRecord()
        {
            client = new RestClient("http://localhost:8000/locations/4");
            client.Timeout = -1;
            
        }
        

        [When(@"I perform the request")]
        public void WhenIPerformTheRequest()
        {
            request = new RestRequest(Method.DELETE);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ3Mzk5OSwiZXhwIjoxNjExNDc3NTk5fQ.firy52y6S4YWvbqWuNojwYpcU9-crejVlSvyOuplUV0");
            request.AddParameter("text/plain", "", ParameterType.RequestBody);
            response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
        

        [Then(@"I should see it removed from the system")]
        public void ThenIShouldSeeItRemovedFromTheSystem()
        {
            Assert.That(response.StatusCode.ToString() == "OK");
        }
    }
}
