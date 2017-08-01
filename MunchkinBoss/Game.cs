using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardSets;

namespace MunchkinBoss
{
    public class Game
    {
        protected internal static Player[] _players;
        protected internal static Stack<Door> _doorDeck;
        protected internal static Stack<Treasure> _treasureDeck;
        protected internal static List<Door> _dicardPileDoors;
        protected internal static List<Treasure> _dicardPileTreasures;

        Random _rand = new Random();
        

        public Game(uint playersNumber)
        {
            _players = new Player[playersNumber];
            for (uint i = 1; i <= playersNumber; i++)
            {
                new NewPlayerForm().ShowDialog();
                _players[i-1] = new Player(i, Program._nickname, Program._male);
                Program.MF.WriteNickname(i, Program._nickname, Program._male);
                Program.MF.UpdatePlayersInfo();
            }
            WriteLog("Создана игра с количеством игроков = "+playersNumber);
           // Run();
        }
        
        public void Run()
        {
            WriteLog("Подготовка колод...");
            _doorDeck = new Stack<Door>();
            _treasureDeck = new Stack<Treasure>();
            _dicardPileDoors = new List<Door>();
            _dicardPileTreasures = new List<Treasure>();
            WriteLog("Заполнение колод...");


            WriteLog("Раздача начальных карт...");
            foreach (Player p in _players)
                if (p != null)
                {
                    p.DrawDoor(4); p.DrawTreasure(4);
                }
            
            WriteLog("Раздача начальных карт завершена.\nНачало игры...");
            while (true)
            {
                foreach (Player p in _players)
                {
                    WriteLog("Ход игрока "+p.Nickname);
                    if (p != null)
                    {
                        //действия игрока
                        //Preparations(p);
                        OpenDoor(p);
                        SeekForTheTroubles(p);
                        CleaningHiddens(p);
                        GenerousGiveaway(p);
                    }
                }
            }

        }
        //вынести в опрос игроков - готовятся все или только чей ход
        private void Preparations(Player player)
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

        private void WriteLog(string s) { Program.MF.WriteLog(s); }
    }
}
