using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        // correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.10, w.Price);
        }
        // correct default calories
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }
        // correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }
        // correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }
        // correct default lemon
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Water w = new Water();
        }

        // correct price/calories after changign to s/m/l
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterChangingSizes()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);

            w.Size = Size.Medium;
            Assert.Equal<double>(0.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);

            w.Size = Size.Small;
            Assert.Equal<double>(0.10, w.Price);
            Assert.Equal<uint>(0, w.Calories);
        }

        // hold ice causes ice to be false
        [Fact]
        public void HoldIceShouldCauseIceToBeFalse()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        // add lemon causes lemon to be true
        [Fact]
        public void AddLemonShouldCauseLemonToBeTrue()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        // correct ingredients
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Contains("Water", w.Ingredients);
            Assert.Contains("Lemon", w.Ingredients);
        }
    }
}
