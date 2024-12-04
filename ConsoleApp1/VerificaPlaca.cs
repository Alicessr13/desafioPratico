using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class VerificaPlaca
    {
        public static bool Verificacao(string placa)
        {
            

            if (placa.Count() != 7)
            {   
                Console.WriteLine("Placa invalida, não possui 7 caracteres");
                return false;
            }
            string tresPrimeiros = placa.Substring(0, 3);
            string quatroUltimos = placa.Substring(3, 4);
            
            if (!tresPrimeiros.All(char.IsLetter))
            {
                Console.WriteLine("Os 3 primeiros caracteres não são letras");
                return false;
            }
            else if (!quatroUltimos.All(char.IsDigit))
            {
                Console.WriteLine("Os 4 ultimos caracteres não são numeros");
                return false;
            }
            else
            {
                Console.WriteLine("A placa é valida");
                return true;
            }
        }
    }
}
