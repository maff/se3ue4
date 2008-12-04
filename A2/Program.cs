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

            Verbraucher verbraucher = new Verbraucher(maxObjects);
            Verbraucher.dlgErzeugen dlg = new Verbraucher.dlgErzeugen(verbraucher.mehrErzeugen);
            Erzeuger erzeuger = new Erzeuger(dlg);
            erzeuger.Run();

            Console.WriteLine();
            Console.WriteLine("Ergebnisse");
            Console.WriteLine("----------");

            erzeuger.printSummary();
            verbraucher.printSummary();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
