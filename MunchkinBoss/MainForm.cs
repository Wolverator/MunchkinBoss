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
        public MainForm()
        {
            Text += " v0.12 - Структура!";
            InitializeComponent();
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
    }
}