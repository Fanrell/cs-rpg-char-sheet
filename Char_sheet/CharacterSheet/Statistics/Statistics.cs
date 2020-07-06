namespace CharactertSheet
{
	public interface Statistics
	{
		public void NewStat();
		public bool EditCoreStat(int value);
		public bool EditFinalStat(int value);
		public string ShowStat();
		public string TempStat();
		public string EditLabel(string label);
	}
}
