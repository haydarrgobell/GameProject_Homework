using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Homework
{
    class GamerManager : IGamerService
    {
        IGamerValidationService gamerValidationService;

        public GamerManager (IGamerValidationService gamerValidationService)
        {
            this.gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (gamerValidationService.Validation(gamer) == true) 
                Console.WriteLine("\n" + gamer.FirstName + " İsimli oyuncu eklendi.");
            else
                Console.WriteLine("\n" + gamer.FirstName + " İsimli oyuncu Eklenemedi.");
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("\n" + gamer.FirstName + " simli oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("\n" + gamer.FirstName + " İsimli oyuncu güncellendi.");
        }
    }
}
