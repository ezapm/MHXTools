using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PalicoCheckTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "APM Palico Check Tool";
            Palico palico;
            byte[] fileData;
            if (args.Length > 0 && File.Exists(args[0]))
            {
                fileData = File.ReadAllBytes(args[0].Replace("\r\n", ""));
                if (fileData.Length != 319)
                {
                    Console.WriteLine("Invalid File\n");
                    Console.Read();
                    return;
                }
                palico = DataExtractor.GetPalcio(fileData);
            }
            else
            {
                Console.WriteLine("Please drag a file onto the .exe\n");
                Console.Read();
                return;
            }

            string[] equippedSkills = new string[palico.EquippedSkills.Length];
            string[] equippedActions = new string[palico.EquippedSkills.Length];
            string[] learnedSkills = new string[palico.LearnedSkills.Length];
            string[] learnedActions = new string[palico.LearnedActions.Length];

            for (int i = 0; i < equippedSkills.Length; i++)
                equippedSkills[i] = Constants.PalicoSkills[palico.EquippedSkills[i]];

            for (int i = 0; i < equippedActions.Length; i++)
                equippedActions[i] = Constants.PalicoSupportMoves[palico.EquippedActions[i]];

            for (int i = 0; i < learnedSkills.Length; i++)
                learnedSkills[i] = Constants.PalicoSkills[palico.LearnedSkills[i]];

            for (int i = 0; i < learnedActions.Length; i++)
                learnedActions[i] = Constants.PalicoSupportMoves[palico.LearnedActions[i]];


            Console.WriteLine("Name:  {0}", palico.Name);
            Console.WriteLine("Level: {0} ({1:N0}xp)", palico.Level + 1, palico.XP);
            Console.WriteLine("Forte: {0}", Constants.PalicoForte[palico.Forte]);
            Console.WriteLine("Learned Action RNG: {0:X2}{1:X2}", ((byte)(palico.LearnedActionRNG & 0xFF00 >> 8)), ((byte)(palico.LearnedActionRNG >> 8)));
            Console.WriteLine("Learned Skill RNG : {0:X2}{1:X2}", ((byte)(palico.LearnedSkillRNG & 0xFF00 >> 8)), ((byte)(palico.LearnedSkillRNG >> 8)));

            Console.WriteLine("\nEquipped Actions: \n{0}", string.Join(",", equippedActions));
            Console.WriteLine("\nEquipped Skills: \n{0}", string.Join(",", equippedSkills));
            Console.WriteLine("\nLearned Actions: \n{0}", string.Join(", ", learnedActions));
            Console.WriteLine("\nLearned Skills: \n{0}", string.Join(",", learnedSkills));

            Console.WriteLine("\n\nWeapon Slot: {0}", (((fileData[0x101] << 8 | fileData[0x100]) == 0xFFFF) ? "None Equipped" : (fileData[0x101] << 8 | fileData[0x100]).ToString()));
            Console.WriteLine("Head Slot: {0}", (((fileData[0x103] << 8 | fileData[0x102]) == 0xFFFF) ? "None Equipped" : (fileData[0x103] << 8 | fileData[0x102]).ToString()));
            Console.WriteLine("Chest Slot: {0}", (((fileData[0x105] << 8 | fileData[0x104]) == 0xFFFF) ? "None Equipped" : (fileData[0x105] << 8 | fileData[0x104]).ToString()));

            
            Console.WriteLine("\nActive Status: {0:X2}", (fileData[0xE0] & 0x0F) == 0 ? "Inactive" : 
                                                           ((fileData[0xE0] & 0x0F) == 1 ? "First Palico" : 
                                                              (fileData[0xE0] & 0x0F) == 2 ? "Second Hunter" : 
                                                                (fileData[0xE0] & 0x0F) == 8 ? "Meowster Hunter" : 
                                                                  ("Unknown: " + (fileData[0xE0] & 0x0F))));
            Console.WriteLine("Prowler Status: {0}", fileData[0xE3] == 1 ? "Active" : "Inactive");
            Console.WriteLine("\nDLC: {0}", ((fileData[0xE0] >> 4) & 8) == 8 ? "TRUE" : "FALSE" );


            Console.WriteLine("\n--------------------------------------------------------------------------------");
            Console.WriteLine("Validating...\n");

            Console.Write("Action RNG: ");
            Console.ForegroundColor = Validator.ValidateActionRNG(palico.LearnedActionRNG) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write("{0}\n", Validator.ValidateActionRNG(palico.LearnedActionRNG) ? "Valid" : "Invalid");
            Console.ResetColor();

            Console.Write("Skill RNG: ");
            Console.ForegroundColor = Validator.ValidateSkillRNG(palico.LearnedSkillRNG) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write("{0}\n", Validator.ValidateSkillRNG(palico.LearnedSkillRNG) ? "Valid" : "Invalid");
            Console.ResetColor();

            Console.Write("Equipped Actions: ");
            Console.ForegroundColor = Validator.CheckIfSkillExists(palico.EquippedActions, palico.LearnedActions) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write("{0}\n", Validator.CheckIfSkillExists(palico.EquippedActions, palico.LearnedActions) ? "Valid" : "Invalid");
            Console.ResetColor();

            Console.Write("Equipped Skills: ");
            Console.ForegroundColor = Validator.CheckIfSkillExists(palico.EquippedSkills, palico.EquippedSkills) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.Write("{0}\n", Validator.CheckIfSkillExists(palico.EquippedSkills, palico.EquippedSkills) ? "Valid" : "Invalid");
            Console.ResetColor();
            
            Console.Write("Learned Actions: ");
            Console.ForegroundColor = Validator.ValidateLearnedActions(palico.LearnedActionRNG, palico.LearnedActions, palico.Forte) ? ConsoleColor.Green : ConsoleColor.Yellow;
            Console.Write("{0}\n", Validator.ValidateLearnedActions(palico.LearnedActionRNG, palico.LearnedActions,palico.Forte) ? "Valid" : "Invalid or DLC Palico");
            Console.ResetColor();

            Console.Write("Learned Skills: ");
            Console.ForegroundColor = Validator.ValidateLearnedSkills(palico.LearnedSkillRNG, palico.LearnedSkills, palico.Forte) ? ConsoleColor.Green : ConsoleColor.Yellow;
            Console.Write("{0}\n", Validator.ValidateLearnedSkills(palico.LearnedSkillRNG, palico.LearnedSkills, palico.Forte) ? "Valid" : "Invalid or DLC Palico");
            Console.ResetColor();

            Console.WriteLine("\nValidation Complete");
            Console.Read();
        }
    }
}
