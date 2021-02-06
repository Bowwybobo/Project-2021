using System;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I have access to the server")]
        public void GivenIHaveAccessToTheServer()
        {
            client = new RestClient("http://localhost:8000/auth/login");
            client.Timeout = -1;
            
        }

        
        [When(@"I enter my login details")]
        public void WhenIEnterMyLoginDetails()
        {
            request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ2Mzc5NiwiZXhwIjoxNjExNDY3Mzk2fQ.jgmwqOkGG3_BEnY2EL4LAduQXyhcStWaS2xz3koQcFY");
            request.AddParameter("text/plain", "{\r\n  \"email\": \"techie@email.com\",\r\n  \"password\":\"techie\"\r\n}", ParameterType.RequestBody);   
            
        }

        
        [Then(@"The result is displayed")]
        public void ThenTheResultIsDisplayed()
        {
            response = client.Execute(request);
        }
    }
}
