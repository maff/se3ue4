using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A2
{
    class Verbraucher
    {
        public delegate bool dlgErzeugen(int _erzeugteObjekte);

        private int maxObjects;

        public Verbraucher(int _maxObjects)
        {
            this.maxObjects = _maxObjects;
        }

        public bool mehrErzeugen(int _erzeugteObjekte)
        {
            if (_erzeugteObjekte >= this.maxObjects)
            {
                Console.WriteLine("[Verbraucher:]\tEs wurde genug erzeugt");
                return false;
            }

            Console.WriteLine("[Verbraucher:]\tBitte mehr erzeugen");
            return true;
        }
    }
}
