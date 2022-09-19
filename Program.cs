using System;
using System.Collections.Generic;
using Riddles.Models;

namespace Riddles
{
  public class Program
  {
    public static void Main()
    {
      string correctAnswer = "You have answered correctly and defeated the Mighty Sphinx!";
      string incorrectAnswer = "You have been eaten by the Mighty Sphinx! Better luck next time!";
      Riddle age = new Riddle("What goes up, but never comes down?", "age");
      Console.WriteLine(age.GetQuestion());
      string riddleAnswer = Console.ReadLine();
      riddleAnswer = riddleAnswer.ToLower();
      if (riddleAnswer == age.GetAnswer())
      {
        Console.WriteLine(correctAnswer);
      }
      else
      {
        Console.WriteLine(incorrectAnswer);
      }
      //Console.WriteLine("You have been greeted by the Mighty Sphinx! Answer my riddle correctly or I will eat you!");
      //Console.WriteLine("What goes up, but never comes down?");
      
      
      // if (riddleAnswer == "your age" || riddleAnswer == "age")
      // {
      //   Console.WriteLine("You have answered correctly and defeated the Misghty Sphinx!");
      // } else 
      // {
      //   Console.WriteLine("You have been eaten by the Mighty Sphinx! Better luck next time!");
      // }

      // riddle riddleName = new riddle(a, b)
      // writeline(a)
      // get answer
      // if anwer == b


    }


   // ask a riddle

   // if user input solves it they escape
   // if not they get eaten

   //later we ask more than one question
   //then we build a thing to ask random questions 
  }
} 