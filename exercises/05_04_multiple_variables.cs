// To declare more than one variable of the same type, use a comma-separated list.

using System;

namespace exercises
{
  class MultipleVariables
  {
    static void Main(string[] args)
    {
      // Declare multiple variables of the same type in one line.
      int x = 5, y = 10, z = 15;
      Console.WriteLine("x: " + x);
      Console.WriteLine("y: " + y);
      Console.WriteLine("z: " + z);
      Console.WriteLine("");

      // You can also declare multiple variables without initializing them.
      int a, b, c;
      a = 20;
      b = 25;
      c = 30;
      Console.WriteLine("a: " + a);
      Console.WriteLine("b: " + b);
      Console.WriteLine("c: " + c);
    }
  }
}