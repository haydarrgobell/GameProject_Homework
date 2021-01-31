using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Homework
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
}
