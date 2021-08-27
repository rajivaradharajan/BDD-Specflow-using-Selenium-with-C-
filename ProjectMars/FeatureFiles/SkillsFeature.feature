Feature: Funtionality around Skills Tab 
	
 
Scenario Outline: 1 I am able to create skill details
	Given I have logged into the application
     And I click on the skills tab
    And I click add new button for the skills
    And I enter the details for new skills
    And I click add button to save new skills
    Then Validate the skills is created

Scenario Outline: 2 Edit skill details
    Given I have logged into the application
    And I click on the skills tab
    When you click edit button
    Then enter the edit details
    And click add new btn to save edit
    Then I validate the result

Scenario Outline: 3 I am able to delete skills
	Given I have logged in
    And I click on the skill tab	
    And I click delete icon to delete skill
    Then I Validate the delete skill