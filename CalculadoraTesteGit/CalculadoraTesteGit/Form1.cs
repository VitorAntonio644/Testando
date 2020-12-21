using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTesteGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adição_CheckedChanged(object sender, EventArgs e)
        {
            Sinal.Text = "+";
            Resulatado.Text = Convert.ToString(Convert.ToInt32(maskedTextBox1.Text) + Convert.ToInt32(maskedTextBox2.Text));
        }

        private void Subtração_CheckedChanged(object sender, EventArgs e)
        {
            Sinal.Text = "-";
            Resulatado.Text = Convert.ToString(Convert.ToInt32(maskedTextBox1.Text) - Convert.ToInt32(maskedTextBox2.Text));
        }

        private void Multiplicação_CheckedChanged(object sender, EventArgs e)
        {
            Sinal.Text = "*";
            Resulatado.Text = Convert.ToString(Convert.ToInt32(maskedTextBox1.Text) * Convert.ToInt32(maskedTextBox2.Text));
        }
    }
}
