using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2
{
    class Erzeuger
    {
        private ArrayList objects = new ArrayList();
        private Random random = new Random();
        private Verbraucher.dlgErzeugen dlg;

        public Erzeuger(Verbraucher.dlgErzeugen _dlg)
        {
            this.dlg = _dlg;
        }

        public void Run()
        {
            this.printStatus();
            this.erzeuge();
        }

        private void erzeuge()
        {
            int count = this.random.Next(1, 11);
            for (int i = 0; i < count; i++)
                this.objects.Add(new object());

            this.printStatus(count);

            if (this.dlg(this.objects.Count))
                this.erzeuge();
        }

        private void printStatus()
        {
            this.printStatus(0);
        }

        private void printStatus(int _newItems)
        {
            Console.Write("[Erzeuger:]\t");

            for(int i = 0; i < _newItems; i++)
                Console.Write("#");

            Console.Write(" {0} neue Objekte erzeugt, {1} insgesamt\n", _newItems, this.objects.Count);
        }

        public void printSummary()
        {
            Console.WriteLine("[Erzeuger:]\t{0} Objekte erzeugt", this.objects.Count);
        }
    }
}
