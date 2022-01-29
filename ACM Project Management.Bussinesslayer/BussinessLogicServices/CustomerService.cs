using ACM_Project_Management.Bussinesslayer.Models;
using System;
using System.Collections.Generic;

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
    }
}
