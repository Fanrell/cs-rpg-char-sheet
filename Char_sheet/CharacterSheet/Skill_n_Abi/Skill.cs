namespace CS.Skill_n_Abi
{
    class Skill : ISkill
    {
        private string label;
        private string discription = null;
        private int? level = null;

        public bool BuildSkill(string label, string disc)
        {
            return true;
        }

        public bool BuildSkill(string label, string disc, int lvl)
        {
            return true;
        }

        public string PrintDiscription()
        {
            return " ";
        }

        public string PrintSheetAblitiy()
        {
            return " ";
        }
    }
}
