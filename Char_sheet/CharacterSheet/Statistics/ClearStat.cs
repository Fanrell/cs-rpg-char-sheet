using System.Collections.Generic;
namespace CS.Stats
{
    public class ClearStat
    {
        public static bool SetZeros(ref List<Statistic> stats)
        {
            bool confirm = true;
            foreach (var stat in stats)
            {
                if (!stat.BuildStat(new int[stat.Length]))
                {
                    confirm = false;
                    break;
                }
            }
            return confirm;
        }
    }    
}