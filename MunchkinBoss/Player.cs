using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    class Player
    {
        private Card _race;
        private Card _class;
        private int _level;
        private int _power;
        private List<Card> _backpack;
        private List<Card> _inventory;
        private Card _head;
        private Card _body;
        private Card[] _hands;
        private Card _legs;
        private Card _extralegs;

        public Player()
        {
            _level = 1; _power = 0;
            _backpack = new List<Card>();
            _inventory = new List<Card>();
            _hands = new Card[2];
            _race = null; _class = null; _head = null; _body = null; _legs = null; _extralegs = null;
        }
    }
}
