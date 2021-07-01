using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoGeneracionK
{
    public class FileReader
    {
        public String[] DataReaded { get; set; }

        public FileReader()
        {

        }

        public String[] readData (String FilePath)
        {
            DataReaded = File.ReadAllLines(FilePath);

            return DataReaded;
        }
    }
}
