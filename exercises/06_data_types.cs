// A data type specifies the size and type of variable values.

using System;

namespace exercises
{
  class DataTypes
  {
    static void Main(string[] args)
    {
      // Data types

      // Integer types
      int myInt = 100; 
      long myLong = 10000000000L;

      // Floating-point types
      float myFloat = 3.14F;
      double myDouble = 3.14159;

      // Character and string types
      char myChar = 'L';
      string myString = "Hello, World!";

      // Boolean type
      bool myBool = true;
      
      // Output the values
      Console.WriteLine(myInt);
      Console.WriteLine(myLong);
      Console.WriteLine(myFloat);
      Console.WriteLine(myDouble);
      Console.WriteLine(myChar);
      Console.WriteLine(myString);
      Console.WriteLine(myBool);

    }
  }
}