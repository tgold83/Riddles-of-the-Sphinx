using System;
using System.Collections.Generic;
using Riddles.Models;

namespace Riddles
{
  public class ask
  {
    public static bool askRiddle(Riddle argument)
    {
      string correctAnswer = "You answered the riddle correctly!";
      string incorrectAnswer = "You have been eaten by the Mighty Sphinx! Better luck next time!";
      Console.WriteLine(argument.GetQuestion());
      string riddleAnswer = Console.ReadLine();
      riddleAnswer = riddleAnswer.ToLower();
      if (riddleAnswer == argument.GetAnswer())
      {
        Console.WriteLine(correctAnswer);
        return true;
      }
      else
      {
        Console.WriteLine(incorrectAnswer);
        return false;
      }
    }
  }
  public class Program
  {
    public static void Main()
    {

      Riddle age = new Riddle("What goes up, but never comes down?", "age");
      Riddle towel = new Riddle("What gets wet as it dries?", "towel");
      Riddle future = new Riddle("What is always in front of you but can't be seen?", "future");
      if (ask.askRiddle(age))
      {
        if (ask.askRiddle(towel))
        {
          if (ask.askRiddle(future))
          {
            Console.WriteLine("You have answered all the questions correctly and defeated the Mighty Sphinx!");
          }
        }
      }
    }
  }
} 