Feature: Perform a POST request to add a new item
	

@mytag
Scenario: New item under location
	Given I perform a POST request
	Then a new item should be added
	