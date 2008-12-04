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

        private void clickHandler(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button) sender;
                textBox_Ergebnis.Text = this.myRechner.berechne(btn.Text).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Keine gültige Zahl im Eingabefeld eingegeben");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Keine gültige Operationsart angegeben");
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
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
    }
}
