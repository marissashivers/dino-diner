/*
 * File name: Order.cs
 * Author: Marissa Shivers
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a new customer order
    /// </summary>
    public class Order
    {
        // private backing variable
        private ObservableCollection<IOrderItem> _items;

        /// <summary>
        /// Items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new ObservableCollection<IOrderItem>();
                }
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Calculates total cost from prices of all order items
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }

                if (subtotal < 0) subtotal = 0.00;
                subtotal = Math.Round(subtotal, 2);
                return subtotal;
            }
        }

        /// <summary>
        /// Sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// SalesTaxCost: product of SalesTaxRate and SubtotalCost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return Math.Round(this.SubtotalCost * this.SalesTaxRate, 2);
            }
        }

        /// <summary>
        /// Calculates the sum of SubtotalCost and SalesTaxCost
        /// </summary>
        public double TotalCost
        {
            get
            {
                return Math.Round(this.SubtotalCost + this.SalesTaxCost, 2);
            }
        }

        /// <summary>
        /// Constructor for order
        /// </summary>
        public Order()
        {
            this.SalesTaxRate = 0.15;
            this.Items = new ObservableCollection<IOrderItem>();
        }
    }
}
