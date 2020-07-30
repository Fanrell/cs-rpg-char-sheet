namespace CS.Stats
{
	public class Statistic : IStatistics
	{
		private string label;
		private int[] stats;
		public string Label
		{
			get => label;
			set
			{
					label = value;
			}
		}
		public Statistic(int fields)
		{
			stats = new int[fields];
		}

		public bool BuildLabel(string label)
        {
			if (Label == null)
			{
				Label = label;
				
			}
			return Label == label;
		}

		public bool BuildStat(int[] stats)
        {
			this.stats = stats;
			return this.stats == stats;
        }

		public string ShowStat()
        {
			string tekst = Label;
			foreach (int x in stats)
				tekst += " | " + x.ToString() + " | ";
			return tekst;
        }

		// public static IStatistics[] ConCat(IStatistics[] a, IStatistics[] b)
        // {
		// 	IStatistics[] newStatistics = new IStatistics[a.Length + b.Length];
		// 	IStatistics[][] tmp = { a, b };

		// 	int i = 0;
		// 	foreach (IStatistics[] oldStatistics in tmp)
		// 	{
		// 		foreach (IStatistics oldStat in oldStatistics)
		// 		{
		// 			newStatistics[i] = oldStat;
		// 			i++;
		// 		}
		// 	}
		// 	return newStatistics;
        // }
	}
}
