using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    abstract class Card
    {
        private string _title;//название карты
        private string _text;//текст карты
        private Image _imagefront, _imageback;
         /// <summary>
        /// Создание карты
        /// </summary>
        /// <param name="ti">Название карты</param>
        /// <param name="te">Текст карты</param>
        public Card(string ti, string te, Image imf, Image imb)
        {
            _title = ti;
            _text = te;
        }
    }

    class Door : Card
    {
        /// <summary>
        /// Создание карты дверей
        /// </summary>
        /// <param name="ti">Название карты</param>
        /// <param name="te">Текст карты</param>
        public Door(string ti, string te, Image imf, Image imb) : base(ti, te, imf, imb)
        {
        }
    }

    class Treasure : Card
    {
        /// <summary>
        /// Создание карты сокровищ
        /// </summary>
        /// <param name="ti">Название карты</param>
        /// <param name="te">Текст карты</param>
        public Treasure(string ti, string te, Image imf, Image imb) : base(ti, te, imf, imb)
        {
        }
    }

    class Monster : Door
    {
        private int _level;//уровень монстра
        private int _lvls, _trsrs;//награды за его убийство
        public Monster(string ti, string te, Image imf, Image imb, int lvl) : base(ti, te, imf, imb)
        {
            _level = lvl;
        }
    }
}
