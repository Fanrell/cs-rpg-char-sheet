using System;
using Newtonsoft.Json;
using CS;

namespace CS.Tools
{
    /// <summary>
    /// <c>Saver</c> Tools class prepaird to save data
    /// </summary>
    static class Saver
    {
        /// <summary>
        /// Method preparing CharacterSheet object to serialize and forward to serialization.
        /// </summary>
        /// <param name="character">object of CharacterSheet</param>
        /// <param name="path">Path to save location</param>
        /// <param name="fileName">Name of file</param>
        /// <returns>Bool value information about sucesse of operation</returns>
        public static bool SaveCharacetrSheet(CharacterSheet character, string path, string fileName)
        {
            
            bool confirm = true;
            string output = JsonConvert.SerializeObject(character);
            Console.WriteLine(character.ShowCharSheet());
            Console.WriteLine(output);
            FileSaver.CharSheetToFile(".", fileName, output);
            return confirm;
        }
        /// <summary>
        /// Method creating a template of character sheet depends on full character sheet. Prepaird object forward to SaveCharacetrSheet method.
        /// </summary>
        /// <param name="character">object of CharacterSheet</param>
        /// <param name="path">Path to save location</param>
        /// <param name="fileName">Name of file</param>
        /// <returns>Bool value information about sucesse of operation</returns>
        public static bool SaveCharacetrSheetTemplate(CharacterSheet character, string path, string fileName)
        {
            bool confirm = true;
            character.Clear();
            confirm = SaveCharacetrSheet(character,path,fileName);
            return confirm;
        }
        
    }
}