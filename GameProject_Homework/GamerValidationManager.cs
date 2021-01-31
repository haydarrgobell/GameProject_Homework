using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Homework
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.LationalityId == "16912829815" && gamer.FirstName.ToUpper() == "HAYDAR" &&
                gamer.LastName.ToUpper()=="GÖBEL" && gamer.DateOfBirth.Year == 1999)
            return true; 
            else return false; 
        }
    }
}
