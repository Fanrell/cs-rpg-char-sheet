using System;
using System.Collections.Generic;

namespace CS.Stats
{
	/// <summary>
	/// Class <c>Statistic</c> is class preapird for contain information about statistic for character.
	/// </summary>
	public class Statistic : IStatistics
	{
		private string label;
		// private int[] stats;
		private List<int> stats = new List<int>();
		/// <value>
		///  return label
		/// </value>
		public string Label
		{
			get => label;
			set
			{
					label = value;
			}
		}
		/// <summary>
		/// Propeties returns Stats table
		/// </summary>
		/// <value>Stats table</value>
		public List<int> Stats
        {
			get => stats;
        }
		/// <summary>
		/// Propertise for return Length of stats table
		/// </summary>
		/// <value>Length of Stats Table</value>
		public int Length
		{
			get => stats.Count;
		}
		/// <summary>
		/// Constructor for Statistic class.
		/// </summary>
		/// <param name="fields">amount of stats</param>
		public Statistic()
		{
		}
		/// <summary>
		/// <c>BuildLabel</c> is method in Statistic class. Test and forward to <c>Label</c>propertis.
		/// </summary>
		/// <param name="label"></param>
		/// <returns>bool value represents correct of param</returns>
		public bool BuildLabel(string label)
        {
			if (Label == null)
			{
				Label = label;
				
			}
			return Label == label;
		}
		/// <summary>
		/// <c>BuildStat</c> is method in Statistic class. Save param in stats variable and test.
		/// </summary>
		/// <param name="stats">Array contain int values</param>
		/// <returns>bool value represents correct of param</returns>
		public bool BuildStat(int[] stats)
        {
			foreach (int x in stats)
				this.stats.Add(x);
			return Length == stats.Length;
        }

	}
}
