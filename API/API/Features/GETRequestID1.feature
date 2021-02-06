Feature: GET Request ID 1
	Test GET Location where ID is 1

@mytag
Scenario: Location 1
	Given I am in the server
	When I test to get the info of the above location
	Then I should see the full info of that location