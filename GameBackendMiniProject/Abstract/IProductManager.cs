using GameBackendMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Abstract
{
    internal interface IProductManager
    {
        void DeleteProduct(Product product);
        void NewProduct(Product product);
        void UpdateProduct(Product product);
    }
}
