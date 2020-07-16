namespace CS.Skill_n_Abi
{
    interface Skill
    {
        public bool BuildSkill(string label, string disc);
        public bool BuildSkill(string label, string disc, int lvl);
        public string ShowInfo();
        public string ShowSheetInfo();
    }
}
