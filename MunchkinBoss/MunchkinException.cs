using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunchkinBoss
{
    public class MunchkinException : Exception
    {
        public MunchkinException(string message)
            :base (message)
        {
            MessageBox.Show(message, "Ошибочка вышла =(", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return;
        }
    }
}
