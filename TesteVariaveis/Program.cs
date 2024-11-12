using System;
using System.Net.NetworkInformation;

namespace Teste_variavel{

internal class Program
{
    static void Main()
    {
        int idade = 25;
        double salario = 2534.75;
        string nome = "carlos";
        bool isEmpregado = true;

        // var entende o valor inserido
        var meme = "Carlinhos";
        const double pi = 3.14;

        DateTime DataDeHoje = new DateTime();
        string  name = "68";
        int nameConvert = Convert.ToInt32(name);


        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Salário: R$ " + salario);
        Console.WriteLine("Está empregado: " + isEmpregado);
        Console.WriteLine("Meme" + meme);
        Console.WriteLine("Pi:" + pi);
        Console.WriteLine("compilador:" + DataDeHoje.Month);
        Console.ReadKey();
    }
}
}
