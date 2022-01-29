using ACM_Project_Management.Bussinesslayer.Models;
using System;
namespace ACM_Project_Management.Bussinesslayer.BussinessLogicServices
{
    public class CustomerService
    {
        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Last"></param>
        /// <returns></returns>
        public string FullName(string First, string Last)
        {
            if(!string.IsNullOrWhiteSpace(First) && !string.IsNullOrWhiteSpace(Last))
            {
                return Last + ", " + First;
            }
            else if (!string.IsNullOrWhiteSpace(First))
            {
                return First;
            }
            else if(!string.IsNullOrWhiteSpace(Last))
            {
                return Last;
            }
            else
            {
                return "";
            }
        }

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
        public bool Validate(string nameOrEmail)
        {
            var isValid = false;

            if(string.IsNullOrWhiteSpace(nameOrEmail))
                isValid = false;

            return isValid;
        }
    }
}
