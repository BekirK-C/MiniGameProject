using GameBackendMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Abstract
{
    internal interface ICampaignManager
    {
        void NewCampaign(Campaigns campaign);
        void UpdateCampaign(Campaigns campaign);
        void DeleteCampaign(Campaigns campaign);

    }
}
