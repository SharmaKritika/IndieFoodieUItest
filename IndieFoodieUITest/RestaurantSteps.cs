using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace IndieFoodieUITest
{
    [Binding]
    public class RestaurantSteps
    {
        [Given(@"User wants to search a restaurant in some specific area")]
        public void GivenUserWantsToSearchARestaurantInSomeSpecificArea()
        {
            UIHelper.NavigateToRestaurantSearch();
        }
        
        [Given(@"User selected a restaurant")]
        public void GivenUserSelectedARestaurant()
        {
            UIHelper.NavigateToDishes();
        }
        
        [Given(@"see the list of dishes")]
        public void GivenSeeTheListOfDishes()
        {
           // no need to do anything here.
        }
        
        [Given(@"User has selected a restaurant")]
        public void GivenUserHasSelectedARestaurant()
        {
            UIHelper.NavigateToDishes();
        }
        
        [Given(@"selected multiple dishes")]
        public void GivenSelectedMultipleDishes()
        {
            UIHelper.SelectMenuItems();
        }
        
        [When(@"User searches by the postcode or suburb name")]
        public void WhenUserSearchesByThePostcodeOrSuburbName()
        {
            UIHelper.SearchRestaurant();
        }
        
        [When(@"User selects multiple dishes")]
        public void WhenUserSelectsMultipleDishes()
        {
            UIHelper.SelectMenuItems();
        }
        
        [When(@"User places order")]
        public void WhenUserPlacesOrder()
        {
            UIHelper.PlaceOrder();
        }
        
        [Then(@"The list of retaurants matching the postcode or suburb name is displayed")]
        public void ThenTheListOfRetaurantsMatchingThePostcodeOrSuburbNameIsDisplayed()
        {
            UIHelper.VerifyRestaurants();
        }
        
        [Then(@"Dishes are selected")]
        public void ThenDishesAreSelected()
        {
            UIHelper.VerifyMenuItemsSelected();
        }
        
        [Then(@"The order is placed with total price")]
        public void ThenTheOrderIsPlacedWithTotalPrice()
        {
            UIHelper.VerifyOrderPlaced();
        }
    }
}
