using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterExporter.Data
{
    public class SaveFile
    {
        public byte[] FileData { get; set; }
        public Player[] Players { get; set; }

        public SaveFile()
        {
        }
    }
}
