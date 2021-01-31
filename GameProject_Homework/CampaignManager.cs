using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Homework
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("\n" +campaign.CampaignName+" İsimli kampanya eklendi." );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("\n" + campaign.CampaignName + " İsimli kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("\n" + campaign.CampaignName + " İsimli kampanya güncellendi.");
        }
    }
}
