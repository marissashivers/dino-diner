using System;
using System.Collections.Generic;
using System.Text;
using Xunit; // add this
using DinoDiner.Menu.Drinks; // add this

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        // The correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(12, soda.Calories); // expected value, item

        }

        // The correct default price
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        // The correct default ice
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(true, soda.Ice);
        }
        // The correct default size

        // correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium; // set to something different first
            soda.Size = Size.Small; // then set back to small
            Assert.Equal<uint>(112, soda.Calories);
        }
        // correct price after setting small

        // correct calories after setting medium
        // correct price after setting medium

        // correct calories after setting large
        // correct price after setting large

        // invoking HoldIce() 
    }

}
