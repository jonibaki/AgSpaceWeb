Feature: Filter Articles
	As a User
	I want to find out  certain articles depending on different filter values

@smoke
Scenario Outline: Check Filters Funtionality 
	Given I browse AgSpace website

	When I click What's New from Nav bar
	Then I navigate What's New page

	When I toggle on only Product <ProductId>
	Then I filtered product related articles with '<ProductName>' and '<ProductImg>'
	Examples: 
		| ProductId | ProductName | ProductImg       |
		| 0         | Contour     | contour-logo-big |
		| 1         | General     | general			 |
		| 2         | GRID		  | grid-logo-big    |

@smoke
Scenario Outline: Check Market Filters Funtionality 
	Given I refresh AgSpace website 
	And I navigate to What's New page

	When I toggle on only Market <MarketId>
	Then I filtered Market related articles with '<MarketName>'
	Examples: 
		| MarketId | MarketName |
		| 0        | Africa     |
		| 1        | Contour    |
		| 2        | Global     |
		| 3        | UK         |

@smoke
Scenario Outline: Check Communication Filters Funtionality 
	Given I land AgSpace website 
	And I click to What's New page

	When I toggle on only Communication <CommunicationId>
	Then I filtered Communication related articles with '<CommunicationName>'
	Examples: 
		| CommunicationId | CommunicationName |
		| 0               | Blog              |
		| 1               | Case Study        |
		| 2               | PR                |
		| 3               | Release Note      |
		| 4               | Uncategorised     |


#	When I toogle on only date range
#	Then I filtered date range related article

#	When I toogle on multiple categories
#	Then I filtered multiple categories related articles

