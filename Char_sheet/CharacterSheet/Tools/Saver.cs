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
        public static bool SaveCharacetrSheet(CharacterSheet character, string path)
        {
            //serializacja moze zostac wykonana tylko dla pól publicznych. Można to objeść ?
            bool confirm = true;
            string output = JsonConvert.SerializeObject(character);
            Console.WriteLine(character.ShowCharSheet());
            Console.WriteLine(output);
            FileSaver.CharSheetToFile(".", "test.json", output);
            return confirm;
        }

        public static bool SaveCharacetrSheetTemplate(CharacterSheet character, string path)
        {
            bool confirm = true;
            return confirm;
        }
        
    }
}