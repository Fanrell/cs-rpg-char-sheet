namespace CS.Skill_n_Abi
{
    interface ISkill
    {
        public bool BuildLabel(string label);
        public bool BuildDiscription(string disc);
        public bool BuildLevel(int? level);
        public bool BuildSkill(string label, string disc, int? level);
        public string PrintDiscription();
        public (string, int?) PrintSheetSkill();
    }
}
