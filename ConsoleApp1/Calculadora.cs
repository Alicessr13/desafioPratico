using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class Calculadora
    {
        public static double Soma(double num, double num2) => num + num2;

        public static double Subtracao(double num, double num2) => num - num2;

        public static double Multi(double num, double num2) => num * num2;

        public static double Divisao(double num, double num2) => num / num2;

        public static double Media(double num, double num2) => (num + num2)/2;
    }
}
