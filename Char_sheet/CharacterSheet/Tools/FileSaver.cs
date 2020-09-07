using System;
using System.IO;
namespace CS.Tools
{
    static class FileSaver
    {
        public static bool CharSheetToFile(string path,string fileName ,string charSheetJson)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, fileName)))
            {
                outputFile.Write(charSheetJson);
            }
            bool confirm = true;
            return confirm;
        }
    }
}