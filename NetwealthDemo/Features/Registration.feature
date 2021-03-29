Feature: Registration
	In order to try Netwealth services, the user needs to register

Background:
	Given the user navigates to the website "https://dev.id.netwealth.com/account/registernew"
	And user accepts cookies
	
	

@mytag
Scenario: Valid Registration
	And user enters first name "Test"
	And user enters last name "Data"
	And user enters email "netdemo"
	And user enters password "Password@2021"
	And user selects where they heard about Netwealth
	And user selects whether to receive optional updates
	When user clicks on the Try Netwealth button
	Then the user should be registered successfully



Scenario: Invalid First Name
	And user enters last name "Data"
	And user enters the email "netdemo@gmail.com"
	And user enters password "Password@2021"
	And user selects where they heard about Netwealth
	And user selects whether to receive optional updates
	When user clicks on the Try Netwealth button
	Then user should be prompted to enter first name
	


Scenario: Invalid Last Name
	And user enters first name "Test"
	And user enters the email "netdemo@gmail.com"
	And user enters password "Password@2021"
	And user selects where they heard about Netwealth
	And user selects whether to receive optional updates
	When user clicks on the Try Netwealth button
	Then user should be prompted to enter the last name 



Scenario: Invalid Email
	And user enters first name "Test"
	And user enters last name "Data"
	And user enters the email "netdemo#gmail.com"
	And user enters password "Password@2021"
	And user selects where they heard about Netwealth
	And user selects whether to receive optional updates
	When user clicks on the Try Netwealth button
	Then user should be prompted to enter a valid email



Scenario: Invalid Password
	And user enters first name "Test"
	And user enters last name "Data"
	And user enters the email "netdemo@gmail.com"
	And user enters password "Password20"
	And user selects where they heard about Netwealth
	And user selects whether to receive optional updates
	When user clicks on the Try Netwealth button
	Then user should be prompted to enter a valid password



