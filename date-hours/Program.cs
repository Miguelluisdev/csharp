// A skeleton of a C# program
using System;
namespace DateHours
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime hireDate =  new DateTime(2025 , 1, 22);
            Console.WriteLine(hireDate);

            // adicionando
            DateTime today = DateTime.Now;
            DateTime deadline = today.AddDays(10);
            Console.WriteLine($"Today's date: {today}");
            Console.WriteLine($"Deadline: {deadline}");
        
            // subtraindo
             DateTime currentTime = DateTime.Now;
             DateTime earlierTime = currentTime.AddHours(-5);
             Console.WriteLine($"Current Time: {currentTime}");
             Console.WriteLine($"5 Hours Ago: {earlierTime}");
                    
           // DateOnly

           DateOnly projectDueDate = new DateOnly(2025, 1, 22);
            Console.WriteLine(projectDueDate);

            DateOnly holiday = new DateOnly(2023, 12, 25);  
            Console.WriteLine(holiday.ToString("MMMM dd, yyyy"));

            //  |TimeSPan
             TimeSpan timeSpan = new TimeSpan(5, 30, 45);
            Console.WriteLine(timeSpan);
            Console.WriteLine($"Time Span in Minutes: {timeSpan.TotalMinutes}");

            DateTime todayt = DateTime.Now;
            DateTime futureDate = new DateTime(2025, 2, 22);
            TimeSpan timeLeft = futureDate - todayt;
            Console.WriteLine($"Time Left: {timeLeft}");
        }
    }
}