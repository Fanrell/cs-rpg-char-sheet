namespace CS.Skill_n_Abi
{
    interface IAbility : IInfo
    {
        public bool BuildLabel(string label);
        public bool BuildDiscription(string disc);
        public bool BuildPossess(bool possess);
        public bool BuildAbility(string label, string disc, bool possess);
        public string PrintDiscription();
        new public (string, bool) PrintSheetAblitiy();
    }
}
