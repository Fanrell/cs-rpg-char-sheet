﻿using System;
using CS;

namespace Char_sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterSheet tmpCharSheet = new CharacterSheet();
            Fil t = new Fil();
            string flag = "";
            Console.WriteLine("Welcome to character sheet creation");
            do
            {
                Console.WriteLine("[p]rimary stat fill \n" +
                    "[s]econdary stat fill \n" +
                    "S[k]ill fill\n" +
                    "[A]bility fill\n" +
                    "Sa[v]e file\n" +
                    "Save [T]emplate file\n" +
                    "[L]oad file\n" +
                    "[e]xit 'n' print character sheet");
                flag = Console.ReadLine();
                if (flag == "e")
                    break;
                t.Filler(ref tmpCharSheet, flag);
            } while (true);
            Console.WriteLine(tmpCharSheet.ShowCharSheet());
        }

    }
}


