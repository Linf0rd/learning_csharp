// Variables are containers for storing data values.

using System;

namespace exercises
{
  class Variables
  {
    static void Main(string[] args)
    {
      // "int" - stores whole numbers without decimals
      int myNum = 15;
      Console.WriteLine(myNum);
      Console.WriteLine("");

      // "double" - stores floating point numbers with decimals.
      double myDoubleNum = 5.99D;
      Console.WriteLine(myDoubleNum);
      Console.WriteLine("");

      // "char" - stores single characters.
      char myLetter = 'L';
      Console.WriteLine(myLetter);
      Console.WriteLine("");

      // "string" - stores text.
      string name = "Linf0rd";
      Console.WriteLine(name);
      Console.WriteLine("");

      // "bool" - stores values with two states: true or false.
      bool myBool = true;
      Console.WriteLine(myBool);
      Console.WriteLine("");
    }
  }
}