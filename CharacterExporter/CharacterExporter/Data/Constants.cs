using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterExporter.Data
{
    public static class Constants
    {
        public const UInt16 CHAR_SLOT_1_USED_OFFSET = 0x0004; //Size1
        public const UInt16 CHAR_SLOT_1_OFFSET = 0x0010; //Size 4
        public const Int32 SIZEOF_CHARACTER = 0xEBAD8;
        public const UInt32 NAME_OFFSET = 0x193ED;
        public const Int16 SIZEOF_NAME = 32;
    }
}
