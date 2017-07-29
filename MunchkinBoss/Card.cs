using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunchkinBoss
{
    public enum EquipType
    {
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
        cheat = 12
    }
    public enum Races
    {
        human=0,
        elf=1,
        orc=2,
        dwarf=3,
        haffling=4
    }
    public enum Classes
    {
        empty=0,
        warrior=1,
        thief=2,
        cliric=3,
        wizard=4,
        bard=5,
        pathfinder=6
    }

    [DataContract]//название и текст
    public abstract class Card
    {
        private string _title;
        private string _text;

        [DataMember]
        public string Title { get { return _title; } set { _title = value; } }//!!!проверки для set - на правильность устанавливаемых значений
        [DataMember]
        public string Text { get { return _text; } set { _text = value; } }//!!!проверки для set - на правильность устанавливаемых значений
        
        public Card() { }
        public Card(string title, string text)
        {
            if ((title == null) || (text == null)|| (title == "") || (text == "")) throw new MunchkinException("Заполнены не все поля карты");
            _title = title;
            _text = text;
        }
    }

    [DataContract]//+рубашка
    public class Door : Card
    {
        private string _pathImageBack = "Images/Door.jpg";

        public Door() { }
        public Door(string title, string text) 
            : base(title, text)
        {
           
        }
    }
    
    [DataContract]//+картинка,уровень монстра, награды за убийство ! доделать непотребство, классовые усилители
    public class Monster : Door
    {
        private uint _level, _levelsForMurder, _treasures;
        private string _pathImageFront;
        [DataMember]
        public string PathImageFront { get { return _pathImageFront; } set { _pathImageFront = value; } }
        [DataMember]
        public uint Level { get { return _level; } set { _level = value; } }//!!!проверки для set - на правильность устанавливаемых значений
        [DataMember]
        public uint LevelsForMurder { get { return _levelsForMurder; } set { _levelsForMurder = value; } }//!!!проверки для set - на правильность устанавливаемых значений
        [DataMember]
        public uint Treasures { get { return _treasures; } set { _treasures = value; } }//!!!проверки для set - на правильность устанавливаемых значений

        public Monster() { }
        /// <summary>
        /// Создать карту монстра с указанными параметрами.
        /// </summary>
        /// <param name="title">Название монстра</param>
        /// <param name="text">Описание монстра</param>
        /// <param name="pathImageFront">Ссылка на картинку карты.</param>
        /// <param name="level">Уровень монстра</param>
        /// <param name="treasures">Количество уровней, получаемых манчкином за убийство монстра</param>
        /// <param name="levelForMurder">Количество сокровищ, получаемых манчкином за убийство монстра</param>
        public Monster(string title, string text, string pathImageFront, uint level, uint treasures = 1, uint levelForMurder = 1) 
            : base(title, text)
        {
            
            if (level < 1) throw new MunchkinException("Ай Нихарашо Читарить!!!111!");
            _level = level;
            _pathImageFront = pathImageFront;
            _levelsForMurder = levelForMurder;
            _treasures = treasures;
        }
    }

    [DataContract]
    public class playerRace : Door
    {
        private Races _playerRace;
        private string _pathImageFront;
        [DataMember]
        public Races PlayerRace { get { return _playerRace; } set { _playerRace = value; } }//!!!проверки для set - на правильность устанавливаемых значений
        [DataMember]
        public string PathImageFront { get { return _pathImageFront; } set { _pathImageFront = value; } }//!!!проверки для set - на правильность устанавливаемых значений

        public playerRace() { }
        public playerRace(string title = "Человек", string text = "заглушка расы по умолчанию", string pathImageFront = "Image/human.jpg", Races playerRace = Races.human)
        {
            _playerRace = playerRace;
            _pathImageFront = pathImageFront;
        }
    }
    [DataContract]
    public class playerClass : Door
    {
        private Classes _playerClass;
        private string _pathImageFront;
        [DataMember]
        public Classes PlayerClass { get { return _playerClass; } set { _playerClass = value; } }//!!!проверки для set - на правильность устанавливаемых значений

        public playerClass() { }
        public playerClass(string title, string text, string pathImageFront, Classes playerClass)
            : base(title, text)
        {
            _playerClass = playerClass;
            _pathImageFront = pathImageFront;
        }
    }
    [DataContract]
    public class Cheat : Door
    {
        
        public Cheat() { }
        public Cheat(string title, string text, Image imageFront)
            : base(title, text)
        {
        }
        void CheatEquip(Equipment thing)
        {
            //зачитерить шмотку
        }
    }

    [DataContract]//+рубашка
    public class Treasure : Card
    {
        private string _pathImageBack = "Images/Treasure.jpg";

        public Treasure() { }
        public Treasure(string title, string text)
            : base(title, text)
        {
           
        }
    }
    [DataContract]//+одноразовое(перенести в следующий тип?), большая(перенести в следующий тип?), тип, цена
    public class Equipment : Treasure
    {
        public bool _single_use { get; set; }
        public bool _big { get; set; }
        public EquipType _equipType { get; set; }
        public uint _price { get; set; }

        public Equipment() { }
        public Equipment(string title, string text, Image imageFront, bool single_use, bool big, EquipType equipType, uint price) 
            : base(title, text)
        {
            _single_use = single_use;
            _big = big;
            _equipType = equipType;
            _price = price;
        }
    }

    //сделать импорт объектов карт из внешних файлов JSON //update - вряд ли json получится, наверное 1 dll = 1 набор карт
    //1файл = 1 коробка набора, потом перемешать и в колоды
}