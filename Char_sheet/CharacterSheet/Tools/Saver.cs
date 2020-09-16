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
        public static bool SaveCharacetrSheet(CharacterSheet character, string path, string fileName)
        {
            
            bool confirm = true;
            string output = JsonConvert.SerializeObject(character);
            Console.WriteLine(character.ShowCharSheet());
            Console.WriteLine(output);
            FileSaver.CharSheetToFile(".", fileName, output);
            return confirm;
        }

        public static bool SaveCharacetrSheetTemplate(CharacterSheet character, string path, string fileName)
        {
            bool confirm = true;
            character.Clear();
            confirm = SaveCharacetrSheet(character,path,fileName);
            return confirm;
        }
        
    }
}