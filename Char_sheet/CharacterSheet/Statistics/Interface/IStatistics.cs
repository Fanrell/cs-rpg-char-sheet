namespace CS.Stats
{
	public interface IStatistics
	{
		public bool NewLabel(string label);
		public bool NewStat(int[] stats);
		public string ShowStat();
	}
}
