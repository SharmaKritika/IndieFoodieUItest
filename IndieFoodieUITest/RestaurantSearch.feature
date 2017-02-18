Feature: Restaurant
	In order to find a restaurant 
	as a customer 
	I can search by postcode

@SearchRestaurant
Scenario: Can search the list of restaurants based on postcode or suburb name
	Given User wants to search a restaurant in some specific area
	When User searches by the postcode or suburb name
	Then The list of retaurants matching the postcode or suburb name is displayed

@SelectDishes
Scenario: Can select multiple dishes for a restaurant
	Given User selected a restaurant 
	And see the list of dishes
	When User selects multiple dishes
	Then Dishes are selected

@PlaceOrder
Scenario: Can place order with multiple dishes
	Given User has selected a restaurant
	And selected multiple dishes
	When User places order
	Then The order is placed with total price

