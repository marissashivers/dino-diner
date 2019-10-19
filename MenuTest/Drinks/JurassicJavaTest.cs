using System;
using System.Collections.Generic;
using System.Text;
using Xunit; // add this
using DinoDiner.Menu; // add this

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        // Correct default price
        [Fact]
        public void HasCorrectDefaultPriceProperty()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        // Correct default calories
        [Fact]
        public void HasCorrectDefaultCaloriesProperty()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        // Correct default ice
        [Fact]
        public void HasCorrectDefaultIceProperty()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }
        
        // Correct default size
        [Fact]
        public void HasCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        
        // Correct default SpaceForCream
        [Fact]
        public void HasCorrectDefaultSpaceForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        // Correct price after changing to small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium; // set to something different first
            java.Size = Size.Small; // then set back to small
            Assert.Equal<double>(0.59, java.Price);
        }
        // Correct calories after changing to small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium; // set to something different first
            java.Size = Size.Small; // then set back to small
            Assert.Equal<uint>(2, java.Calories);
        }

        // Correct price after changing to medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large; // set to something different first
            java.Size = Size.Medium; // then set back to small
            Assert.Equal<double>(0.99, java.Price);
        }
        // Correct calories after changing to medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large; // set to something different first
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        // Correct price after changing to large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium; // set to something different first
            java.Size = Size.Large; // then set back to small
            Assert.Equal<double>(1.49, java.Price);
        }
        // Correct calories after changing to large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium; // set to something different first
            java.Size = Size.Large; // then set back to small
            Assert.Equal<uint>(8, java.Calories);
        }

        // Invoking AddIce() causes Ice to be true
        [Fact]
        public void AddIceShouldCauseIceToBeTrue()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        // Invoking LeaveSpaceForCream() results in SpaceForCream to be true
        [Fact]
        public void LeaveSpaceForCreamShouldMakeCreamTrue()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        // Correct ingredients list
        [Fact]
        public void HasCorrectIngredientsList()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains("Water", java.Ingredients);
            Assert.Contains("Coffee", java.Ingredients);
        }

        // *********************************************
        // IOrderItem Interface Tests...
        // *********************************************

        [Fact]
        public void HasCorrectDescription()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal("Jurassic Java", java.Description);
        }

        [Fact]
        public void HasCorrectDefaultSpecial()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        // add ice
        [Fact]
        public void AddIceShouldProvideCorrectSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Contains("Add Ice", java.Special);
        }

        // leave room for cream
        [Fact]
        public void LeaveRoomForCreamShouldProvideCorrectSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Contains("Leave Room For Cream", jj.Special);
        }

        // add ice and leave room for cream
        [Fact]
        public void AddIceAndLeaveRoomForCreamShouldProvideCorrectSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            jj.LeaveRoomForCream();
            Assert.Contains("Add Ice", jj.Special);
            Assert.Contains("Leave Room For Cream", jj.Special);
        }
    }
}
