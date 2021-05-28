Feature: Download Web Contents
	As a User
	I want to download contents from agSpace

@smoke
Scenario: Download Contour
	Given I go to agSpace website
	And I navigate to Contour page
	When I click  download button on Contour Page
	Then I download the Contour contents

@smoke
Scenario: Download Grid
	Given I browse agSpace web site
	And I navigate to Grid page
	When I click download button on Grid Page
	Then I download the Grid contents