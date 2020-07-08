using CS;
using System;

namespace CS
{
    class CharacterSheet
    {
        private Statistics[] stats;
        private int fields;
        public CharacterSheet()
        {
            Console.WriteLine("Give Amount of Stats ");
            int sA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Amount of Stat's fileds");
            int f = Convert.ToInt32(Console.ReadLine());
            StatsBuild(sA, f);
            for (int i = 0; i<stats.Length; i++)
            {
                StatisticD100 tmp = new StatisticD100(fields);
                int[] tStat = new int[fields];
                for (int j = 0; j<tStat.Length;j++)
                {
                    Console.WriteLine("Give label of stats field for {0} stat", i + 1);
                    tmp.NewLabel(Console.ReadLine());

                    Console.WriteLine("Give value of {0} field for {1} stat", j + 1, i + 1);
                    try
                    {
                        tStat[j] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                tmp.NewStat(tStat);
                stats[i] = tmp;
            }
        }

        private void StatsBuild(int statsAmount,int fields)
        {
            this.fields = fields;
            stats = new Statistics[statsAmount];
        }
        public void ShowCharSheet()
        {
            string tekst = "";
            foreach (var x in stats)
                tekst += x.ShowStat() + "\n";
            Console.WriteLine(tekst);
        }
    }
}
