using CS;
using System;
using System.Diagnostics;
namespace Char_sheet
{
    class Fil
    {

        private bool FillCharacterSheet(CharacterSheet chrSheet, string flag)
        {
            int amountStats = 0;
            int statsFields = 0;
            IStatistics[] stats;
            bool error = false;
            do
            {
                try
                {
                    Console.WriteLine("Give Amount of Stats ");
                    amountStats = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Give Amount of Stat's fileds");
                    statsFields = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    error = true;
                    Debug.Write(e);
                    Console.Clear();
                }
            } while (error);
            stats = new IStatistics[amountStats];
            
            for (int i = 0; i < stats.Length; i++)
            {
                StatisticD100 tmpStat = new StatisticD100(statsFields);
                int[] statsValues = new int[statsFields];
                Console.WriteLine("{0} Stats no. {1} label: ", flag, i + 1);
                tmpStat.Label = Console.ReadLine();
                for (int j = 0; j < statsFields; j++)
                {

                    try
                    {
                        Console.WriteLine("{0} Stats no. {1}, {2} value:  ", flag, i + 1, j + 1);
                        statsValues[j] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Debug.Write(e);
                        break;
                    }
                }
                tmpStat.NewStat(statsValues);
                stats[i] = tmpStat;

            }
            return !chrSheet.StatsBuild(stats, flag);
        }

        public void Filler(CharacterSheet chSheet)
        {
            string t;
            do
            {
                Console.WriteLine("Pleas give flag to choose [P]rimary or [S]econdary stats");
                t = Console.ReadLine().Substring(0, 1);
            } while (FillCharacterSheet(chSheet, t));
        }

    }
}
