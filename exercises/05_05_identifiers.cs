// All C# variables must be identified with unique names.

using System;

namespace exercises
{
  class Identifiers
  {
    static void Main(string[] args)
    {

      // Note: It is recommended to use descriptive names
      // for your variables to make your code more readable and maintainable.
      int minutesPerHour = 60;

      // Not recommended, as it is not descriptive.
      int m = 60; 

      // Use the variable(s) in your code.
      Console.WriteLine("The value of minutesPerHour is: " + minutesPerHour);
      Console.WriteLine("The value of m is: " + m);
    }
  }
}