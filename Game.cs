
using System;
namespace cSharpRps
{
  class Game
  {
    public bool Playing { get; private set; }
    public int RoundsWon { get; private set; }

    public int RoundsLost { get; private set; }
    public List<string> playChoices { get; private set; }

    public Game()
    {
      RoundsWon = 0;
      RoundsLost = 0;
      playChoices = new List<string>() { "Rock", "Paper", "Scissors" };
      Playing = true;
      while (Playing)
      {
        GetPlayerInput();
      }
    }
    private void GetPlayerInput()
    {
      // Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("Let's play: Rock, Paper, Scissors! Type an option!");
      Console.WriteLine($"Rounds Won: {RoundsWon}");
      if (RoundsLost > 0)
      {
        Console.Write($"Rounds Lost: {RoundsLost}");
      }
      string input = Console.ReadLine();
      PlayerInput(input);
    }

    private void PlayerInput(string input)
    {
      string playerInput = input.ToLower();
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("You played " + playerInput + "!");
      Random rand = new Random();
      int randChoice = rand.Next(0, 2);
      string compChoice = playChoices[randChoice].ToLower();
      Console.WriteLine($"Computer played {compChoice}!");
      if (playerInput == compChoice)
      {
        Console.WriteLine("This round was a DRAW!");
      }
      else if (playerInput == "rock" && compChoice == "paper")
      {
        Console.WriteLine("Game Result: You LOSE!");
        RoundsLost += 1;
      }
      else if (playerInput == "paper" && compChoice == "scissors")
      {
        Console.WriteLine("Game Result: You LOSE!");
        RoundsLost += 1;
      }
      else if (playerInput == "scissors" && compChoice == "rock")
      {
        Console.WriteLine("Game Result: You LOSE!");
        RoundsLost += 1;
      }
      else if (playerInput == "rock" && compChoice == "scissors")
      {
        Console.WriteLine("Game Result: You WIN!");
        RoundsWon += 1;
      }
      else if (playerInput == "scissors" && compChoice == "paper")
      {
        Console.WriteLine("Game Result: You WIN!");
        RoundsWon += 1;
      }
      else if (playerInput == "paper" && compChoice == "rock")
      {
        Console.WriteLine("Game Result: You WIN!");
        RoundsWon += 1;
      }
      GetPlayerAnswer();
    }
    private void GetPlayerAnswer()
    {
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("Play again? Type 'Yes' or 'No'. ");
      Console.WriteLine($"Rounds Won: {RoundsWon} ", $"Rounds Lost: {RoundsLost}");
      string playAgain = Console.ReadLine().ToLower();
      if (playAgain == "yes")
      {
        Console.WriteLine($"You said {playAgain}!");
        Console.WriteLine("Let's play: Rock, Paper, Scissors! Type an option!");
        Console.WriteLine($"Rounds Won: {RoundsWon} ", $"Rounds Lost: {RoundsLost}");
        string input = Console.ReadLine();
        PlayerInput(input);
      }
      else
      {
        return;
      }
    }
  }
}