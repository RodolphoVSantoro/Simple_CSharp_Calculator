using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Operacoes
    {
        public double soma(double n1,double n2)
        {
            double resultado;
            resultado = n1 + n2;
            return resultado;
        }
        public double subtracao(double n1, double n2)
        {
            double resultado;
            resultado = n1 - n2;
            return resultado;
        }
        public double multiplicacao(double n1, double n2)
        {
            double resultado;
            resultado = n1 * n2;
            return resultado;
        }
        public double divisao(double n1, double n2)
        {
            double resultado;
            resultado = n1 / n2;
            return resultado;
        }
        public double potenciacao(double n1, double n2)
        {
            double resultado;
            if (n2 == 0)
            {
                resultado = 1;
            }
            else
            {
                resultado = System.Math.Pow(n1, n2);
            }
            return resultado;
        }
        public double radiciacao(double n1, double n2)
        {
            double resultado;
            if (n2 == 0)
            {
                resultado = 1;
            }
            else
            {
                resultado = System.Math.Pow(n1, (1 / n2));
            }
            return Math.Round(resultado);
        }
        public double fatorial(double n1)
        {
            double resultado=1;
            int x;
            for (x = 1; x <= n1; x++ )
            {
                resultado = resultado * x;
            }
                return resultado;
        }
        public double combinacao(double n1, double n2)
        {
            double resultado;
            int x;
            double y;
            double aux=1;
            if (n1 == n2)
            {
                y = 1;
            }
            else
            {
                y = n1 - n2;
            }
            for (x = 1; x <= Convert.ToInt32(y); x++)
            {
                aux = aux * x;
            }
            resultado = this.fatorial(n1) / ( aux * this.fatorial(n2) );
            return resultado;
        }
        public double arranjo(double n1, double n2)
        {
            double resultado;
            int x;
            double y;
            int aux = 1;

            if (n1 == n2)
            {
                y = 1;
            }
            else
            {
                y = n1 - n2;
            }
            for (x = 1; x <= y; x++)
            {
                aux = aux * x;
            }
            resultado = this.fatorial(n1) / aux ;
            return resultado;
        }
    }
}
