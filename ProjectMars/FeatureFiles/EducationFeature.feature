Feature: Functionality around Education Tab

	
 
Scenario Outline: a_ able to create education details
	Given user have logged in
	And user click on the education tab
	And user click add new button for the education
	Then user enter the details for new education
	When user click add button to save new education
    Then user Validate the education is created

 
Scenario Outline:b_ edit education details
	Given user have logged in
    And I click on the education tab	
    When I click edit icon to edit education
    When I enter the details for edited education details
    Then I click update button to save edited education
    Then I Validate the edited education is created

 Scenario Outline:c able to delete education
	Given user have logged in
    And user click on the education tab	
    When user click delete icon to delete education
    Then user Validate the delete education





