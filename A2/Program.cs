using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erzeuger-Verbraucher-Problem mit Delegaten");
            Console.WriteLine();
            Console.Write("Geben Sie die Anzahl der zu verarbeitenden Objekte ein: ");

            int maxObjects;
            string input = Console.ReadLine();
            if (!int.TryParse(input, out maxObjects))
            {
                Console.WriteLine("Ungültige Eingabe, Programm wird beendet!");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            Console.WriteLine();

            Verbraucher verbr = new Verbraucher(maxObjects);
            Erzeuger erz = new Erzeuger(verbr);
            erz.erzeuge();

            Console.ReadLine();
        }
    }
}
