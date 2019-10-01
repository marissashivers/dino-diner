using System;
using System.Collections.Generic;
using System.Text;
using Xunit; // add this
using DinoDiner.Menu; // add this

namespace MenuTest.Drinks
{
    public class JurrassicJavaTest
    {
        // Correct default price
        [Fact]
        public void HasCorrectDefaultPriceProperty()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(0.59, java.Price);
        }

        // Correct default calories
        [Fact]
        public void HasCorrectDefaultCaloriesProperty()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        // Correct default ice
        [Fact]
        public void HasCorrectDefaultIceProperty()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }
        
        // Correct default size
        [Fact]
        public void HasCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        
        // Correct default SpaceForCream
        [Fact]
        public void HasCorrectDefaultSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.RoomForCream);
        }

        // Correct price after changing to small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium; // set to something different first
            java.Size = Size.Small; // then set back to small
            Assert.Equal<double>(0.59, java.Price);
        }
        // Correct calories after changing to small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium; // set to something different first
            java.Size = Size.Small; // then set back to small
            Assert.Equal<uint>(2, java.Calories);
        }

        // Correct price after changing to medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large; // set to something different first
            java.Size = Size.Medium; // then set back to small
            Assert.Equal<double>(0.99, java.Price);
        }
        // Correct calories after changing to medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large; // set to something different first
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        // Correct price after changing to large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium; // set to something different first
            java.Size = Size.Large; // then set back to small
            Assert.Equal<double>(1.49, java.Price);
        }
        // Correct calories after changing to large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium; // set to something different first
            java.Size = Size.Large; // then set back to small
            Assert.Equal<uint>(8, java.Calories);
        }

        // Invoking AddIce() causes Ice to be true
        [Fact]
        public void AddIceShouldCauseIceToBeTrue()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        // Invoking LeaveSpaceForCream() results in SpaceForCream to be true
        [Fact]
        public void LeaveSpaceForCreamShouldMakeCreamTrue()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        // Correct ingredients list
        [Fact]
        public void HasCorrectIngredientsList()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains("Water", java.Ingredients);
            Assert.Contains("Coffee", java.Ingredients);
        }
    }
}
