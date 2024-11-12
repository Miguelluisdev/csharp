using System;

namespace infoUser 
{
internal class Info
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome");
        string name = Console.ReadLine();
        Console.WriteLine( "nome: " + name);    


        Console.WriteLine("Digite sua idade");
        UInt16 age = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("idade: " + age);

        string gender = Console.ReadKey().KeyChar.ToString();
        Console.WriteLine("genero" + gender);

        bool var1 = true;
        bool var2 = false;

        bool resultadoNegativo = !var1;
        Console.WriteLine(resultadoNegativo);
        resultadoNegativo = !var2;
        Console.WriteLine(resultadoNegativo);

    }
}

}