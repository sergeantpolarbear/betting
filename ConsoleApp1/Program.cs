Random random = new Random();

Console.WriteLine("-----Welcome to the betting game-----");
Console.WriteLine();

// Input for players
Console.Write("Player 1: ");
string player1 = Console.ReadLine()?.Trim();

Console.Write("Player 2: ");
string player2 = Console.ReadLine()?.Trim();

Console.WriteLine();
while (true)
{
    Console.Write("What the loser will do: ");
    string loserTask = Console.ReadLine()?.Trim();
    Console.Write("Press enter to start!");
    Console.ReadLine();
    Console.WriteLine();

    // Validate loser task
    if (string.IsNullOrWhiteSpace(loserTask))
    {
        Console.WriteLine("You have to say what the loser has to do!");
        continue; // Skip to the next iteration of the loop
    }

    // Randomly decide the loser
    bool isWin = random.Next(2) == 0;
    if (isWin)
    {
        Console.WriteLine($"{player1} will {loserTask}");
    }
    else
    {
        Console.WriteLine($"{player2} will {loserTask}");
    }

    //Console.WriteLine();
    Console.WriteLine("Press enter to go again or type 'exit' to quit.");
    string continueInput = Console.ReadLine()?.Trim().ToLower();

    // Exit condition
    if (continueInput == "exit")
    {
        Console.WriteLine("Thanks for playing!");
        Thread.Sleep(500);
        break;
    }

    Console.Clear(); // Clear console for a fresh start
}