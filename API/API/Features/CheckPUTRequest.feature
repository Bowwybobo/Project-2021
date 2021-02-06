Feature: CheckPUTRequest
	Perform a GET request to make sure the update was carried out

@mytag
Scenario: GET Request for locations/4
	Given I have performed a put request
	When I check to see by performing a GET request
	Then I should see the updated id