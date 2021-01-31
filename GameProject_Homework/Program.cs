using System;

namespace GameProject_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { GameId = 1, GameName = "God Of War", GameType = "Mythology", GamePrice = 150 };
            Game game2 = new Game() { GameId = 2, GameName = "Spiderman", GameType = "Fantasy fiction", GamePrice = 100 };
            Game game3 = new Game() { GameId = 3, GameName = "Call Of Duty", GameType = "Action", GamePrice = 50 };

            Gamer gamer1 = new Gamer() { Id = 1, FirstName = "Haydar", LastName = "Göbel", DateOfBirth = new DateTime(1999, 2, 1), LationalityId = "16912829815" };
            Gamer gamer2 = new Gamer() { Id = 2, FirstName = "Senay", LastName = "Atıl", DateOfBirth = new DateTime(2000, 1, 15), LationalityId = "16954829823" };
            Gamer gamer3 = new Gamer() { Id = 3, FirstName = "Mert", LastName = "Süleyman", DateOfBirth = new DateTime(1998, 12, 5), LationalityId = "13254811823" };

            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer3);

            GameManager gameManager = new GameManager();
            gameManager.Delete(game2);

            Campaign campaign1 = new Campaign() { CampaignName = "Ocak ayı indirimi", CampaignDiscount = 25 };
            Campaign campaign2 = new Campaign() { CampaignName = "Şubat ayı indirimi", CampaignDiscount = 35 };

            SellingManager sellingManager1 = new SellingManager();
            sellingManager1.Sell(game1, gamer1, campaign1);

            SellingManager sellingManager2 = new SellingManager();
            sellingManager2.Sell(game3, gamer3, campaign2);







        }
    }
}
