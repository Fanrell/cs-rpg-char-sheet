namespace CS.Skill_n_Abi
{
    interface IAbility
    {
        public bool BuildLabel(string label);
        public bool BuildDiscription(string disc);
        public bool BuildPossess(bool possess);
        public bool BuildAbility(string label, string disc, bool possess);
        public string PrintDiscription();
        public (string, bool) PrintSheetAblitiy();
    }
}
