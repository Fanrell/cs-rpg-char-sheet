using System.Collections.Generic;
namespace CS.Stats
{
    /// <summary>
    /// <c>ClearStat</c> is static class prepaird to change int value of stats to zeros
    /// </summary>
    public class ClearStat
    {
        /// <summary>
        /// Is static class, override table of int in List of Statistic
        /// /// </summary>
        /// <param name="stats">reference to List of Statistic</param>
        /// <returns>Bool value information about sucesse of operation</returns>
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