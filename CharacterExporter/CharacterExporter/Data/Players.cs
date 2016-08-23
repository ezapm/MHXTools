using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterExporter.Data
{
    public class Player
    {
        public UInt32 SaveOffset { get; set; }
        public byte[] Data { get; set; }
        public string Name { get; set; }

        public Player()
        {
        }
    }
}
