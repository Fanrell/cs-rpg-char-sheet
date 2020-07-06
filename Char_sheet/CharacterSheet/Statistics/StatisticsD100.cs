namespace CharactertSheet
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
		public StatisticD100(string label, int[] stat)
		{
			
		}

		public void NewStat()
		{
			string t = "t";
		}
		public bool EditCoreStat(int value)
		{
			return true;
		}
		public bool EditFinalStat(int value)
        {
			return true;
        }
		public string ShowStat()
        {
			return "t";
        }
		public string TempStat()
        {
			return "t";
        }
		public string EditLabel(string label)
        {
			return "t";
        }
	}
}
