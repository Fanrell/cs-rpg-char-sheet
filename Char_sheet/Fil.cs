using CS;
using CS.Stats;
using CS.Skill_n_Abi;
using System;
using System.Diagnostics;

namespace Char_sheet
{
    class Fil
    {

        private bool FillStatsCharacterSheet(CharacterSheet chrSheet, string flag)
        {
            int statsFields = 0;
            int[] stat;
            string statsLabel = "";
            Statistic stats;
            bool error = false;
            do
            {
                try
                {
                    Console.WriteLine("Give Amount of Stat's fileds");
                    statsFields = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Pleas give label for stat");
                    statsLabel = Console.ReadLine();
                }
                catch(FormatException e)
                {
                    error = true;
                    Debug.Write("In your values exist {0}", e.ToString());
                    Console.WriteLine("Pleas give correct data // value");
                }
            } while (error);
            stats = new Statistic(statsFields);
            stats.BuildLabel(statsLabel);
            stat = new int[statsFields];
            for (int i = 0; i < statsFields; i++)
            {
                
                bool exceExsist = false;
                do
                {
                    Console.WriteLine("Please give value for {0} field of statistic", i + 1);
                    try
                    {
                        stat[i] = Convert.ToInt32(Console.ReadLine());
                        Debug.Print("Value: {0}", stat[i]);
                    }
                    catch (FormatException e)
                    {
                        exceExsist = true;
                        Debug.Write("In your values exist {0}", e.ToString());
                        Console.WriteLine("Pleas give correct data // value");
                    }
                } while (exceExsist);
                
            }
            stats.BuildStat(stat);
            return !chrSheet.StatsBuild(stats, flag);
        }

        private bool FillSkill(CharacterSheet charSheet)
        {
            string label = "";
            string disc = "";
            int? level;
            bool confirm = true;
            Skill skill = new Skill();
            do
            {
                
                try
                {
                    Console.WriteLine("Please give skill Label");
                    label = Console.ReadLine();
                    Console.WriteLine("Please give skill Discription");
                    disc = Console.ReadLine();
                    Console.WriteLine("Please give skill Level (0-3)");
                    level = Convert.ToInt16(Console.ReadLine());
                    if (!skill.BuildSkill(label, disc, level))
                        throw new ArgumentException("Once of parameters is false");
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    skill = new Skill();
                    confirm = false;
                }
            } while (!confirm);


            charSheet.SkillBuild(skill);
            return confirm;
        }

        public void Filler(CharacterSheet charSheet, string flag)
        {
            switch(flag.ToLower())
            {
                case("p"):
                    this.FillStatsCharacterSheet(charSheet, flag);
                    break;
                case("s"):
                    this.FillStatsCharacterSheet(charSheet, flag);
                    break;
                case("k"):
                    this.FillSkill(charSheet);
                    break;
                
            }
        }

    }
}
