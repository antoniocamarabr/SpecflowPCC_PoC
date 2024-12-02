Feature: Polynesia Shopping
    Verify the shopping polynesia page

    @Shop
    Scenario: Verify the Shop ISLAND GIFTS link
        Given I navigate to the Polynesia homepage
        When I am able to see in shop area 'Shop ISLAND GIFTS!'
        Then I click on the 'Shop ISLAND GIFTS' link
        And I verify the polynesia shopping page
       
    Scenario: Verify the Shop POLYNESIA link
        Given I navigate to the Polynesia homepage
        When I am able to see in shop area 'SHOP POLYNESIA'
        Then I click on the 'SHOP POLYNESIA' link
        And I verify the polynesia shopping page