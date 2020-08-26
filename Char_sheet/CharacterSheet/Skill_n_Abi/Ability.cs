using System;
using System.Diagnostics;

namespace CS.Skill_n_Abi
{
    /// <summary>
    /// Class <c>Ability</c> Class prepared to contain information about available character's ability
    /// </summary>
    class Ability : IAbility
    {
        private string label;
        private string discription;
        private bool possess;
        /// <value>
        /// <c>Label</c> represents name of ability
        /// </value>
        public string Label
		{
			get => label;
			set
			{
					label = value;
			}
		}
        /// <value>
        /// <c>Discription</c> Contain full description of ability
        /// </value>
        public string Discription
        {
            get => discription;
            set
            {
                discription = value;
            }
        }
        /// <value>
        /// <c>Possess</c> Information about learned ability
        /// </value>
        public bool Possess
        {
            get => possess;
            set
            {
                possess = value;
            }
        }
        /// <summary>
        /// <c>BuildLabel</c> is method in Ability class. Test and forward to <c>Label</c>propertis.
        /// </summary>
        /// <param name="label">name of new ability </param>
        /// <returns>bool value represents correct of param</returns>
        public bool BuildLabel(string label)
        {
            if(Label == null)
            {
                Label = label;
            }
            return Label == label;
        }
        /// <summary>
        /// <c>BuildDiscription</c> is method in Ability class. Test and forward to <c>Discription</c>propertis.
        /// </summary>
        /// <param name="disc">Discription of new ability</param>
        /// <returns>bool value represents correct of ablity</returns>
        public bool BuildDiscription(string disc)
        {
            if(Discription == null)
            {
                Discription = disc;
            }
            return Discription == disc;
        }
        /// <summary>
        /// <c>BuildPossess</c> is method of Ablity class. Test and forward to <c>Possess</c>propertis
        /// </summary>
        /// <param name="possess">Information about knowledge of ability </param>
        /// <returns>bool value represents correct of param</returns>
        public bool BuildPossess(bool possess)
        {
            if(Possess != possess)
                Possess = possess;
            return Possess == possess;
        }
        /// <summary>
        /// <c>BuildAbility</c> is method of Ability class. Check correction of parameters step by step.
        /// </summary>
        /// <param name="label"> name of new ability </param>
        /// <param name="disc"> Discription of new ability </param>
        /// <param name="possess"> Information about knowledge of ability </param>
        /// <returns></returns>
        public bool BuildAbility(string label, string disc, bool possess)
        {
            bool confirm = true;
            try
            {
                confirm &= BuildLabel(label);
                confirm &= BuildDiscription(disc);
                confirm &= BuildPossess(possess);
                if (!confirm)
                    throw new System.ArgumentException("Once of parameters is false");
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
                confirm = false;
            }
            return confirm;
        }
        // do zmiany
        public (string,string) PrintDiscription()
        { 
            return (Label, Discription);
        }
        // do zmiany
        public (string,bool) PrintSheetAblitiy()
        {
            (string, bool) result = (Label, Possess);
            return result;
        }
    }
}
