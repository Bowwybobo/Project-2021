Feature: AllLocations
	Test GET All Locations

@mytag
Scenario: All Locations
	Given I have logged in on the server
	When I test to get all locations
	Then All locations should display