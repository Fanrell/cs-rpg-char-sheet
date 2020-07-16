﻿namespace CS.Stats
{
	public class StatisticD100 : IStatistics
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
		public StatisticD100(int fields)
		{
			stats = new int[fields];
		}

		public bool NewLabel(string label)
        {
			if (Label == null)
			{
				Label = label;
				return Label == label;
			}
			return false;
        }

		public bool NewStat(int[] stats)
        {
			this.stats = stats;
			return true;
        }

		public string ShowStat()
        {
			string tekst = Label;
			foreach (int x in stats)
				tekst += " | " + x.ToString() + " | ";
			return tekst;
        }
	}
}
