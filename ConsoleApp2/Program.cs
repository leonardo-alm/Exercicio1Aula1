using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar electric = new Guitar();
            Guitar acoustic = new Guitar();
            Violin violin = new Violin();
            Piano piano = new Piano();

            electric.NumFret = 21;
            acoustic.NumFret = 19;
            violin.NumStrings = 4;
            piano.NumKeys = 61;

            Inventory.Include(electric);
            Inventory.Include(acoustic);
            Inventory.Include(violin);
            Inventory.Include(piano);

            Console.WriteLine(Inventory.Count);
            
            Inventory.Load();
            Inventory.Save();
        }
    }
}
