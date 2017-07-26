using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    class Game
    {
        private Player[] _players = new Player[6];

        public void Run()
        {
            while (true)
            {
                foreach (Player p in _players)
                {
                    if (p != null)
                    {
                        //действия игрока
                    }
                }
            }

        }

    }
}
