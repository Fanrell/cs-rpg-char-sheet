using CS.Skill_n_Abi;
using CS.Stats;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reflection.Emit;

namespace Char_sheet.CS.Tools
{
    static class Printer
    {
        public static string Print(Statistic stats)
        {
            string tekst = stats.Label;
            foreach (int x in stats.Stats)
            {
                tekst += " | " + x.ToString() + " | ";
            }
            return tekst;
        }
        public static string Print(List<Statistic> stats)
        {
            string tekst = "";
            foreach(Statistic s in stats)
                tekst += Print(s) + "\n";
            Debug.Print(tekst);
            return tekst;
        }

        public static string Print(Skill skill)
        {
            string tekst = skill.PrintSheetSkill().ToString();
            return tekst;
        }

        public static string Print(List<Skill> skills)
        {
            string tekst = "";
            foreach (var x in skills)
                tekst += Print(x) + "\n";
            return tekst;
        }

        public static string Print(Ability ability)
        {
            string tekst = ability.PrintSheetAblitiy().ToString();
            return tekst;
        }

        public static string Print(List<Ability> abilities)
        {
            string tekst = "";
            foreach (var x in abilities)
                tekst += Print(x) + "\n";
            return tekst;
        }
    }
}
