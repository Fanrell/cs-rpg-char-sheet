using System;
using CharactertSheet;

namespace Char_sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            StatisticD100 t = new StatisticD100(1);
            int[] a = { 25 };
            Console.WriteLine(t.GetType());
            Console.WriteLine(a.GetType());
            Console.WriteLine(t.NewLabel("tak"));
            t.NewStat(a);
            Console.WriteLine(t.ShowStat());
        }
    }
}
