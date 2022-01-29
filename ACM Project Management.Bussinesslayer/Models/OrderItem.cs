using System;
using System.Collections.Generic;

namespace ACM_Project_Management.Bussinesslayer.Models
{
    public class OrderItem
    {
        public OrderItem() { }

        public OrderItem(int orderItemId) { 
            OrderItemId = orderItemId;
        }

        //Tracks the date time and time zone.
        /// <summary>
        /// Gets or sets the prdoduct description.
        /// </summary>
        public DateTimeOffset? OrderItemDate { get; set; }

        /// <summary>
        /// Gets or sets OrderItem identifier.
        /// </summary>
        public int OrderItemId { get; private set; }

        /// <summary>
        /// Gets or sets the prdoduct identifier.
        /// </summary>
        public int productId { get; set; }

        /// <summary>
        /// Gets or sets the purchase price.
        /// </summary>
        public decimal? PurchasePrice { get; set; }
        
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /*
        * Function or method overloading.
        */
        /// <summary>
        /// Retreive a Order based on the Order identifier.
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public Order Retrieve(int OrderId)
        {
            var Order = new Order();
            return Order;
        }
        /// <summary>
        /// Retreives all Orders.
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            var Order = new List<Order>();
            return Order;
        }

        /// <summary>
        /// Saves the Order.
        /// </summary>
        /// <returns> True if Order is saved; else false.</returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the Order data.
        /// </summary>
        /// <returns> True if Order is valid; else false.</returns>
        private bool ValidateOrderDate()
        {
            var isValid = true;

            if (Quantity <= 0)
                isValid = false;
            if (productId <= 0)
                isValid = false;
            if (PurchasePrice == null)
                isValid = false;

            return isValid;
        }
    }
}
