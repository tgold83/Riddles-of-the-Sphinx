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
      Riddle shirt = new Riddle("What has a neck but no head?", "shirt");
      Riddle death = new Riddle("Some try to hide, some try to cheat; but time will show, we always will meet. Try as you might to guess my name.", "death");
      List<Riddle> list1 = new List<Riddle> {age, towel, future, shirt, death};
      List<Riddle> list2 = new List<Riddle> {};
      int constnum = list1.Count;
      for (int x = 0; x < constnum; x++)
      {
        Random rnd = new Random();
        int rndnum = rnd.Next(0, constnum - x);
        list2.Add(list1[rndnum]);
        list1.Remove(list1[rndnum]);
      }
      if (ask.askRiddle(list2[0]))
      {
        if (ask.askRiddle(list2[1]))
        {
          if (ask.askRiddle(list2[2]))
          {
            if (ask.askRiddle(list2[3]))
            {
              if (ask.askRiddle(list2[4]))
              {
                Console.WriteLine("You have answered all the questions correctly and defeated the Mighty Sphinx!");
              }
            }
          }
        }
      }
    }
  }
} 