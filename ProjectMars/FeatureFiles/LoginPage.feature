Feature: Login Page  
 
Scenario: When a valid creds are used should result login sucessfull
	Given I am at the login page
	And I validate that i am at the login page
	When I enter valid creds
	And I click the login button
	Then I should be logged in sucessfully
 
Scenario: When invalid username is used should result login failed
	Given I am at the login page
	And I validate that i am at the login page
	When I login with username 'chandru.lawrence'
	And I click the login button
	Then I should be not logged in sucessfully
 
Scenario: When valid username and password should result login successful
	Given I am at the login page
	And I validate that i am at the login page
	When I login with <username> and with <password>
	And I click the login button
	Then I should be logged in sucessfully

	Examples:
	|username| password |
	|chandru.lawrence@gmail.com|acer5610|