using System;
using System.Collections.Generic;

namespace Riddles
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("You have been greeted by the Mighty Sphinx! Answer my riddle correctly or I will eat you!");
      Console.WriteLine("What goes up, but never comes down?");
      string riddleAnswer = Console.ReadLine();
      riddleAnswer = riddleAnswer.ToLower();
      if (riddleAnswer == "your age" || riddleAnswer == "age")
      {
        Console.WriteLine("You have answered correctly and defeated the Misghty Sphinx!");
      } else 
      {
        Console.WriteLine("You have been eaten by the Mighty Sphinx! Better luck next time!");
      }
    }
   // ask a riddle

   // if user input solves it they escape
   // if not they get eaten

   //later we ask more than one question
   //then we build a thing to ask random questions 
  }
} 