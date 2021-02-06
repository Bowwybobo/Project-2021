Feature: GETRequestID3
	GET request to confirm id:3 is under locations

@mytag
Scenario: GET Request for ID 3
	Given I am connected to the API server
	When I perform a GET request for ID 
	Then I should see the specific ID number i want under all locations