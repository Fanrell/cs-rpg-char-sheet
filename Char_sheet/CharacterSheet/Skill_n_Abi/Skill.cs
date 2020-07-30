using System;
using System.Diagnostics;

namespace CS.Skill_n_Abi
{
    class Skill : ISkill
    {
        private string label;
        private string discription = null;
        private int? level = null;

        public string Label
        {
            get => label;
            set
            {
                label = value;
            }
        }

        public string Discription
        {
            get => discription;
            set
            {
                discription = value;
            }
        }

        public int? Level
        {
            get => level;
            set
            {
                level = value;
            }
        }

        public bool BuildLabel(string label)
        {
            if (Label == null)
            {
                Label = label;
            }
            return Label == label;
        }
        public bool BuildDiscription(string disc)
        {
            if (Discription == null)
            {
                Discription = disc;
            }
            return Discription == disc;
        }
        public bool BuildLevel(int? level)
        {
            Level = level;
            return Level == level;
        }
        public bool BuildSkill(string label, string disc, int? level)
        {
            bool confirm = true;
            try
            {
                confirm &= BuildLabel(label);
                confirm &= BuildDiscription(disc);
                confirm &= BuildLevel(level);
                if (!confirm)
                    throw new System.ArgumentException("Once of parameters is false");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                confirm = false;
            }
            return confirm;
        }
        public string PrintDiscription()
        {
            string disc = Label + ":\n" + Discription;
            return disc;
        }
        public (string, int?) PrintSheetSkill()
        {
            (string, int?) result = (Label, Level);
            return result;
        }
    }
}
