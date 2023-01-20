Feature: Scenario
	SignUp using Automation

@mytag
Scenario Outline: Registration 
	Given Navigate to the URL,Click on Signup,Click on Provider.
	And Fill the Required details <title>,<fullname>,<email>,<licensenumber>,<npinumber>,<phonenumber> and <website>.
	When Click on Signup button.
	Then Registration done successfully message should popup, click on OK.

	@source:Credentials.xlsx
	Examples: 
	     |title|fullname|email|licensenumber|npinumber|phonenumber|website|



@mytag
Scenario Outline: Login into application
	Given Navigatte to the URL,Click on Signup,Click on Provider.
	And Fill the Reequired details <title>,<fullname>,<email>,<licensenumber>,<npinumber>,<phonenumber> and <website>.
	When Click on Siignup button.
	Then Registratioon done successfully message should popup, click on OK.

	@source:Credentials.xlsx
	Examples: 
	     |title|fullname|email|licensenumber|npinumber|phonenumber|website|