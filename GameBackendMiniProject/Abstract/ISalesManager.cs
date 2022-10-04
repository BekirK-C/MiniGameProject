using GameBackendMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Abstract
{
    internal interface ISalesManager
    {
        void Buying(User user, Product product, Campaigns campaign);
        public void FaturaGonder(User user);
    }
}
