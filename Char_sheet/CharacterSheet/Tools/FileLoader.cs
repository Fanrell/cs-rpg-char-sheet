using System.IO;
namespace CS.Tools
{
    /// <summary>
    /// <c>FileLoader</c> static class witch convert json's data from file to string
    /// </summary>
    static class FileLoader
    {
        /// <summary>
        /// Static class which open file and convert json's data to string
        /// </summary>
        /// <param name="path">full path to file</param>
        /// <param name="fileName">file name</param>
        /// <returns>String value with converted json's data</returns>
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