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
        DecrypterEngine toDecrypt = new DecrypterEngine();
        String FilePath;
        FileReader fileReader = new FileReader();

        public Main()
        {
            InitializeComponent();
        }
        private void buttonFileDecrypt_Click(object sender, EventArgs e)
        {
            if (openFileDialogDecrypt.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialogDecrypt.FileName;

                toDecrypt.DataToDecrypt = fileReader.readData(FilePath);

                textBoxPathDecrypt.Text = openFileDialogDecrypt.FileName.ToString();
            }
        }

        private void buttonPathKey_Click(object sender, EventArgs e)
        {
            if (openFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialogKey.FileName;

                toDecrypt.KeyToDecrypt = fileReader.readData(FilePath);

                textBoxPathKey.Text = openFileDialogKey.FileName.ToString();
            }
        }
    }
}
