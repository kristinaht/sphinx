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
    // string inputAnswer = Console.ReadLine();
    Console.WriteLine(answers[rng]);
    // if (inputAnswer == answers[rng])
    // {
    //   Console.WriteLine("you are correct! You get to live, for now....");
    // }
    // else
    // {
    //   Console.WriteLine("You are incorrect, and as a consequence you shall be executed");
    //   Main();
    // }
    Console.WriteLine("you win!");
  }
}
// string q1 = Console.WriteLine("Question 1: What's the air speed velocity of an unladen swallow?");
    // string answer1 = Console.ReadLine();
    // string correctAnswer = "African or European?";

    // if (answer1 == correctAnswer)
    // {
    //   Console.WriteLine("You get to live. For now!");
    // }
    // else
    // {
    //   Console.WriteLine("You die.");
    //   Main();
    // }
    // string q2 = Console.WriteLine("Question2: What's your favorite color?");
    // string answer2 = Console.ReadLine();
    // string incorrectAnswer2 = "Blue";
    // if (answer2 != incorrectAnswer2)
    // {
    //   Console.WriteLine("You live!");
    // }
    // else
    // {
    //   Console.WriteLine("You die.");
    //   Main();
    // }
    // string q3 = Console.WriteLine("Question3: What is the Capital of Assyria?");
    // string answer3 = Console.ReadLine();
    // string incorrectAnswer3 = "I don't know";
    // if(answer3 != incorrectAnswer3)
    // {
    //   Console.WriteLine("You live!");
    // }
    // else 
    // {
    //   Console.WriteLine("You die!");
    //   Main();
    // }
    // string q4 = Console.WriteLine("Question4: What's 2 + 2?");
    // string answer4 = Console.ReadLine();
    // string correctAnswer4 = "4";
    // if (answer4 == correctAnswer4)
    // {
    //   Console.WriteLine("You are still alive!");
    // }
    // else
    // {
    //   Console.WriteLine("You die.");
    //   Main();
    // }
    // Console.WriteLine("You've successfully answered all the questions correctly! You win!");
    // object[] questions = {q1, q2, q3, q4};