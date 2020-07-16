using System;
using System.Diagnostics;
using CS.Stats;

namespace CS
{
    class CharacterSheet
    {
        private IStatistics[] stats;
        private IStatistics[] secoundStats;
        public CharacterSheet()
        {
        }

        public bool StatsBuild(IStatistics[] stats, string flag)
        {
            bool confirm = false;
            switch(flag.ToLower())
            {
                case ("p"):
                    this.stats = stats;
                    confirm = true;
                    if (stats.Length == 0)
                        confirm = false;
                    break;
                case ("s"):
                    this.secoundStats = stats;
                    confirm = true;
                    if (stats.Length == 0)
                        confirm = false;
                    break;
                default:
                    Debug.Write("Unimplement flag");
                    break;
            }
            return confirm;
        }
        public void ShowCharSheet()
        {
            string tekst = "Primary Statistics: \n";
            foreach (var x in stats)
                tekst += x.ShowStat() + "\n";
            tekst += "=======\nSecondary statistics: \n";
            foreach (var x in secoundStats)
                tekst += x.ShowStat() + "\n";
            Console.WriteLine(tekst);
        }
    }
}
