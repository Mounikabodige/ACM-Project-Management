namespace ACM_Project_Management.Bussinesslayer.Models
{
    public class Customer
    {
        public int CustomerID { get; private set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }
}
