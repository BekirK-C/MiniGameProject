using GameBackendMiniProject.Abstract;
using GameBackendMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Concrete
{
    internal class SalesManager : ISalesManager
    {
        public void Buying(User user, Product product, Campaigns campaign)
        {
            double DiscountedPrice = product.ProductPrice - (campaign.DiscountRate/100 * product.ProductPrice);
            Console.WriteLine(user.FirstName + " bought " + product.ProductName + " for " + DiscountedPrice);
        }
        public void FaturaGonder(User user)
        {
            Console.WriteLine(user.FirstName + "'ın mailine fatura gönderildi.");
        }
    }
}
