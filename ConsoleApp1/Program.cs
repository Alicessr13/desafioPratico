using System.Runtime.Intrinsics.X86;
using Desafios;

class Program
{
    static void Main() 
    {
        //1 - Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja bem-vindo!");

        //2 - Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
        Console.WriteLine("\nDigite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Nome completo: {nome} {sobrenome} \n");

        //3 1. Crie um programa com 2 valores do tipo **`double`** já declarados que retorne:
        //-A soma entre esses dois números;
        //-A subtração entre os dois números;
       // -A multiplicação entre os dois números;
       // -A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
       // -A média entre os dois números.

        double valor1, valor2;
        string valorTexto;

        Console.WriteLine("Digite o primeiro número: ");
        valorTexto = Console.ReadLine();

        double.TryParse(valorTexto, out valor1);

        Console.WriteLine("Digite o segundo número: ");
        valorTexto = Console.ReadLine();

        double.TryParse(valorTexto, out valor2);

        double resultado = Calculadora.Soma(valor1 ,valor2);
        Console.WriteLine($"Resultado da soma: {resultado}");

        resultado = Calculadora.Subtracao(valor1 ,valor2);
        Console.WriteLine($"Resultado da subtração: {resultado}");

        resultado = Calculadora.Multi(valor1, valor2);
        Console.WriteLine($"Resultado da multiplicação: {resultado}");

        resultado = Calculadora.Divisao(valor1, valor2);
        Console.WriteLine($"Resultado da divisão: {resultado}");

        resultado = Calculadora.Media(valor1, valor2);
        Console.WriteLine($"Resultado da media: {resultado}");
    }
}