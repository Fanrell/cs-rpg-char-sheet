using System;
using System.Collections.Generic;
using CS.Stats;
using CS.Skill_n_Abi;

namespace CS
{
    class CharacterSheet
    {
        private List<Statistic> stats = new List<Statistic>();
        private List<Statistic> secoundStats = new List<Statistic>();
        private List<Skill> Skills = new List<Skill>();
        private List<Ability> Abilitys = new List<Ability>();

        public bool StatsBuild(Statistic stats, string flag)
        {
            bool confirm = false;
            if(stats != null)
            {
                confirm = true;
                switch(flag.ToLower())
                {
                    case ("p"):
                        this.stats.Add(stats);
                        break;
                    case ("s"):
                        this.secoundStats.Add(stats);
                        break;
                    case ("e"):
                        break;
                    default:
                        confirm = false;
                        break;
                }
            }
            return confirm;
        }

        public void SkillBuild(Skill skill)
        {
            Skills.Add(skill);
        }

        public void AbilityBuild(Ability ability)
        {
            Abilitys.Add(ability);
        }
        public void ShowCharSheet()
        {
            string tekst = "Primary Statistics: \n";
            foreach (var x in stats)
                tekst += x.ShowStat() + "\n";
            tekst += "=======\nSecondary statistics: \n";
            foreach (var x in secoundStats)
                tekst += x.ShowStat() + "\n";
            tekst += "========\nSkills: \n";
            foreach (var x in Skills)
                tekst += x.PrintSheetSkill() + "\n";
            Console.WriteLine(tekst);
        }
    }
}
