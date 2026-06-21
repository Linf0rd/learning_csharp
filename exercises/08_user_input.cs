// Use Console.ReadLine() to get user input.

using System;

namespace exercises
{
  class UserInput
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is your name?");

      // Get user input and store it in a variable
      string name = Console.ReadLine();

      // Output the user's name
      Console.WriteLine("Hello, " + name + "!");


      /* The Console.ReadLine() method returns a string.
       * If you want to convert the input to another data type, 
       * you can use the Convert class methods, such as Convert.ToInt32() for integers.
       */

      // Get user input for age and convert it to an integer
      Console.WriteLine("How old are you?");

      string ageInput = Console.ReadLine();

      int age = Convert.ToInt32(ageInput);

      // Output the user's age
      Console.WriteLine("You are " + age + " years old.");
    }
  }
}