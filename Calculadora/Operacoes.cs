using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        //Método construtor da classe 
        public Operacoes() 
        { 
        
        }

        //public = Modificador
        //double = Tipo de retorno
        //somaValor = Nome do método
        //(double v1, double v2) = Parâmetros

        public double somaValor(double v1, double v2) // Assinatura do método
        {
            return (v1 + v2);
        }
        public double subtraiValor(double v1, double v2) // Assinatura do método
        {
            return (v1 - v2);
        }
        public double multiplicaValor(double v1, double v2) // Assinatura do método
        {
            return (v1 * v2);
        }
        public double divideValor(double v1, double v2) // Assinatura do método
        {
            return (v1 / v2);
        }
    }
}
