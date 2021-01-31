using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Homework
{
    class SellingManager : ISellingManager
    {
        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("\n" + game.GameName + " oyunu " + gamer.FirstName +" adlı kişiye "+ campaign.CampaignDiscount + " TL indirimli şekilde " + (game.GamePrice-campaign.CampaignDiscount) + " TL'ye satılmıştır.");
        }
    }
}
