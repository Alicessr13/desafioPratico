using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using Desafios;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        //4 - Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
        Console.WriteLine("\nDigite a palavra para ser contado os caracteres: ");
        string palavra = Console.ReadLine();

        int quantLetras = palavra.Count(char.IsLetter);

        Console.WriteLine($"\nA palavra digitada tem {quantLetras} caracteres");

        //5 - 1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
        //-A placa deve ter 7 caracteres alfanuméricos;
        //-Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
        //-Os quatro últimos caracteres são números;
        //Ao final, o programa deve exibir*** Verdadeiro***se a placa for válida e ***Falso * **caso contrário.

        Console.WriteLine("Digite a placa: ");
        string placa = Console.ReadLine();

        Console.WriteLine(VerificaPlaca.Verificacao(placa));

        //1.Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
        //-Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
        //-Apenas a data no formato "01/03/2024".
        //- Apenas a hora no formato de 24 horas.
        //- A data com o mês por extenso.

        Console.WriteLine("\nEscolha o formato de exibição da data: ");
        Console.WriteLine("Formato completo = 1 \nApenas a data no formato \"01/03/2024\" = 2 \nApenas a hora no formato de 24 horas = 3 \nA data com o mês por extenso = 4");
        string opcao = Console.ReadLine();

        DateTime hoje = DateTime.Now;

        switch (opcao) 
        {
            case "1":
                Console.WriteLine(hoje.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
                break;

            case "2":
                Console.WriteLine(hoje.ToString("d"));
                break;

            case "3":
                Console.WriteLine(hoje.ToString("t"));
                break;

            case "4":
                Console.WriteLine(hoje.ToString("dd 'de' MMMM 'de' yyyy"));
                break;

            default:
                Console.WriteLine("Opcão indisponivel");
                break;
        }
    }
}