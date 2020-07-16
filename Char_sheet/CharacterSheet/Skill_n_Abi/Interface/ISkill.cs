namespace CS.Skill_n_Abi
{
    interface ISkill : IInfo
    {
        public bool BuildSkill(string label, string disc);
        public bool BuildSkill(string label, string disc, int lvl);
    }
}
