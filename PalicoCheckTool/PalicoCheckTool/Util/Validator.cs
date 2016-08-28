using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalicoCheckTool
{
    public static class Validator
    {
        public static bool ValidateSkillRNG(UInt16 skillRNG)
        {
            return Constants.ValidSkillRNGs.Contains((UInt16)(((skillRNG & 0x00FF) << 8 ) | (skillRNG & 0xFF00) >> 8));
        }

        public static bool ValidateActionRNG(UInt16 actionRNG)
        {
            return Constants.ValidActionRNGs.Contains((UInt16)(((actionRNG & 0x00FF) << 8) | (actionRNG & 0xFF00) >> 8));
        }

        public static bool ValidateLearnedActions(UInt16 skillRNG, byte[] actions, byte forte)
        {
            if (actions[0] != Constants.DefaultPalicoActions[forte])
                return false;

            if (forte != 0 && !(actions[1] == Constants.LegalPalicoSecondaryActions[forte * 2] || actions[1] == Constants.LegalPalicoSecondaryActions[(forte * 2) + 1]))
                return false;

            if (forte != 0 && (actions[2] != 9 || actions[3] != 1))
                return false;
            else if (forte == 0 && actions[1] != 9 && actions[2] != 1)
                return false;

            string skillString = "";

            for (int i = 2; i < actions.Length; i++)
            {
                skillString += GetActionValue(actions[i]);
            }

            return skillString.Replace("0", "") == GetActionRNGFormat(skillRNG);
        }


        public static bool ValidateLearnedSkills(UInt16 skillRNG, byte[] skills, byte forte)
        {

            if (skills[0] != Constants.DefaultPalicoSkills[forte] || skills[1] != Constants.LegalPalicoSecondarySkills[forte])
                return false;

            string skillString = "";

            for (int i = 2; i < skills.Length; i++)
            {
                skillString += GetSkillValue(skills[i]);
            }

            return skillString.Replace("0", "") == GetSkillRNGFormat(skillRNG);
        }

        public static char GetActionValue(byte action)
        {
            if (action == 46 || action == 0 || action == 1 || action == 9 || action == 24)
                return '0';
            else if (Constants.Value1Actions.Contains(Constants.PalicoSupportMoves[action]))
                return '1';
            else if (Constants.Value2Actions.Contains(Constants.PalicoSupportMoves[action]))
                return '2';
            else if (Constants.Value3Actions.Contains(Constants.PalicoSupportMoves[action]))
                return '3';
            else
                return '?';
        }

        public static char GetSkillValue(byte skill)
        {
            if (skill == 77 || skill == 0)
                return '0';
            else if (Constants.Value1Skills.Contains(Constants.PalicoSkills[skill]))
                return '1';
            else if (Constants.Value2Skills.Contains(Constants.PalicoSkills[skill]))
                return '2';
            else if (Constants.Value3Skills.Contains(Constants.PalicoSkills[skill]))
                return '3';
            else
                return '?';
        }

        public static bool CheckIfSkillExists(byte[] equipped, byte[] learned)
        {
            foreach (byte skill in equipped)
            {
                if (!learned.Contains(skill) && skill != 0)
                    return false;
            }
            return true;
        }

        public static string GetActionRNGFormat(UInt16 skillRNG)
        {
            UInt16 value = (UInt16)(((skillRNG & 0x00FF) << 8) | (skillRNG & 0xFF00) >> 8);

            for(int i = 0; i < Constants.ValidActionRNGs.Length; i++)
            {
                if (value == Constants.ValidActionRNGs[i])
                {
                    return Constants.ValidSkillFormats[i];
                }
            }

            return null;
        }

        public static string GetSkillRNGFormat(UInt16 skillRNG)
        {
            UInt16 value = (UInt16)(((skillRNG & 0x00FF) << 8) | (skillRNG & 0xFF00) >> 8);

            for (int i = 0; i < Constants.ValidSkillRNGs.Length; i++)
            {
                if (value == Constants.ValidSkillRNGs[i])
                {
                    return Constants.ValidSkillFormats[i];
                }
            }

            return null;
        }

    }
}
