using System;

namespace Oplogicos
{
internal class Program
{
    public static void Main(string[] args)
    {
        bool var1 = true;
        bool var2 = false;

        bool resultadoNegativo = !var1;
        Console.WriteLine(resultadoNegativo);
        resultadoNegativo = !var2;
        Console.WriteLine(resultadoNegativo);

    }
}

}