using System;

namespace RockPaperSissors
{
  class Program
  {
    //Prompts for User Input Rock Paper Sissors
    //Check the user input is valid
    //If the user input is valid, compare with the computer generated option. 
    //Return Win/Lost message
    //Continue to play the game until user stops.
    //Computer Pick 1:Rock, 2: Paper, 3: Sissors
    static void Main(string[] args)
    {

      Console.Clear();
      Random random = new Random();
      int comNumber = random.Next(1, 4);
      string comPick = "";
      string userPick = "";
      bool validPick = false;
      bool playMore = true;
      bool valResponse = false;

      do
      {
        Console.WriteLine("Enter Rock, Paper, or Sissors!");
        userPick = Console.ReadLine();
        userPick.ToLower();

        if ((userPick == "rock") || (userPick == "paper") || (userPick == "sissors"))
        {
          validPick = true;
          break;
        }
        else
        {
          Console.WriteLine("Please enter Rock, Paper, or Sissors");

        }
      } while (!validPick);

      switch (comNumber)
      {
        case 1:
          comPick = "rock";
          break;
        case 2:
          comPick = "paper";
          break;
        case 3:
          comPick = "sissors";
          break;
      }

      if (userPick == comPick)
      {
        Console.WriteLine("It's tie!");
      }
      else if (userPick == "rock")
      {
        if (comPick == "paper")
        {
          Console.WriteLine("Computer Picked Paper. You lost!");
        }
        else if (comPick == "sissors")
        {
          Console.WriteLine("Computer Picked Sissors. You Win!");
        }
      }
      else if (userPick == "paper")
      {
        if (comPick == "rock")
        {
          Console.WriteLine("Computer Picked Rock. You Win!");
        }
        else if (comPick == "sissors")
        {
          Console.WriteLine("Computer Picked Sissors. You Lost!");
        }
      }
      else if (userPick == "sissors")
      {
        if (comPick == "rock")
        {
          Console.WriteLine("Computer Picked Rock. You Lost!");
        }
        else if (comPick == "paper")
        {
          Console.WriteLine("Computer Picked Paper. You Win!");
        }
      }
      else
      {
        Console.WriteLine("You entered invalid input!");
      }


      while (valResponse)
      {
        Console.WriteLine("Do you want to play again? Enter Yes or No");
        string userContinue = Console.ReadLine();
        userContinue.ToLower();
        if (userContinue == "yes")
        {
          valResponse = true;
          playMore = true;
          break;
        }
        else if (userContinue == "no")
        {
          valResponse = true;
          playMore = false;
          break;
        }
        else
        {
          valResponse = false;
        }

      }
    }
  }
}







