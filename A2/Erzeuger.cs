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
        private Verbraucher verbraucher;

        public Erzeuger(Verbraucher _verbraucher)
        {
            this.verbraucher = _verbraucher;
            printStatus();
        }

        public void erzeuge()
        {
            int count = this.random.Next(1, 11);
            for (int i = 0; i < count; i++)
                this.objects.Add(new object());

            this.printStatus(count);

            Verbraucher.dlgErzeugen dlg = new Verbraucher.dlgErzeugen(this.verbraucher.mehrErzeugen);
            if (dlg(count))
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
    }
}
