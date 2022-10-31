using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1,valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultado.Text += "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultado.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultado.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            resultado.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultado.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultado.Text += "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            resultado.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resultado.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                resultado.Text = Convert.ToString(valor1 + valor2);
            }

            switch (operacao) {
                case "SOMA":
                    resultado.Text = Convert.ToString(valor1 + valor2);
                    break;
                case "SUB":
                    resultado.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "MULT":
                    resultado.Text = Convert.ToString(valor1 * valor2);
                    break;
                case "DIV":
                    resultado.Text = Convert.ToString(valor1 / valor2);
                    break;  
                    default:
                    label1.Text = "Sem resultados";
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "SUB";
            label1.Text = "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "MULT";
            label1.Text = "*";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "DIV";
            label1.Text = "/";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            valor1 = 0;
            valor1 = 0;
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse (resultado.Text, CultureInfo.InvariantCulture);
            resultado.Text = "";
            operacao = "SOMA";
            label1 .Text = "+";
        }
    }
}