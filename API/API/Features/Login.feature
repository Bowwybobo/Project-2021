Feature: Login
	Test to see if i can login to the API with my details

@mytag
Scenario: Login
	Given I have access to the server
	When I enter my login details 
	Then The result is displayed