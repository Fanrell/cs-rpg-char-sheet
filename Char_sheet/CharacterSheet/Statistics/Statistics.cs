namespace CharacterSheet
{
	public interface Statistics
	{
		public bool NewLabel(string label);
		public bool NewStat(int[] stats);
		public string ShowStat();
	}
}
