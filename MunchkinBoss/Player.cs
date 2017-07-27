using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    class Player
    {
        private Door _race;//добавить до нескольких - полукровка
        private Door _extraRace;
        private Door _class;//добавить до нескольких - суперманчкин
        private Door _extraClass;
        private int _level;
        private int _power;
        private List<Card> _activeCurses;
        private List<Card> _backpack;//рука
        private List<Treasure> _inventory;//карты в игре, на столе, неиспользуемые
        private List<Card> _extraEquipment;//читы, наёмники, механизмы
        private Treasure _head;
        private Treasure _body;
        private Treasure[] _hands;
        private Treasure _legs;

        public Player()
        {
            _level = 1; _power = 0;
            _backpack = new List<Card>();
            _inventory = new List<Treasure>();
            _hands = new Treasure[2];
            _race = null;//заменить на карту расы человека
            _class = null; _head = null; _body = null; _legs = null;
        }
    }
}
