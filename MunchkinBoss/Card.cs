using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    abstract class Card
    {
        private string _title;
        private string _text;

        public Card(string ti, string te)
        {
            _title = ti;
            _text = te;
        }
    }

    class Door : Card
    {
        public Door(string ti, string te) : base(ti, te)
        {
        }
    }

    class Treasure : Card
    {
        public Treasure(string ti, string te) : base(ti, te)
        {
        }
    }

    class Monster : Door
    {
        private int _level;
        public Monster(string ti, string te, int lvl) : base(ti, te)
        {
            _level = lvl;
        }
    }
}
