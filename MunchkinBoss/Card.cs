using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    enum EquipType
    {
        playerRace = 0,
        playerClass =1,
        head = 2,
        body = 3,
        hands = 4,
        legs = 5,
        helper = 6,
        potion = 7,
        curse = 8,
        actions = 9,
        traps = 10,
        buff = 11,
        cheat = 12,
        palka = 13//LALKA ZATRALEN  =)))00)0 // сделать редчайшую карту рандома
    }

    abstract class Card
    {
        private string _title;
        private string _text;
        protected Image _imageFront, _imageBack;
        

        public Card(string title, string text, Image imageFront)
        {
            if ((title == null) || (text == null) || (imageFront == null)) throw new MunchkinException("Заполнены не все поля карты");
            _title = title;
            _text = text;
        }
    }

    class Door : Card
    {
        
        
        public Door(string title, string text, Image imageFront) 
            : base(title, text, imageFront)
        {
            _imageBack = Properties.Resources.Door;
        }
    }

    class Treasure : Card
    {
        

        public Treasure(string title, string text, Image imageFront) 
            : base(title, text, imageFront)
        {
            _imageBack = Properties.Resources.Treasure;
        }
    }

    class Monster : Door
    {
        private uint _level;
        private uint _levelsForMurder, _treasures;


        public Monster(string title, string text, Image imageFront, uint level, uint levels, uint treasures) 
            : base(title, text, imageFront)
        {
            
            if (level < 1) throw new MunchkinException("Ай Нихарашо Читарить!!!111!");
            _level = level;
            _levelsForMurder = levels;
            _treasures = treasures;
        }
    }

    class Equipment : Treasure
    {
        private bool _single_use;
        private bool _big;
        private EquipType _equipType;
        private int price;
        
        public Equipment(string title, string text, Image imageFront, bool big, EquipType equipType) 
            : base(title, text, imageFront)
        {
            _big = big;
            _equipType = equipType;
        }
    }

    //сделать импорт объектов карт из внешних файлов XML
}