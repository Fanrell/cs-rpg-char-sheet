namespace CS
{
	public class StatisticD100 : Statistics
	{
		private string label;
		private int[] stats;
		public string Label
		{
			get => label;
			set
			{
				if (value.Length >= 3)
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
