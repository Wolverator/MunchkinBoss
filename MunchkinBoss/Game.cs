using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    class Game
    {
        private Player[] _players;
        private Card[] card = new Card[168]; //запилить функцию заполнения массива
        Stack<Door> _door;
        Stack<Treasure> treasure;

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
                        OpenDoor();
                        SeekForTheTroubles();
                        CleaningHiddens();
                        GenerousGiveaway();
                    }
                }
            }

        }

        private void Preparations()
        {

        }

        private void OpenDoor()
        {
            
        }

        private void SeekForTheTroubles()
        {

        }

        private void CleaningHiddens()
        {

        }

        private void GenerousGiveaway()
        {

        }
    }
}
