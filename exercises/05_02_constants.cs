// Constants are useful When you want to declare the value of a variable as unchangeable.

using System;

namespace exercises
{
  class Constants
  {
    static void Main(string[] args)
    {
      // The "const" keyword is used to declare a constant variable.
      const double pi = 3.14159;

      // The value of a constant variable cannot be changed.
      // Uncommenting the line below will result in a compilation error.
      // pi = 3.14;

      Console.WriteLine("The value of pi is: " + pi);
    }
  }
}