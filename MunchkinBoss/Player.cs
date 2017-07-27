using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    class Player
    {
        private uint _id, _level, _mercenaryCounter;
        private string _nickname;
        private playerRace _race,  _extraRace;//добавить до нескольких - полукровка, суперманчкин
        private playerClass _class, _extraClass;
        private int _power;
        private List<Card> _activeCurses, _backpack, _extraEquipment;//проклятья, рука, читы, наёмники, прочее дополнительное снаряжение
        private List<Treasure> _inventory;//карты в игре, на столе, неиспользуемые
        private Treasure _head, _body, _legs;
        private Treasure[] _hands;

        public Player(uint id, string nickname)
        {
            _id = id; _nickname = nickname;
            _level = 1; _power = 0;
            _backpack = new List<Card>();
            _inventory = new List<Treasure>();
            _hands = new Treasure[2];
            _race = new playerRace("Человек");
            _class = null; _head = null; _body = null; _legs = null;
        }

        public void DrawDoor(uint count)
        {
            while (count > 0)
            {
                _backpack.Add(Game._doorDeck.Pop());
                count--;
            }
        }
        public void DrawTreasure(uint count)
        {
            while (count > 0)
            {
                _backpack.Add(Game._treasureDeck.Pop());
                count--;
            }
        }
    }
}
