using System;
using System.Collections.Generic;

class Sphinx
{
  static void Main()
  {
    string q1 = "What's the air speed velocity of an unladen swallow?";
    string q2 = "What's your favorite color?";
    string q3 = "What is the Capital of Assyria?";
    string q4 =  "What's 2 + 2?";
    string correct1 = "African or European";
    string correct2 = "Blue";
    string correct3 = "I don't know";
    string correct4 = "4";
    string[] questions = {q1, q2, q3, q4};
    string[] answers = {correct1, correct2, correct3, correct4};
    Random rnd = new Random();
    int rng = rnd.Next(1, 4);      
    Console.WriteLine("Hello! I'm the Sphinx. If you solve the riddle you get to live! If you don't, you die!!!");
    Console.WriteLine(questions[rng]);
    string inputAnswer = Console.ReadLine();
    if (inputAnswer == answers[rng])
    {
      Console.WriteLine("you are correct! You get to live, for now....");
    }
    else
    {
      Console.WriteLine("You are incorrect, and as a consequence you shall be executed");
      Main();
    }
    Random rnd2 = new Random();
    int rng2 = rnd2.Next(1, 4);
    Console.WriteLine(questions[rng2]);      
    string inputAnswer2 = Console.ReadLine();
    if (inputAnswer2 == answers[rng2])
    {
      Console.WriteLine("you are correct! You get to live, for now....");
    }
    else
    {
      Console.WriteLine("You are incorrect, and as a consequence you shall be executed");
      Main();
    }
    
    Random rnd3 = new Random();
    int rng3 = rnd3.Next(1, 4);
    Console.WriteLine(questions[rng3]);      
    string inputAnswer3 = Console.ReadLine();
    if (inputAnswer3 == answers[rng3])
    {
      Console.WriteLine("you are correct! You get to live, for now....");
    }
    else
    {
      Console.WriteLine("You are incorrect, and as a consequence you shall be executed");
      Main();
    }
    Random rnd4 = new Random();
    int rng4 = rnd4.Next(1, 4);
    Console.WriteLine(questions[rng4]);      
    string inputAnswer4 = Console.ReadLine();
    if (inputAnswer4 == answers[rng4])
    {
      Console.WriteLine("you are correct! You get to live, for now....");
    }
    else
    {
      Console.WriteLine("You are incorrect, and as a consequence you shall be executed");
      Main();
    }

    Console.WriteLine("you win!");
  }
}
