using System;
using System.Collections.Generic;
using System.Text;
using Xunit; // add this
using DinoDiner.Menu; // add this

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        // Ability to set each flavor
        [Fact]
        public void HasAbilityToSetEachFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        // The correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories); // expected value, item

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
            Assert.True(soda.Ice);
        }

        // The correct default size
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        // correct calories after setting small
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium; // set to something different first
            soda.Size = Size.Small; // then set back to small
            Assert.Equal<uint>(112, soda.Calories);
        }

        // correct price after setting to small
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium; // set to something different first
            soda.Size = Size.Small; // then set back to small
            Assert.Equal<double>(1.50, soda.Price);
        }

        // correct calories after setting medium
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large; // set to something different first
            soda.Size = Size.Medium; // then set back to medium
            Assert.Equal<uint>(156, soda.Calories);
        }

        // correct price after setting medium
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large; // set to something different first
            soda.Size = Size.Medium; // then set back to medium
            Assert.Equal<double>(2.00, soda.Price);
        }

        // correct calories after setting large
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingToLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }
        // correct price after setting large
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingToLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        // invoking HoldIce() 
        [Fact]
        public void HoldIceShouldMakeIcePropertyFalse()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }


        // correct ingredient list
        [Fact]
        public void HasCorrectIngredientsList()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal<int>(3, soda.Ingredients.Count);
        }
    }

}
