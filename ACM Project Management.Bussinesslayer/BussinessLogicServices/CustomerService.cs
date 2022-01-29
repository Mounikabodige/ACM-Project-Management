using System;
namespace ACM_Project_Management.Bussinesslayer.BussinessLogicServices
{
    public class CustomerService
    {
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
