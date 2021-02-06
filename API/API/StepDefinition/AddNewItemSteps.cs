using System;
using RestSharp;
using TechTalk.SpecFlow;

namespace API.StepDefinition
{
    [Binding]
    public class AddNewItemSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;


        [Given(@"I perform a POST request")]
        public void GivenIPerformAPOSTRequest()
        {
            client = new RestClient("http://localhost:8000/locations");
            client.Timeout = -1;
            request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6Im5pbHNvbkBlbWFpbC5jb20iLCJwYXNzd29yZCI6Im5pbHNvbiIsImlhdCI6MTYxMTQ3MDI1MiwiZXhwIjoxNjExNDczODUyfQ.UunGOHGXobar5txH9Rw4EDB4eKpyYEw-rdtXrz1Ucs8");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n    \"id\": 4,\r\n    \"name\": \"Location004\"\r\n}", ParameterType.RequestBody);
           
        }
        

        [Then(@"a new item should be added")]
        public void ThenANewItemShouldBeAdded()
        {
            response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
