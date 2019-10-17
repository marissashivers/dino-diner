/*  IOrderItem.cs
*   Author: Marissa Shivers
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for an order item, for the Point of Sale.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Getter for price property
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Getter for description property, which is the same as the ToString() implementation
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Contains any special instructions for the food preparation, such as "Hold Ketchup"
        /// as specified by the Menu Item
        /// </summary>
        string[] Special { get; }
    }
}
