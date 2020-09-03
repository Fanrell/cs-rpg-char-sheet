using System;
using System.Collections.Generic;
using CS.Stats;
using CS.Skill_n_Abi;
using CS.Tools;

namespace CS
{
    /// <summary>
    /// <c>CharacterSheet</c> is class which contain all information abut character sheet.
    /// </summary>
    class CharacterSheet
    {

        private List<Statistic> stats = new List<Statistic>();
        private List<Statistic> secoundStats = new List<Statistic>();
        private List<Skill> skills = new List<Skill>();
        private List<Ability> abilities = new List<Ability>();
        /// <summary>
        /// Method which forward stat to appropriate List depends on the flag
        /// </summary>
        /// <param name="stats"> its filled object of <c>Statistic</c> </param>
        /// <param name="flag"> string value about lenght 1 symbol. Allowed symbols ("p" - primary stats, "s" - secoundary stats, "e" - exit)</param>
        /// <returns>bool value represents correct operation</returns>
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
        /// <summary>
        /// Method in <c>CharacterSheet</c>.  Add filled param to Skill List.
        /// </summary>
        /// <param name="skill">Filled object of <c>Skill</c></param>
        public void SkillBuild(Skill skill)
        {
            skills.Add(skill);
        }
        /// <summary>
        /// Method in <c>CharacterSheet</c>.  Add filled param to Ability List.
        /// </summary>
        /// <param name="skill">Filled object of <c>Ability</c></param>
        public void AbilityBuild(Ability ability)
        {
            abilities.Add(ability);
        }
        /// <summary>
        /// Method in <c>CharacterSheet</c>. Write all information from Character Sheet.
        /// </summary>
        /// <returns>all information from character sheet</returns>
        public string ShowCharSheet()
        {
            string tekst = "Primary Statistics: \n";
            tekst += Printer.Print(stats);
            tekst += "=======\nSecondary statistics: \n";
            tekst += Printer.Print(secoundStats);
            tekst += "========\nSkills: \n";
            tekst += Printer.Print(skills);
            tekst += "========\nAblity: \n";
            tekst += Printer.Print(abilities);
            return tekst;
        }
    }
}
