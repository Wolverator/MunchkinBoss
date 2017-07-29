using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    class Game
    {
        private static Player[] _players;
        protected internal static Stack<Door> _doorDeck;
        protected internal static Stack<Treasure> _treasureDeck;
        protected internal static List<Door> _dicardPileDoors;
        protected internal static List<Treasure> _dicardPileTreasures;

        Random _rand = new Random();
        

        public Game(uint playersNumber)
        {
            if ((playersNumber < 3) || (playersNumber > 6)) throw new MunchkinException("Количество игроков должно быть от 3 до 6!");
            _players = new Player[playersNumber];

            
        }
        
        public void Run()
        {
            while (true)
            {
                foreach (Player p in _players)
                {
                    if (p != null)
                    {
                        //действия игрока
                        Preparations();
                        OpenDoor(p);
                        SeekForTheTroubles(p);
                        CleaningHiddens(p);
                        GenerousGiveaway(p);
                    }
                }
            }

        }

        private void Preparations()
        {

        }

        private void OpenDoor(Player player)
        {
            
        }

        private void SeekForTheTroubles(Player player)
        {

        }

        private void CleaningHiddens(Player player)
        {

        }

        private void GenerousGiveaway(Player player)
        {
            player.DiscardBackpack();
        }
    }
}
