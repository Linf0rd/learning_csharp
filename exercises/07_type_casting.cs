/* Type casting is when you assign a value of one data type to another type.
 * There are two types of casting in C#:
 * Implicit casting (automatically) - converting a smaller type to a larger type size
 * Explicit casting (manually) - converting a larger type to a smaller size type
 */

using System;

namespace exercises
{
  class TypeCasting
  {
    static void Main(string[] args)
    {
      // Implicit casting
      int myInt = 10;
      double myDouble = myInt; // Automatically converts int to double

      // Explicit casting
      double myOtherDouble = 3.14;
      int myOtherInt = (int)myOtherDouble; // Manually converts double to int

      // Output the values
      Console.WriteLine(myInt);
      Console.WriteLine(myDouble);
      Console.WriteLine(myOtherDouble);
      Console.WriteLine(myOtherInt);


      // Type Conversion Methods

      /* It is also possible to convert data types explicitly by using built-in methods, such as
       *  Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) 
       * and Convert.ToInt64 (long):
       */

      // Convert int to string
      int myInt2 = 42;

      string myString = Convert.ToString(myInt2);

      // Convert string to int
      string myString2 = "123";
      int myInt3 = Convert.ToInt32(myString2);

      // Output the converted values
      Console.WriteLine(myString);
      Console.WriteLine(myInt3);


    }
  }
}