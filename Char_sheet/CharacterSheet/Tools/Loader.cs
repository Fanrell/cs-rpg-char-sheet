using System;
using Newtonsoft.Json;

namespace CS.Tools
{
    /// <summary>
    /// <c>Loader</c> Tools class prepaird data to load
    /// </summary>
    static class Loader
    {
        /// <summary>
        /// Static method which load data from file to referent object of CharacterSheet
        /// </summary>
        /// <param name="character">reference to CharacterSheet object</param>
        /// <param name="path">full path to file</param>
        /// <param name="fileName">file name</param>
        /// <returns>Bool value of succeed action</returns>
        public static bool LoadCharacterSheet(ref CharacterSheet character, string path, string fileName)
        {
            bool confirm = false;
            string input = "";
            string[] splitedFileName = fileName.Split('.');
            if (splitedFileName[splitedFileName.Length-1] == "char")
            {
                splitedFileName = null;
                GC.Collect();
                input = FileLoader.CharSheetFromFile(path, fileName);
                character = JsonConvert.DeserializeObject<CharacterSheet>(input);
                confirm = true;
            }
            else
            {
                // dodaæ wyj¹tek 
            }
            Console.WriteLine(input);
            return confirm;
        }
    }
}