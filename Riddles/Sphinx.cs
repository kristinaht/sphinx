using System;
using System.Collections.Generic;

namespace RiddlesOfTheSphinx.Riddles
{
  public class Sphinx
  {
    string[] questions = {"What's the air speed velocity of an unladen swallow?", "What's your favorite color?", "What is the Capital of Assyria?", "What's 2 + 2?"};
    string[] answers = {"African or European", "Blue", "I don't know", "4"};

    public void AskRiddle()
    {
      Random rnd = new Random();
      int rng = rnd.Next(0, 3);
      Console.WriteLine(questions[rng]);  
      string inputAnswer = Console.ReadLine();
      if (inputAnswer == answers[rng])
      {
        Console.WriteLine("you are correct! You get to live, for now....");
        AskRiddle();
      }
      else
      {
        Console.WriteLine("You are incorrect, and as a consequence you shall be executed");
      } 
    }
  }
}