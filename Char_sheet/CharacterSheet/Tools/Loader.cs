using System;
using Newtonsoft.Json;
using System.Linq;
using CS;
// spróbować serializować poszczególne elementy obiektu i go odbudowaywać, zamiast całego obiektu. Bug z odczytem, zawartość tabeli statystyk się nie przenosi
namespace CS.Tools
{
    /// <summary>
    /// <c>Loader</c> Tools class prepaird to load data
    /// </summary>
    static class Loader
    {
        public static bool LoadCharacterSheet(ref CharacterSheet character, string path, string fileName)
        {
            bool confirm = true;
            string input = FileLoader.CharSheetFromFile(path, fileName);
            Console.WriteLine(input);
            character = JsonConvert.DeserializeObject<CharacterSheet>(input);
            return confirm;
        }
    }
}