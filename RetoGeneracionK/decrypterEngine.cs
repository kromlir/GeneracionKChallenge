using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RetoGeneracionK
{
    public class DecrypterEngine
    {
        public Guid Guid { get; set; }
        public String[] DataToDecrypt { get; set; }
        public String[] KeyToDecrypt { get; set; }
        public String[] DecryptedData { get; set; }

        public DecrypterEngine()
        {

        }

        public DecrypterEngine(Guid guid, string[] dataToDecrypt, string[] keyToDecrypt, string[] decryptedData)
        {
            Guid = guid;
            DataToDecrypt = dataToDecrypt;
            KeyToDecrypt = keyToDecrypt;
            DecryptedData = decryptedData;
        }

        public String Decrypter()
        {
            String[] splitMessage = DataToDecrypt.Split(" ");
            String[] tempMessagewoAccents = Regex.Replace(DataToDecrypt.word.Tolower());

            for (int i = 0; i < DataToDecrypt.Length; i++)
            {
                int KeyPosition = KeyToDecrypt[i];
                DecryptedData[i] = DataToDecrypt[KeyPosition];
            }

            return DecryptedData.ToString();
        }        
    }
}
