Feature: Contact Details
	As a User
	I want access and retreive the correct contact details

@smoke
Scenario: Verify Contact Details
	Given I browse agSpace web page
	When I click contact from nav menu
	Then Verify contact <Call AgSpace:> and <Email AgSpace:> details

	Examples: 
	| Call AgSpace:     | Email AgSpace:   |
	| (+44) 01793 437999 | info@ag-space.com |