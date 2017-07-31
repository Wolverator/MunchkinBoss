using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunchkinBoss
{
    public partial class NewPlayerForm : Form
    {
        public NewPlayerForm()
        {
            InitializeComponent();
        }
        private void CreateNewPlayerButton_Click(object sender, EventArgs e)
        {
            if ((textBoxNickname.Text != "") && (textBoxNickname.Text.Length >= 3) && (textBoxNickname.Text.Length <= 15))
            {
                Program._nickname = textBoxNickname.Text;
                Program._male = radioButtonMale.Checked;
                Close();
            }
            else { MessageBox.Show("Ник должен быть не короче 3 и не длиннее 15 символов!", "Следуй правилам!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); return; }
        }
    }
}
