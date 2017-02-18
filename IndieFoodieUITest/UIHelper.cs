using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndieFoodieUITest
{
    class UIHelper
    {
        static ChromeDriver driver = new ChromeDriver();

        static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        

        public static void NavigateToRestaurantSearch()
        {
            driver.Navigate().GoToUrl("http://localhost/");
            wait.Until(driver => driver.FindElement(By.LinkText("Restaurants")).Displayed);
            driver.FindElementByLinkText("Restaurants").Click();
        }

        public static void NavigateToDishes()
        {
            UIHelper.NavigateToRestaurantSearch();
            UIHelper.SearchRestaurant();
            UIHelper.SelectRestaurant();
        }        

        public static void SearchRestaurant()
        {
            wait.Until(driver => driver.FindElement(By.Id("searchKey")).Displayed);
            driver.FindElementById("searchKey").SendKeys("4300");

            wait.Until(driver => driver.FindElement(By.Id("searchButton")).Displayed);
            driver.FindElementById("searchButton").Click();
        }

        public static void SelectRestaurant()
        {
            wait.Until(driver => driver.FindElement(By.Id("restaurantList")).Displayed);
            var restaurants = driver.FindElementsByClassName("restaurant");
            var restaurant = restaurants[0].FindElement(By.LinkText("Punjabi Curry"));
            restaurant.Click();
        }

        public static void SelectMenuItems()
        {
            wait.Until(driver => driver.FindElement(By.Id("menuItems")).Displayed);
            var menuItems = driver.FindElementsByClassName("menuItemChkBox");

            menuItems[0].Click();
            menuItems[3].Click();
        }

        public static void PlaceOrder()
        {
            driver.FindElementById("placeOrderButton").Click();
        }

        public static void VerifyRestaurants()
        {
            wait.Until(driver => driver.FindElement(By.Id("restaurantList")).Displayed);
            var restaurants = driver.FindElementsByClassName("restaurant");
            Assert.AreEqual(2, restaurants.Count());
        }

        public static void VerifyMenuItemsSelected()
        {
            var selectedMenuItems = driver.FindElementsByClassName("menuItemChkBox")
                .Where(e => e.Selected);
            Assert.AreEqual(2, selectedMenuItems.Count());
        }

        public static void VerifyOrderPlaced()
        {
            wait.Until(driver => driver.FindElement(By.Id("orderPlacedTitle")).Displayed);
            var totalPrice = driver.FindElementById("totalPrice");
            Assert.AreEqual("35", totalPrice.Text);
        }


    }
}
