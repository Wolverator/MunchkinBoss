using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    class Card
    {
        private string _title { get; }
        private string _text { get; }

        public Card(string ti, string te)
        {
            _title = ti;
            _text = te;
        }
    }
}
