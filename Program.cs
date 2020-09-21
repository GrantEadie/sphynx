using System;
using System.Collections.Generic;
using Sphynx.Riddles;

namespace Sphynx 
{
  public class Program
  {
    public static void Main()
    {
      Riddle fire = new Riddle("I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?", "fire");
      Riddle fence = new Riddle("What runs around the whole yard without moving?", "a fence");
      Riddle cold = new Riddle("What can you catch but never throw?", "a cold");
      Riddle door = new Riddle("A man in a car saw a Golden Door, Silver Door and a Bronze Door. What door did he open first?", "the car door");
      List<Riddle> Riddles = new List<Riddle>() {fire, fence, cold, door};

      Console.WriteLine("Welcome to the Sphynx's layer. Answer my question!");
      
      int fullCount = Riddles.Count;
      for (int i = 1; i <= fullCount; i++)
      {
        Random randomNumber = new Random();
        int index = randomNumber.Next(Riddles.Count);
        Console.WriteLine(Riddles[index].GetRiddleQuestion());
        Console.WriteLine("Enter your answer: ");
        string userAnswer = Console.ReadLine();
        if (i == fullCount) 
        {
          Console.WriteLine("Wow, you win, nice.");
        }
        else
        {
          if (Riddles[index].CheckAnswer(userAnswer)) {
            Console.WriteLine("Correct.");
            Riddles.Remove(Riddles[index]);
          } else 
          {
            Console.WriteLine("Off with your head!");
            break;
          }
        }
      }


      // foreach(Riddle questions in Riddles)
      // {
      //   Console.WriteLine(questions.GetRiddleQuestion());
      //   Console.WriteLine("Enter your answer: ");
      //   string userAnswer = Console.ReadLine();
      //   Console.WriteLine(questions.CheckAnswer(userAnswer));
      // }
    }
  }
}