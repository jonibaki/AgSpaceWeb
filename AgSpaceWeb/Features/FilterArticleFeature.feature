Feature: Filter Articles
	As a User
	I want to find out  certain articles depending on different filter values

@smoke
Scenario: Check Filters Funtionality 
	Given I browse AgSpace website

	When I click What's New from Nav bar
	Then I navigate What's New page
	
	When I toggle on only product
	Then I filtered product related articles

	When I toggle on only market
	Then I filtered market related articles

	When I toogle on only communication
	Then I filtered communication related articles

	When I toogle on only date range
	Then I filtered date range related article

	When I toogle on multiple categories
	Then I filtered multiple categories related articles



