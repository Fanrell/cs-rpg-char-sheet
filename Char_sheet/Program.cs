using System;
using System.Diagnostics;
using CS;

namespace Char_sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterSheet tmpCharSheet = new CharacterSheet();
            Fil t = new Fil();
            t.Filler(tmpCharSheet);
            Console.WriteLine("You filled corretly first stats");
            t.Filler(tmpCharSheet);
            tmpCharSheet.ShowCharSheet();
        }

        
    }
}


