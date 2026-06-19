// To combine both text and a variable, use the + character.

using System;

namespace exercises
{
  class DisplayVariables
  {
    static void Main(string[] args)
    {
      // Declare a variable to hold the value of pi.
      double pi = 3.14159;

      // Use the + character to combine text and the variable.
      Console.WriteLine("The value of pi is: " + pi);

      // You can also use the + character to combine multiple variables.
      string firstName = "John";
      string lastName = "Doe";
      string fullName = firstName + " " + lastName;
      Console.WriteLine("Full name: " + fullName);

      // For numeric values, the + character works as a mathematical operator.
      int x = 5;
      int y = 10;
      int sum = x + y;
      Console.WriteLine("The sum of x and y is: " + sum);
    }
  }
}