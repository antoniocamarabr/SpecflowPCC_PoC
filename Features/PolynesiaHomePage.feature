Feature: HomePage
	Launch HomePage and verify the areas

	Scenario: Verify the popup to win a free trip to Hawai
		Given I navigate to the Polynesia homepage
		When I wait the page loads
		Then I am able to see the Win a Free Trip to Hawai popup
		And I verify the popup text 'Enter to win a FREE Trip to Hawaiʻi!'
	
	Scenario: Close the popup to win a free trip to Hawai
		Given I navigate to the Polynesia homepage
		When I wait the page loads
		Then I am able to close the Win a Free Trip to Hawai popup
		
	Scenario: Verify Shop Area on Polynesia HomePage
		Given I navigate to the Polynesia homepage
		When I wait the page loads
		Then I am able to see in shop area 'Shop ISLAND GIFTS!' and 'SHOP POLYNESIA' labels
		And I am able to see in language area 'English' idiom