using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Rechner
    {
        delegate int Operate();

        private int op1 = 0, op2 = 0;
        private System.Collections.Hashtable table = new System.Collections.Hashtable();

        public Rechner()
        {
            this.table.Add("+", new Operate(addiere));
            this.table.Add("-", new Operate(subtrahiere));
            this.table.Add("*", new Operate(multipliziere));
            this.table.Add("/", new Operate(dividiere));
            this.table.Add("%", new Operate(berechneRest));
            this.table.Add("^", new Operate(potenziere));
        }

        public int berechne(string _operation)
        {
            Operate dlgMethod = (Operate) this.table[_operation];
            return dlgMethod();
        }

        public int Operand1
        {
            get
            {
                return op1;
            }
            set
            {
                op1 = value;
            }
        }

        public int Operand2
        {
            get
            {
                return op2;
            }
            set
            {
                op2 = value;
            }
        }

        public int addiere()
        {
            return op1 + op2;
        }

        public int subtrahiere()
        {
            return op1 - op2;
        }

        public int multipliziere()
        {
            return op1 * op2;
        }

        public int dividiere()
        {
            if (op2 == 0)
                throw new ArgumentException("Operand 2 hat den Wert 0");
            return op1 / op2;
        }
        
        public int berechneRest()
        {
            if (op2 == 0)
                throw new ArgumentException("Operand 2 hat den Wert 0");
            return op1 % op2;
        }

        public int potenziere()
        {
            return (int) Math.Pow((double) op1, (double) op2);
        }
    }
}
