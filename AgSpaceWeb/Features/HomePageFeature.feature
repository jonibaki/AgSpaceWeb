Feature: Navigate Menus
	as a User
	I want to navigate to the correct URL

@smoke
Scenario: Navigate to Innovation page
	Given I browse the agSpace website for Innovation
	When I click the Innovation 
	Then I land on Innovation page

@smoke
Scenario: Navigate to Big Data page
	Given I browse the agSpace website for Big Data
	When I click the Big Data 
	Then I land on Big Data page

@smoke
Scenario: Navigate to Earth Observation page
	Given I browse the agSpace website for Observation
	When I click the Earth Observation 
	Then I land on Earth Observation  page

@smoke
Scenario: Navigate to Contour page
	Given I browse the agSpace website for Contour
	When I click the Contour 
	Then I land on Contour page

@smoke
Scenario: Navigate to Grid page
	Given I browse the agSpace website for Grid
	When I click the Grid 
	Then I land on Grid page

@smoke
Scenario: Navigate to What's New page
	Given I browse the agSpace website for What's New
	When I click the What's New 
	Then I land on What's New page

@smoke
Scenario: Navigate to Contact page
	Given I browse the agSpace website for Contact
	When I click the Contact 
	Then I land on Contact page

