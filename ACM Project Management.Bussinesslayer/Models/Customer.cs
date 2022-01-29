using System.Collections.Generic;

namespace ACM_Project_Management.Bussinesslayer.Models
{
    public class Customer
    {
        //Default Constructor
        public Customer(): this(0) //constructor chainng
        { }

        /*
         * Constructor overloading can only be done by creating a default constructor.
         */

        //Constructor Overloading.
        public Customer(int customerId) {
            CustomerId = customerId;
            AddressList = new List<Address>(); // composition :  So that no null error or exceprion is thrown.
        }

        /// <summary>
        /// Gets or sets the addresses.
        /// </summary>
        public List<Address> AddressList { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        public int CustomerId { get; private set; }

        /// <summary>
        /// Gets or sets the customer email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the customer first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the count number of times the customer object is created.
        /// </summary>
        public static int InstanceCount { get; set; }

        /// <summary>
        /// Gets or sets the last Name.
        /// </summary>
        public string LastName { get; set; }


      /*
      * Function or method overloading.
      */
        /// <summary>
        /// Retreive a customer based on the customer identifier.
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int CustomerId)
        {
            var customer = new Customer();
            return customer;
        }
        /// <summary>
        /// Retreives all customers.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            var customer = new List<Customer>();
            return customer;
        }

        /// <summary>
        /// Saves the customer.
        /// </summary>
        /// <returns> True if customer is saved; else false.</returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns> True if customer is valid; else false.</returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName))
                isValid = false;
            if (string.IsNullOrWhiteSpace(LastName))
                isValid = false;
            if (string.IsNullOrWhiteSpace(Email))
                isValid = false;

            return isValid;
        }
    }
}
