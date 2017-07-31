using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MunchkinBoss
{
    public partial class MainForm : Form
    {
        public static Game _game;
        public MainForm()
        {
            
            InitializeComponent();
            Text += "|  v0.21 - Создание игроков!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveCards();
        }
        //!!! Сериализовывать массивы карт - готовые к сортировке и игре. 1 массив - 1 набор/дополнение
        public void SaveCards()
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Monster));
                using (FileStream fs = new FileStream("cards.json", FileMode.Create))
                {
                    jsonFormatter.WriteObject(fs, new Monster("Название", "text", "11111",5));

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        internal void WriteNickname(uint i, string nickname, bool male)
        {
            string S = ", м";
            if (!male) S = ", ж";
            switch (i)
            {
                case 1: groupBoxPlayer1.Text = nickname + S; break;
                case 2: groupBoxPlayer2.Text = nickname + S; break;
                case 3: groupBoxPlayer3.Text = nickname + S; break;
                case 4: groupBoxPlayer4.Text = nickname + S; break;
                case 5: groupBoxPlayer5.Text = nickname + S; break;
                case 6: groupBoxPlayer6.Text = nickname + S; break;
                default: throw new MunchkinException("Нет ячейки для игрока с таким номером!!!  <Mainform.WriteNickname>.i");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Monster));
                using (FileStream fs = new FileStream("cards.json", FileMode.Open))
                {
                   Monster a = (Monster)jsonFormatter.ReadObject(fs);
                    richTextBox1.Text += a.Title + "\n";
                    richTextBox1.Text += a.Text + "\n";
                    richTextBox1.Text += a.Level + "\n";
                    richTextBox1.Text += a.PathImageFront + "\n";
                    richTextBox1.Text += a.LevelsForMurder + "\n";
                    richTextBox1.Text += a.Treasures + "\n";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void UpdatePlayersInfo()
        {
            if (Game._players[0] != null) UpdatePlayer1(Game._players[0].Level, Game._players[0].Power);
            if (Game._players[1] != null) UpdatePlayer2(Game._players[1].Level, Game._players[1].Power);
            if (Game._players[2] != null) UpdatePlayer3(Game._players[2].Level, Game._players[2].Power);
            if (Game._players[3] != null) UpdatePlayer4(Game._players[3].Level, Game._players[3].Power);
            if (Game._players[4] != null) UpdatePlayer5(Game._players[4].Level, Game._players[4].Power);
            if (Game._players[5] != null) UpdatePlayer6(Game._players[5].Level, Game._players[5].Power);
        }
        
        private void UpdatePlayer1(uint lvl, int pwr)
        {
            labelLvl1.Text = lvl.ToString();
            labelPwr1.Text = pwr.ToString();
        }
        private void UpdatePlayer2(uint lvl, int pwr)
        {
            labelLvl2.Text = lvl.ToString();
            labelPwr2.Text = pwr.ToString();
        }
        private void UpdatePlayer3(uint lvl, int pwr)
        {
            labelLvl3.Text = lvl.ToString();
            labelPwr3.Text = pwr.ToString();
        }
        private void UpdatePlayer4(uint lvl, int pwr)
        {
            labelLvl4.Text = lvl.ToString();
            labelPwr4.Text = pwr.ToString();
        }
        private void UpdatePlayer5(uint lvl, int pwr)
        {
            labelLvl5.Text = lvl.ToString();
            labelPwr5.Text = pwr.ToString();
        }
        private void UpdatePlayer6(uint lvl, int pwr)
        {
            labelLvl6.Text = lvl.ToString();
            labelPwr6.Text = pwr.ToString();
        }

        //3 игрока
        private void игрокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game = null;
            _game = new Game(3);
        }
        //4 игрока
        private void игрокаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _game = null;
            _game = new Game(4);
        }
        //5 игроков
        private void игроковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game = null;
            _game = new Game(5);
        }
        //6 игроков
        private void игроковToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _game = null;
            _game = new Game(6);
        }
    }
}