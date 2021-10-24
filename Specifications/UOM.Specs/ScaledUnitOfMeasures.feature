Feature: Scaled Unit of Measures
	In order to convert unit of measure that are convertable to base with a conversion rate
	As a procurement manager
	I want to be able to define scaled unit of measure

Background: 
	Given I have define the 'Mass' as a dimension

Scenario: Defining a scaled unit of measure
	Given I have defined the 'Gram' as a base unit of measure for 'Mass'
	When I define the following scaled unit of measure
	| Name     | Symbol | Dimension | ConversionRate   |
	| Kilogram | KG     | Mass      | 1000             |
	Then I sholud be able to see a 'Kilogram' in the list of unit of measures of 'Mass'

Scenario: Converting scaled unit of measure to base
	Given I have defined the 'Gram' as a base unit of measure for 'Mass'
	And I have defined the following scaled unit of measure
	| Name     | Symbol | Dimension | ConversionRate   |
	| Kilogram | KG     | Mass      | 1000             |
	When I convert the '20KG' to 'Gram'
	Then The result should be '20000 g'

Scenario: Converting a scaled unit of measure to another
	Given I have defined the 'Gram' as a base unit of measure for 'Mass'
	And I have defined the following scaled unit of measure
	| Name     | Symbol | Dimension | ConversionRate   |
	| Kilogram | KG     | Mass      | 1000             |
	And I have defined the following unit of measure
	| Name     | Symbol | Dimension | ConversionRate   |
	| Tonne	   | TN     | Mass      | 1000000          |
	When I convert the '20Tn' to 'Kilogram'
	Then The result should be '20000kg'