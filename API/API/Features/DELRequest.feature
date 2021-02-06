Feature: DELRequest
	Delete the updated id for locations/4

@mytag
Scenario: Delete Request
	Given I have access to the updated record
	When I perform the request
	Then I should see it removed from the system
	