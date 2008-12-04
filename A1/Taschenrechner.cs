using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A1
{
    public partial class Taschenrechner : Form
    {
        Rechner myRechner = null;

        public Taschenrechner()
        {
            this.myRechner = new Rechner();
            InitializeComponent();
        }

        private void textBox_Operand1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myRechner.Operand1 = int.Parse(textBox_Operand1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Keine gültige Zahl im Eingabefeld eingegeben");
            }
        }

        private void textBox_Operand2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myRechner.Operand2 = int.Parse(textBox_Operand2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Keine gültige Zahl im Eingabefeld eingegeben");
            }
        }

        private void button_Addition_Click(object sender, EventArgs e)
        {
            textBox_Ergebnis.Text = myRechner.addiere().ToString();
        }

        private void button_Subtraktion_Click(object sender, EventArgs e)
        {
            textBox_Ergebnis.Text = myRechner.subtrahiere().ToString();
        }

        private void button_Multiplikation_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button) sender;
                textBox_Ergebnis.Text = this.myRechner.berechne(btn.Text).ToString();
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show(nre.Message);
            }
        }

        private void button_Division_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Ergebnis.Text = myRechner.dividiere().ToString();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void button_Restwert_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Ergebnis.Text = myRechner.berechneRest().ToString();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}
