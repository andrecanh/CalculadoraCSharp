using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoIphone
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void bntPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void bntResultado_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            }
            //valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (valor2 == 0)
            {
                txtResultado.Text = Convert.ToString(valor1);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void bntSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
        }

        private void bntMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "x";
            }
        }

        private void bntDivisao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "÷";
            }
        }

        private void bntCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void bntC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void bntSoma_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }
    }
}
