using System;
using System.Collections.Generic;

namespace ACM_Project_Management.Bussinesslayer.Models
{
    public class Order
    {
        public Order() { }

        public Order(int orderId) { 
            OrderId = orderId;
        }

        //Tracks the date time and time zone.
        /// <summary>
        /// Gets or sets the prdoduct description.
        /// </summary>
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Gets or sets order identifier.
        /// </summary>
        public int OrderId { get; private set; }

        /// <summary>
        /// Gets or sets the prdoduct name.
        /// </summary>
        public string OrderName { get; set; }


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
        public bool ValidateOrderDate()
        {
            var isValid = true;

            if (OrderDate == null)
                isValid = false;
            return isValid;
        }
    }
}
