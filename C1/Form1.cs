using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            Operacoes OpA = new Operacoes();
            double N1;
            double N2;
            double Resultado;
            N1 = Convert.ToDouble(n1.Text);
            N2 = Convert.ToDouble(n2.Text);
            Resultado = OpA.soma(N1,N2);
            MessageBox.Show(Convert.ToString(Resultado));
            n1.Text = Convert.ToString(Resultado);
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            Operacoes OpS = new Operacoes();
            double N1;
            double N2;
            double Resultado;
            N1 = Convert.ToDouble(n1.Text);
            N2 = Convert.ToDouble(n2.Text);
            Resultado = OpS.subtracao(N1, N2);
            MessageBox.Show(Convert.ToString(Resultado));
            n1.Text = Convert.ToString(Resultado);
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            Operacoes OpM = new Operacoes();
            double N1;
            double N2;
            double Resultado;
            N1 = Convert.ToDouble(n1.Text);
            N2 = Convert.ToDouble(n2.Text);
            Resultado = OpM.multiplicacao(N1, N2);
            MessageBox.Show(Convert.ToString(Resultado));
            n1.Text = Convert.ToString(Resultado);
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            Operacoes OpD = new Operacoes();
            double N1;
            double N2;
            double Resultado;
            N1 = Convert.ToDouble(n1.Text);
            N2 = Convert.ToDouble(n2.Text);
            Resultado=OpD.divisao(N1, N2);
            MessageBox.Show(Convert.ToString(Resultado));
            n1.Text = Convert.ToString(Resultado);
        }

        private void Potencia_Click(object sender, EventArgs e)
        {
            Operacoes OpP = new Operacoes();
            double N1;
            double N2;
            double Resultado;
            N1 = Convert.ToDouble(n1.Text);
            N2 = Convert.ToDouble(n2.Text);
            Resultado = OpP.potenciacao(N1, N2);
            MessageBox.Show(Convert.ToString(Resultado));
            n1.Text = Convert.ToString(Resultado);
        }

        private void Radiciacao_Click(object sender, EventArgs e)
        {
            Operacoes OpR = new Operacoes();
            double N1;
            double N2;
            double Resultado;
            N1 = Convert.ToDouble(n1.Text);
            N2 = Convert.ToDouble(n2.Text);
            Resultado = OpR.radiciacao(N1, N2);
            MessageBox.Show(Convert.ToString(Resultado));
            n1.Text = Convert.ToString(Resultado);
        }

        private void Fatorial_Click(object sender, EventArgs e)
        {
            Operacoes OpF = new Operacoes();
            double N1;
            double Resultado;
            N1 = Convert.ToDouble(n1.Text);
            Resultado = OpF.fatorial(N1);
            MessageBox.Show(Convert.ToString(Resultado));
            n1.Text = Convert.ToString(Resultado);
        }

        private void combinacao_Click(object sender, EventArgs e)
        {
            Operacoes OpC = new Operacoes();
            double N1;
            double N2;
            double Resultado;
            N1 = Convert.ToDouble(n1.Text);
            N2 = Convert.ToDouble(n2.Text);
            if (N1 >= N2 && N2 >= 0 && N1 > 0)
            {
                Resultado = OpC.combinacao(N1, N2);
                MessageBox.Show(Convert.ToString(Resultado));
                n1.Text = Convert.ToString(Resultado);
            }
            else
            {
                MessageBox.Show("N1 deve ser maior ou igual à N2, N1 maior que zero e N2 maior ou igual para C(n1,n2) retornar um valor");
            }
        }

        private void Arranjo_Click(object sender, EventArgs e)
        {
            Operacoes Opa = new Operacoes();
            double N1;
            double N2;
            double Resultado;
            N1 = Convert.ToUInt32(n1.Text);
            N2 = Convert.ToUInt32(n2.Text);
            if (N1 >= N2 && N2 >= 0 && N1 > 0)
            {
                Resultado = Opa.arranjo(N1, N2);
                MessageBox.Show(Convert.ToString(Resultado));
                n1.Text = Convert.ToString(Resultado);
            }
            else
            {
                MessageBox.Show("N1 deve ser maior ou igual à N2, N1 maior que zero e N2 maior ou igual para C(n1,n2) retornar um valor");
            }
        }
    }
}
