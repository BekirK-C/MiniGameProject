using GameBackendMiniProject.Abstract;
using GameBackendMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Concrete
{
    internal class CampaignManager : ICampaignManager
    {
        public void DeleteCampaign(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaign is Deleted.");
        }
        public void NewCampaign(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaign is Added.");
        }

        public void UpdateCampaign(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaign is Updated.");
        }
    }
}
