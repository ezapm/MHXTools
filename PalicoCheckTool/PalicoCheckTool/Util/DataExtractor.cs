using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PalicoCheckTool
{
    public class DataExtractor
    {
        /// <summary>
        /// Get palico from byte[]
        /// </summary>
        /// <param name="buffer">buffer containing the palico data</param>
        /// <returns></returns>
        public static Palico GetPalcio(byte[] buffer)
        {
            Palico palico = new Palico();
            BinaryReader binaryReader = new BinaryReader((Stream)new MemoryStream(buffer));

            palico.Name = Encoding.UTF8.GetString(binaryReader.ReadBytes(32), 0, 32);
            palico.XP = binaryReader.ReadUInt32();
            palico.Level = binaryReader.ReadByte();
            palico.Forte = binaryReader.ReadByte();
            palico.Enthusiasm = binaryReader.ReadByte();
            palico.Target = binaryReader.ReadByte();
            palico.EquippedActions = binaryReader.ReadBytes(8);
            palico.EquippedSkills = binaryReader.ReadBytes(8);
            palico.LearnedActions = binaryReader.ReadBytes(16);
            palico.LearnedSkills = binaryReader.ReadBytes(12);
            palico.LearnedActionRNG = binaryReader.ReadUInt16();
            palico.LearnedSkillRNG = binaryReader.ReadUInt16();
            palico.Unknown1 = binaryReader.ReadBytes(8);
            palico.Greeting = Encoding.UTF8.GetString(binaryReader.ReadBytes(60), 0, 60);
            palico.NameGiver = Encoding.UTF8.GetString(binaryReader.ReadBytes(32), 0, 32);
            palico.PreviousMaster = Encoding.UTF8.GetString(binaryReader.ReadBytes(32), 0, 32);
            palico.Unknown2 = binaryReader.ReadBytes(62);
            palico.RGBAValue = binaryReader.ReadBytes(4);
            palico.Unknown3 = binaryReader.ReadBytes(33);

            return palico;
        }
    }
}
