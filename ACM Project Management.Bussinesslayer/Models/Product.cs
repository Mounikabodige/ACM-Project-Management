using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_Project_Management.Bussinesslayer.Models
{
    public class Product
    {
        public Product() { }

        public Product(int productId) { 
            ProductId = productId;
        }

        /// <summary>
        /// Gets or sets the current price.
        /// </summary>
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Gets or sets the prdoduct description.
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// Gets or sets product identifier.
        /// </summary>
        public int ProductId { get; private set; }

        /// <summary>
        /// Gets or sets the prdoduct name.
        /// </summary>
        public string ProductName { get; set; }

        /*
     * Function or method overloading.
     */
        /// <summary>
        /// Retreive a product based on the product identifier.
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public Product Retrieve(int ProductId)
        {
            var Product = new Product();
            return Product;
        }
        /// <summary>
        /// Retreives all products.
        /// </summary>
        /// <returns></returns>
        public List<Product> Retrieve()
        {
            var product = new List<Product>();
            return product;
        }

        /// <summary>
        /// Saves the product.
        /// </summary>
        /// <returns> True if product is saved; else false.</returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the product data.
        /// </summary>
        /// <returns> True if product is valid; else false.</returns>
        public bool ValidProductName()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }
    }
}
