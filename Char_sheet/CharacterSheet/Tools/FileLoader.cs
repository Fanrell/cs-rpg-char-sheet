using System;
using System.IO;
namespace CS.Tools
{
    static class FileLoader
    {
        public static string CharSheetFromFile(string path, string fileName)
        {
            string charSheetJson = "";
            using (StreamReader inputFile = new StreamReader(Path.Combine(path, fileName)))
            {
                charSheetJson = inputFile.ReadToEnd();
            }
            return charSheetJson;
        }
    }
}