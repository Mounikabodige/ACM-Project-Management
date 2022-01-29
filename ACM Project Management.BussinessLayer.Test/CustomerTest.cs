using ACM_Project_Management.Bussinesslayer.BussinessLogicServices;
using ACM_Project_Management.Bussinesslayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM_Project_Management.BussinessLayer.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void ValidateFullName()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Mounika";
            customer.LastName = "Bodige";

            //Act
            CustomerService service = new CustomerService();
            var result = service.FullName(customer.FirstName, customer.LastName);

            string expectedResult = "Bodige, Mounika";

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        [TestMethod]
        public void EmptyFirstNameFullName()
        {
            //Arrange
            var customer = new Customer()
            {
                LastName = "Bodige"
            };

            //Act
            CustomerService custom = new CustomerService();
            var result = custom.FullName("", customer.LastName);
            
            string expectedResult = "Bodige";

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void EmptyLastNameFullName()
        {
            //Arrange
            var customer = new Customer()
            {
                FirstName = "Mounika"
            };

            //Act
            CustomerService customerService = new CustomerService();
            var fullName = customerService.FullName(customer.FirstName, "");
            
            string expectedResult = "Mounika";

            //Assert
            Assert.AreEqual(expectedResult, fullName);
        }

        [TestMethod]
        public void StaticPropertyTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "First";
            Customer.InstanceCount ++;

            var c2 = new Customer();
            c2.FirstName = "Second";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c3.FirstName = "Third";
            Customer.InstanceCount++;


            //Act && Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateCustomer()
        {
            var customer = new Customer()
            {
                LastName = "Test",
                Email = "test@gmail.com"
            };

            //Act
            var service = new CustomerService();
            var result = service.Validate(customer.LastName);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
