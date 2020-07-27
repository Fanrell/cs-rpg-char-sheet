using CS;
using CS.Stats;
using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Char_sheet
{
    class Fil
    {

        public bool FillCharacterSheet(CharacterSheet chrSheet, string flag)
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

    }
}
