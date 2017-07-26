using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    class Monster : Card
    {
        private int _level { get; }
        public Monster(string ti, string te, int lvl) : base(ti, te)
        {
            _level = lvl;
        }
    }
}
