Feature: Base Unit of Measures
	in order to convert unit of measures to each other without defining the conversion rate for every single unit
	As a procurement manager
	I want to be able to define a base unit of measure for a dimension

Scenario: Defining a base unit of measure
	Given I have already define a 'Mass' as a dimension
	When I define the folowwing unit of measure
	| Name | Symbol |
	| Gram | gr     |
	And assign it to 'Mass' dimension
	Then 'Gram' is the base unit of measure of 'Mass'

Scenario: Defining more than one base unit of measure for a dimension
	Given I have already define the 'Mass' as a dimension
	And I define the 'gram' as a base unit of measure for 'Mass'
	When I define the following base unit of measure
	| Name     | Symbol |
	| Kilogram | kg     |
	And Assign it to 'Mass' dimension
	Then I should get an error saying that 'The measure already has a base unit of measure'