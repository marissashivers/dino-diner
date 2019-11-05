/*
 * File name: OrderTest.cs
 * Author: Marissa Shivers
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        // TEST #1 FOR ORDERING STUFF
            // Prehistoric PBJ, hold PB: $6.52
            // Medium Fryceritops: $1.45
            // Large Sodasaurus (Chocolate flavor): $2.50
            // TOTAL = $10.47
        [Fact]
        public void TestOneForExpectedCost()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();

            Fryceritops fries = new Fryceritops();
            fries.Size = Size.Medium;

            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Flavor = SodasaurusFlavor.Chocolate;

            Order first = new Order();
            first.Add(pbj);
            first.Add(fries);
            first.Add(soda);

            Assert.Equal<double>(10.47, first.SubtotalCost);
            Assert.Equal<double>(1.57, first.SalesTaxCost);
            Assert.Equal<double>(12.04, first.TotalCost);
        }

        // TEST #2 FOR ORDERING STUFF
            // DinoNuggets, add 2 nuggets: $4.75
            // Large Mezzorella Sticks: $1.95
            // Large Jurassic Java: $1.49
        [Fact]
        public void TestTwoForExpectedCost()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            dn.AddNugget();

            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = Size.Large;

            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;

            Order second = new Order();
            second.Add(dn);
            second.Add(ms);
            second.Add(jj);

            Assert.Equal<double>(8.19, second.SubtotalCost);
            Assert.Equal<double>(1.23, second.SalesTaxCost);
            Assert.Equal<double>(9.42, second.TotalCost);
        }

        [Fact]
        public void SubtotalCostShouldNotBeNegative()
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Price = -0.99;

            Order testOrder = new Order();
            testOrder.Add(ms);

            Assert.Equal<double>(0.00, testOrder.SubtotalCost);
        }
    }
}
