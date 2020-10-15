using System;
using System.IO;
using System.Text;
namespace CS.Tools
{
    /// <summary>
    /// <c>FileSaver</c> class witch convert string with character sheet info to json's type of data
    /// </summary>
    static class FileSaver
    {
        /// <summary>
        /// Method witch convert string to json's type of data
        /// </summary>
        /// <param name="path">full path to file</param>
        /// <param name="fileName">file name</param>
        /// <param name="charSheetJson">string with data about character sheet</param>
        /// <returns>Bool value of succeed action</returns>
        public static bool CharSheetToFile(string path, string fileName, string charSheetJson)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, fileName)))
            {
                outputFile.Write(Convert.ToBase64String(Encoding.UTF8.GetBytes(charSheetJson)));
            }
            bool confirm = true;
            return confirm;
        }
    }
}