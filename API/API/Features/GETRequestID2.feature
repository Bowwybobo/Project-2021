Feature: GET Request ID 2
	Perform a GET request for id 2

@mytag
Scenario: ID 2
	Given I have looged into the API server
	When I perform a new GET request 
	Then I should see the ID displayed under all locations
	