using System;
using System.Collections.Generic;

class Sphinx
{
  static void Main()
  {
    Console.WriteLine("Hello! I'm the Sphinx. If you solve the riddle you get to live! If you don't, you die!!!");
    Console.WriteLine("Question 1: What's the air speed velocity of an unladen swallow?");
    string answer1 = Console.ReadLine();
    string correctAnswer = "African or European?";

    if (answer1 == correctAnswer)
    {
      Console.WriteLine("You get to live. For now!");
    }
    else
    {
      Console.WriteLine("You die.");
      Main();
    }
    Console.WriteLine("Question2: What's your favorite color?");
    string answer2 = Console.ReadLine();
    string incorrectAnswer2 = "Blue";
    if (answer2 != incorrectAnswer2)
    {
      Console.WriteLine("You live!");
    }
    else
    {
      Console.WriteLine("You die.");
      Main();
    }
    Console.WriteLine("Question3: What is the Capital of Assyria?");
    string answer3 = Console.ReadLine();
    string incorrectAnswer3 = "I don't know";
    if(answer3 != incorrectAnswer3)
    {
      Console.WriteLine("You live!");
    }
    else 
    {
      Console.WriteLine("You die!");
      Main();
    }
    Console.WriteLine("Question4: What's 2 + 2?");
    string answer4 = Console.ReadLine();
    string correctAnswer4 = "4";
    if (answer4 == correctAnswer4)
    {
      Console.WriteLine("You are still alive!");
    }
    else
    {
      Console.WriteLine("You die.");
      Main();
    }
    Console.WriteLine("You've successfully answered all the questions correctly! You win!");
  }
}