using System;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;

namespace CS.Skill_n_Abi
{
    class Ability : IAbility
    {
        private string label;
        private string discription;
        private bool possess;
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

        public bool Possess
        {
            get => possess;
            set
            {
                possess = value;
            }
        }

        public bool BuildLabel(string label)
        {
            if(Label == null)
            {
                Label = label;
            }
            return Label == label;
        }
        public bool BuildDiscription(string disc)
        {
            if(Discription == null)
            {
                Discription = disc;
            }
            return Discription == disc;
        }
        public bool BuildPossess(bool possess)
        {
            if(Possess == false)
            {
                Possess = true;
            }
            return possess;
        }
        public bool BuildAbility(string label, string disc, bool possess)
        {
            bool confirm = true;
            try
            {
                confirm &= BuildLabel(label);
                confirm &= BuildDiscription(disc);
                confirm &= BuildPossess(possess);
                if (!confirm)
                    throw new System.ArgumentException("Once of paramiters is false");
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
            return confirm;
        }
        public string PrintDiscription()
        {
            string disc = Label + ":\n" + Discription;
            return disc;
        }
        public (string,bool) PrintSheetAblitiy()
        {
            (string, bool) result = (Label, Possess);
            return result;
        }
    }
}
