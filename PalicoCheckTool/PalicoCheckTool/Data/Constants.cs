using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalicoCheckTool
{
    public static class Constants
    {
        public static readonly string[] PalicoForte = { "Charisma", "Fighting", "Protection", "Assisting", "Healing", "Bombing", "Gathering", "Treasure", "Launching", "Stamina" };
        public static readonly string[] PalicoSupportMoves = { "-----", "Herb Horn", "Health Horn", "True Health Horn", "Detox Horn", "Cheer Horn", "Demon Horn", "Armor Horn", "Ultrasonic Horn", "Mini Barrel Bombay", "Barrel Bombay", "Big Barrel Bombay", "Mega Barrel Bombay", "Giga Barrel Bombay", "Bounce Bombay", "Flash Bombay", "Anti-Monster Mine", "Anti-Monster Mine+", "Pitfall Purr-ision", "Shock Purr-ision", "Poison Purr-ision", "Trampoliner", "Vase of Vitality", "Parting Gift", "Emergency Retreat", "Big Boomerangs", "Piercing Boomerangs", "Camoflage", "Weapon Upgrade", "Furr-ious", "Taunt", "Palico Rally", "Dung Bombay", "Go, Fight, Win", "Soothing Roll", "Explosive Roll", "Pilfer", "Plundering", "Felyne Comet", "Claw Dance", "Sumo Stomp", "Chestnut Cannon", "Shock Tripper", "Excavator", "Mega Boomerang", "Rath-of-Meow", "NULL [46]" };
        public static readonly string[] PalicoSkills = { "-----", "Health Up (S)", "Health Up (L)", "Attack Up (S)", "Attack Up (L)", "Defense Up (S)", "Defense Up (L)", "Omniresistance", "Critical Up (S)", "Critical Up (L)", "Handicraft", "Bombay Boost", "Element Attack Up", "Status Attack Up", "Knockout King", "Stamina Drain", "Guard (S)", "Guard (L)", "Guard Boost", "Support Priority", "Support Boost", "Support Move +1", "Pilfer Boost", "Revival Pro", "Heat/Bomb Res", "Negate Poison", "Negate Wind", "Negate Paralysis", "Negate Stun", "Negate Confusion", "Tremor Res", "Earplugs", "Negate Sleep", "Biology", "Iron Hide", "Non-Stick Fur", "Nine Lives (Attack)", "Nine Lives (Defense)", "Last Stand", "Anger Prone", "Counter Boost", "Monsterdar", "Boomerang Pro", "Pro Trapper", "Gathering Pro", "Slacker Slap", "Health Harmonics", "Goldenfish Catcher", "Baddest Cat Ever", "High Cadence", "World's Strongest", "Zombie", "Desperation", "Nagatobimaru", "Fanalis", "Aera", "Ranged Attack Up", "Sonic Mini Bombay", "Fashion Sense", "Universal", "DUMMY", "DUMMY", "DUMMY", "Wind Waker", "Landmaster", "Super Mushroom", "Shopkeeping", "Triforce", "Morph Ball Bomb", "Megaflare", "DEF-Centric", "STAM-Centric", "Fire Res Up", "Water Res Up", "Thunder Res Up", "Ice Res Up", "Dragon Res Up", "NULL [77]" };

        public static readonly UInt16[] ValidActionRNGs = { 0x000D, 0x010B, 0x020A, 0x0309, 0x040B, 0x050A, 0x0609, 0x0708 };
        public static readonly UInt16[] ValidSkillRNGs = { 0x000B, 0x0109, 0x0208, 0x0307, 0x0409, 0x0508, 0x0607, 0x0707, 0x0806 };

        public static readonly string[] ValidSkillFormats = { "11111111", "221111", "22211", "2222", "311111", "32111", "3221", "3222" };

        public static readonly byte[] DefaultPalicoActions = { 31, 29, 30, 20, 3, 11, 37 };
        public static readonly byte[] LegalPalicoSecondaryActions = { 0, 0, 6, 26, 24, 7, 24, 5, 7, 5, 6, 27, 26, 27 };

        public static readonly byte[] DefaultPalicoSkills = { 45, 3, 16, 41, 5, 24, 44 };
        public static readonly byte[] LegalPalicoSecondarySkills = { 38, 10, 18, 43, 46, 11, 22 };

        public static readonly string[] Value3Actions = { "Health Horn", "Shock Purr-ision", "Rath-of-Meow", "Pilfer", "Pitfall Purr-ision", "Anti-Monster Mine+", "Giga Barrel Bombay" };
        public static readonly string[] Value2Actions = { "Trampoliner", "Vase of Vitality", "Claw Dance", "Mega Boomerang", "Big Barrel Bombay", "Detox Horn", "Flash Bombay", "Anti-Monster Mine", "Weapon Upgrade", "Go, Fight, Win" };
        public static readonly string[] Value1Actions = { "Chestnut Cannon", "Excavator", "Dung Bombay", "Sumo Stomp", "Felyne Comet", "Explosive Roll", "Ultrasonic Horn", "Bounce Bombay", "Shock Tripper", "Parting Gift", "Big Boomerangs", "Barrel Bombay", "Soothing Roll" };

        public static readonly string[] Value3Skills = { "Support Move +1", "Support Priority", "Revival Pro", "Anger Prone", "Omniresistance", "Element Attack Up", "Status Attack Up" };
        public static readonly string[] Value2Skills = { "Knockout King", "Guard (L)", "Support Boost", "Counter Boost", "Earplugs", "Defense Up (L)", "Attack Up (L)", "Critical Up (L)", "Nine Lives (Attack)", "Negate Stun", "Health Up (L)" };
        public static readonly string[] Value1Skills = { "Non-Stick Fur", "Boomerang Pro", "Negate Poison", "Iron Hide", "Defense Up (S)", "Negate Wind", "Attack up (S)", "Goldenfish Catcher", "Critical Up (S)", "Negate Confusion", "Stamina Drain", "Negate Paralysis", "Tremor Res", "Nine Lives (Defense)", "Negate Sleep", "Health Up (S)", "Biology" };
    }
}
