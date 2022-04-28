using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quatro
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tnCalcular_Click(object sender, EventArgs e)
        {
            if (tbxNumero.Text == "")
            {
                MessageBox.Show("Insira um Número");
            }
            else
            {
                int numero = 0;
                int quadrado = 0;
                numero = Convert.ToInt32(tbxNumero.Text);
                quadrado = numero * numero;
                lblResultado.Text ="O número "+ numero +" ao quadrado é " +  quadrado.ToString();
                tbxNumero.Focus();
                tbxNumero.SelectAll();
            }
            
        }

        private void main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar==13) 
            {
                tnCalcular.PerformClick();
            }
        }
    }
}
