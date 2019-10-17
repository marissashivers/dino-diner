/*  IMenuItem.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for a menu item. Includes getters for price, calories, and ingredient list
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Getter for price
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Getter for calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Getter for ingredient list
        /// </summary>
        List<string> Ingredients { get; }
    }
}
