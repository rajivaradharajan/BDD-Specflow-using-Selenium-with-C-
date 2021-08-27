Feature: Functionality around Language Page
	
 
Scenario: I am able to create language
	Given I am logged in
	And I am at the language page 
	When I click the create add new button
	And Enter the details for new language
	And Click add to save language
	Then Validate the language is created



Scenario: I am able to edit the language
	Given I am logged in
    And I am at the language page
    When I click the edit button
    And I edit the details
    And I click update to save language
    Then Validate that lang I edited was saved


Scenario: I am able to delete the language
	Given I am logged in
    And I am at the language page
    And I click delete button
    Then I have to validate the language and it deleted