namespace CS.Stats
{
	/// <summary>
	/// Class <c>Statistic</c> is class preapird for contain information about statistic for character.
	/// </summary>
	public class Statistic : IStatistics
	{
		private string label;
		private int[] stats;
		/// <value>
		/// <c>Label</c> forward vale to label
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
		/// Constructor for Statistic class.
		/// </summary>
		/// <param name="fields">amount of stats</param>
		public Statistic(int fields)
		{
			stats = new int[fields];
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
			this.stats = stats;
			return this.stats == stats;
        }
		/// <summary>
		/// <c>ShowStats</c> is method in Statistic class. Prepari string with statistics to show in program.
		/// </summary>
		/// <returns>Edited string with all statistics </returns>
		public string ShowStat()
        {
			string tekst = Label;
			foreach (int x in stats)
				tekst += " | " + x.ToString() + " | ";
			return tekst;
        }

	}
}
