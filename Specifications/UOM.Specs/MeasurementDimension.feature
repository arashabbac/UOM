Feature: Managing Measurement Dimensions
	in order to categorize unit of measures and convert them to each other only in their dimensions 
	As a procurement manager
	I want to be able to define measurement dimensions

Scenario: Defining dimension
	Given I have entered as a procurement manager
	When I define the following dimension
	| Name | Symbol |
	| Mass | m      |
	Then I should be able to see the dimension in the list of dimensions