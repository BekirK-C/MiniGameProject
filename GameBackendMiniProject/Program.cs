using GameBackendMiniProject.Adapters;
using GameBackendMiniProject.Concrete;
using GameBackendMiniProject.Entities;
using System;

namespace GameBackendMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisServiceAdapter());
            CampaignManager campaignManager = new CampaignManager();
            ProductManager productManager = new ProductManager();
            SalesManager salesManager = new SalesManager();

            // Mernis Kimlik doğrulamalıdır. Sadece gerçek kimlik bilgileri ile kayıt yapılabilir.
            User user1 = new User { Id = 001, BirthYear = 1991, FirstName = "Bekir Berat", LastName = "Kamacı", IdentityNo = "00100200300" };
            User user2 = new User { Id = 002, BirthYear = 1980, FirstName = "Arda", LastName = "Özgen", IdentityNo = "00200500700" };
            Campaigns campaign1 = new Campaigns { Id = 001, CampaignName = "New Year!", DiscountRate = 25 };
            Campaigns campaign2 = new Campaigns { Id = 002, CampaignName = "Hello Winter!", DiscountRate = 15 };
            Product product1 = new Product { Id = 001, ProductName = "Rise of The Tomb Rider", ProductPrice = 199 };
            Product product2 = new Product { Id = 002, ProductName = "FIFA 23", ProductPrice = 299 };

            userManager.Login(user1);
            userManager.Login(user2);
            Console.WriteLine("-------------------------");
            campaignManager.NewCampaign(campaign1);
            campaignManager.UpdateCampaign(campaign2);
            Console.WriteLine("-------------------------");
            productManager.NewProduct(product1);
            productManager.DeleteProduct(product2);
            Console.WriteLine("-------------------------");
            salesManager.Buying(user1, product1, campaign1);
            salesManager.FaturaGonder(user1);
        }
    }
}
