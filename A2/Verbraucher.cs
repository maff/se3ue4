using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2
{
    class Verbraucher
    {
        private int maxObjects;
        private int totalObjects = 0;

        public Verbraucher(int _maxObjects)
        {
            this.maxObjects = _maxObjects;
        }

        public delegate bool dlgErzeugen(int _erzeugteObjekte);
        public bool mehrErzeugen(int _erzeugteObjekte)
        {
            this.totalObjects = _erzeugteObjekte;

            if (_erzeugteObjekte >= this.maxObjects)
            {
                Console.WriteLine("[Verbraucher:]\tEs wurde genug erzeugt");
                return false;
            }

            Console.WriteLine("[Verbraucher:]\tBitte mehr erzeugen");
            return true;
        }

        public void printSummary()
        {
            Console.WriteLine("[Verbraucher:]\t{0} Objekte bekommen, {1} verarbeitet", this.totalObjects, this.maxObjects);
        }
    }
}
