using System;

class GameScoreTracker
{
 static void Main(string[] args)
 {
    int player1 = 0;
    int player2 = 0;
    Randim rand = new Random();

    for (int round = 1; round <= 5; round++)
    {
        Console.WriteLine($"Round {round}");
        int scorer = rand.Next(1, 3);

        if(scorer == 1)
        {
            ++player1;
            Console.WriteLine("Player 1 scores!");
        }
        else
        {
            player2++;
            Console.WriteLine("Player 2 scores!");
        }
     
     Console.WriteLine($"Player 1 Score: {player1}");
     Console.WriteLine($"Player 2 Score: {player2}\n");
    }

 }

}