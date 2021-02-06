Feature: CarSearch
	Search for any car of your choice 

@mytag
Scenario: Car Search on Auto Trader
	Given I Navigate to "https://www.autotrader.co.uk/search-form?moreOptions"
	And I Click to accept popup message
	And I Enter my postcode "SE1 0SA"
	And I Select a national distance
	And I Select a make
	And I Select a body type
	When I Click on search
	#Then My Results should disay