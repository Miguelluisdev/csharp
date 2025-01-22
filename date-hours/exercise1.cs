using System;


class Exercise1
{
    static void CalculateTimeSpan()
    {
        TimeSpan[] horasDiarias = new TimeSpan[7];

        Console.WriteLine("Digite as horas da reunião:");

        for (int i = 0; i < horasDiarias.Length; i++)
        {
            Console.Write($"Dia {i + 1}: ");
            string input = Console.ReadLine();

            if (CalculateTimeSpan.TryParse(input, out CalculateTimeSpan horas))
            {
                horasDiarias[i] = horas;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
                i--;
            }
        }
        TimeSpan totalHoras = new TimeSpan();
        foreach (var horas in horasDiarias)
        {
            totalHoras += horas;
        }
        Console.WriteLine($"Total de horas: {totalHoras}");
    }
}