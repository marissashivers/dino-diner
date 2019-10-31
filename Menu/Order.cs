/*
 * File name: Order.cs
 * Author: Marissa Shivers
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Represents a new customer order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        // private backing variable
        //private ObservableCollection<IOrderItem> _items;
        private List<IOrderItem> _items = new List<IOrderItem>();

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies that a property changed
        /// </summary>
        /// <param name="propertyName">String property name</param>

        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public IOrderItem[] Items { get { return _items.ToArray(); } }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnItemPropertyChanged;
            _items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

        }

        public bool Remove(IOrderItem item)
        {
            bool removed = _items.Remove(item);
            if (removed)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
            return removed;
        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs("TotalCost"));
        }

        /*
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
        */

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

            // event listener/handler for when Items property changes
            this.Items.CollectionChanged += this.OnCollectionChanged;
        }

        /// <summary>
        /// Notifies when the collection, "Items" changes
        /// which changes the subtotal cost, sales tax cost, and total cost.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }
    }
}
