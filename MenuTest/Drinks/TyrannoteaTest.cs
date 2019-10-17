using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        // Correct default price
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<double>(0.99, tt.Price);
        }

        // Correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<uint>(8, tt.Calories);
        }

        // Correct default ice
        [Fact]
        public void HasCorrectDefaultIce()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.True(tt.Ice);
        }

        // correct default lemon
        [Fact]
        public void HasCorrectDefaultLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Lemon);
        }

        // correct default sweet
        [Fact]
        public void HasCorrectDefaultSweet()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Sweet);
        }

        // Correct price after changing to small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Size = Size.Small;
            Assert.Equal<double>(0.99, tt.Price);
        }

        // Correct calories after changing to small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium; // set to something different first
            tt.Size = Size.Small; // then set back to small
            Assert.Equal<uint>(8, tt.Calories);
        }

        // Correct price after changing to medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.Size = Size.Medium;
            Assert.Equal<double>(1.49, tt.Price);
        }

        // Correct calories after changing to medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large; // set to something different first
            tt.Size = Size.Medium; // then set back to small
            Assert.Equal<uint>(16, tt.Calories);
        }

        // Correct price after changing to large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Large;
            Assert.Equal<double>(1.99, tt.Price);
        }

        // Correct calories after changing to large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium; // set to something different first
            tt.Size = Size.Large; // then set back to small
            Assert.Equal<uint>(32, tt.Calories);
        }

        // Invoking HoldIce() causes Ice to be false
        [Fact]
        public void HoldIceShouldCauseIceToBeFalse()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.HoldIce();
            Assert.False(tt.Ice);
        }

        // invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void AddLemonShouldCauseLemonToBeTrue()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            Assert.True(tt.Lemon);
        }

        //setting the sweet property to true results in the right calories for each size
        [Fact]
        public void SweetShouldDoubleCaloriesForSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Small;
            tt.AddSweetener();
            Assert.Equal<uint>(16, tt.Calories);
        }
        [Fact]
        public void SweetShouldDoubleCaloriesForMediumm()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.AddSweetener();
            Assert.Equal<uint>(32, tt.Calories);
        }
        [Fact]
        public void SweetShouldDoubleCaloriesForLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.AddSweetener();
            Assert.Equal<uint>(64, tt.Calories);
        }

        //setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        [Fact]
        public void RemoveSweetShouldResultInCorrectCaloriesForSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Small;
            tt.AddSweetener();
            tt.RemoveSweetener();
            Assert.Equal<uint>(8, tt.Calories);
        }
        [Fact]
        public void RemoveSweetShouldResultInCorrectCaloriesForMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.AddSweetener();
            tt.RemoveSweetener();
            Assert.Equal<uint>(16, tt.Calories);
        }
        [Fact]
        public void RemoveSweetShouldResultInCorrectCaloriesForLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.AddSweetener();
            tt.RemoveSweetener();
            Assert.Equal<uint>(32, tt.Calories);
        }

        //correct ingredients are given.
        [Fact]
        public void HasCorrectIngredients()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Contains("Water", tt.Ingredients);
            Assert.Contains("Tea", tt.Ingredients);

            tt.AddLemon();
            Assert.Contains("Lemon", tt.Ingredients);

            tt.AddSweetener();
            Assert.Contains("Cane Sugar", tt.Ingredients);
        }

        // *********************************************
        // IOrderItem Interface Tests...
        // *********************************************

        [Fact]
        public void HasCorrectDescription()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal("Tyrannotea", tt.Description);
        }

        [Fact]
        public void HasCorrectDefaultSpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Empty(tt.Special);
        }

        [Fact]
        public void HoldIceShouldProvideCorrectSpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.HoldIce();
            Assert.Contains("Hold Ice", tt.Special);
        }

        [Fact]
        public void AddLemonAndSweetenerShouldProvideCorrectSpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            tt.AddSweetener();
            Assert.Contains("Add Lemon", tt.Special);
            Assert.Contains("Add Sweetener", tt.Special);
        }

    }
}
