Feature: PUTRequest
	Perform a PUT request 

@mytag
Scenario: Location/4
	Given I already created item id 4
	Then I should be able to do an update on it
	