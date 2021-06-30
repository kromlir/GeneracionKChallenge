using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoGeneracionK
{
    public partial class Main : Form
    {
        decrypterEngine toDecrypt = new decrypterEngine();
        public Main()
        {
            InitializeComponent();
            
        }
        private void buttonFileDecrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialogDecrypt.ShowDialog() == DialogResult.OK)
            {
                

                toDecrypt.DataToDecrypt = ;
            }
        }
    }
}
