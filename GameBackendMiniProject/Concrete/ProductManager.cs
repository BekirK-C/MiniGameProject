using GameBackendMiniProject.Entities;
using System;

namespace GameBackendMiniProject.Concrete
{
    internal class ProductManager
    {
        public void DeleteProduct(Product product)
        {
            Console.WriteLine(product.ProductName + " Product is  Deleted.");
        }
        public void NewProduct(Product product)
        {
            Console.WriteLine(product.ProductName + " Product is Added.");
        }

        public void UpdateProduct(Product product)
        {
            Console.WriteLine(product.ProductName + " Product is Updated.");
        }
    }
}
