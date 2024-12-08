namespace task05
{
    using System;

    class Program
    {
        /*     static void DivideTwoIntegers()
             {
                 try
                 {
                     Console.Write("Enter the first integer: ");
                     int number1 = int.Parse(Console.ReadLine());

                     Console.Write("Enter the second integer: ");
                     int number2 = int.Parse(Console.ReadLine());


                     int result = number1 / number2;
                     Console.WriteLine($"The result of dividing {number1} by {number2} is: {result}");
                 }
                 catch (DivideByZeroException)
                 {
                     Console.WriteLine("Error: Division by zero is not allowed.");
                 }
                 catch (FormatException)
                 {
                     Console.WriteLine("Error: Please enter valid integers.");
                 }
                 finally
                 {

                     Console.WriteLine("Operation complete.");
                 }
             }
         }
        }*/



        /*  static void TestDefensiveCode()
          {
              int x, y;


              while (true)
              {
                  Console.Write("Enter a positive integer for X: ");
                  if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                      break;
                  Console.WriteLine("Invalid input. X must be a positive integer.");
              }

              while (true)
              {
                  Console.Write("Enter a positive integer greater than 1 for Y: ");
                  if (int.TryParse(Console.ReadLine(), out y) && y > 1)
                      break;
                  Console.WriteLine("Invalid input. Y must be a positive integer greater than 1.");
              }

              Console.WriteLine($"You entered X = {x}, Y = {y}");
          }

          static void Main()
          {
              Console.WriteLine("Problem 1: Division of Two Integers");
              DivideTwoIntegers();
              Console.WriteLine(); 


              Console.WriteLine("Problem 2: Validate X and Y");
              TestDefensiveCode();
          }
        }
        }*/




        /* static void NullableIntegerDemo()
              {

                  int? nullableInt = null;

                  int result = nullableInt ?? 10;
                  Console.WriteLine($"Result using null-coalescing operator: {result}");

                  if (nullableInt.HasValue)
                  {
                      Console.WriteLine($"The value of nullableInt is: {nullableInt.Value}");
                  }
                  else
                  {
                      Console.WriteLine("nullableInt does not have a value.");
                  }
              }
              */


        /* static void ArrayBoundsDemo()
             {

                 int[] arr = new int[5] { 1, 2, 3, 4, 5 };

                 try
                 {

                     Console.WriteLine($"Accessing element at index 10: {arr[10]}");
                 }
                 catch (IndexOutOfRangeException ex)
                 {

                     Console.WriteLine($"Error: {ex.Message}");
                 }
             }

             static void Main()
             {

                 Console.WriteLine("Problem 1: Nullable Integer with Null-Coalescing and HasValue/Value");
                 NullableIntegerDemo();
                 Console.WriteLine(); 
                 Console.WriteLine("Problem 2: Array Bounds Checking with IndexOutOfRangeException");
                 ArrayBoundsDemo();
             }
         }
        }*/





        /*    static void ArraySumDemo()
            {

                int[,] array = new int[3, 3];

                Console.WriteLine("Enter the values for the 3x3 array:");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Enter value for element ({i + 1},{j + 1}): ");
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nSum of elements in each row:");
                for (int i = 0; i < 3; i++)
                {
                    int rowSum = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        rowSum += array[i, j];
                    }
                    Console.WriteLine($"Row {i + 1} sum: {rowSum}");
                }

                Console.WriteLine("\nSum of elements in each column:");
                for (int j = 0; j < 3; j++)
                {
                    int columnSum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        columnSum += array[i, j];
                    }
                    Console.WriteLine($"Column {j + 1} sum: {columnSum}");
                }
            }
        }
        }*/


        /*   static void NullableStringDemo()
           {
               string? nullableString = null;


               Console.Write("Enter a string (or press Enter to leave it empty): ");
               string input = Console.ReadLine();

               if (!string.IsNullOrEmpty(input))
               {
                   nullableString = input;
               }

               Console.WriteLine($"You entered: {nullableString!}"); 
           }
        }
        }*/




        /*   static void Main()
           {
               int value = 42; 
               object boxedValue = value; 
               Console.WriteLine($"Boxed Value: {boxedValue}");


               try
               {

                   int unboxedValue = (int)boxedValue; 
                   Console.WriteLine($"Unboxed Value: {unboxedValue}");
               }
               catch (InvalidCastException ex)
               {

                   Console.WriteLine("Invalid unboxing attempt: " + ex.Message);
               }

               // Demonstrating an invalid unboxing
               try
               {

                   string invalidUnbox = (string)boxedValue; 
                   Console.WriteLine($"Invalid Unboxed Value: {invalidUnbox}");
               }
               catch (InvalidCastException ex)
               {
                   Console.WriteLine("Invalid unboxing attempt: " + ex.Message);
               }
           }
        }


        }*/




        /*  static void SumAndMultiply(int x, int y, out int sum, out int product)
          {
              sum = x + y;
              product = x * y;
          }
          static void Main()
          {

              Console.WriteLine("Problem 1: SumAndMultiply Method");
              int sum, product;
              SumAndMultiply(7, 3, out sum, out product);
              Console.WriteLine($"Sum: {sum}, Product: {product}");
              Console.WriteLine();

          }
        }
        }*/


        /*  static void PrintStringMultipleTimes(string text, int times = 5)
          {
              for (int i = 0; i < times; i++)
              {
                  Console.WriteLine(text);
              }
          }
          static void Main()
          {
              Console.WriteLine("Problem 2: Print String with Optional Parameters");
              PrintStringMultipleTimes("Hello, World!"); // Default value for `times` (5)
              Console.WriteLine(); // Line break
              PrintStringMultipleTimes("C# is great!", times: 3);
          }
        }
        }*/




        /* Write a program that: 
        o Declares a nullable integer array. 
        o Uses the null propagation operator (?.) to safely access its properties.  
          static void Main()
           {
               Console.WriteLine(" Nullable Integer Array");
               int?[] nullableArray = null;
               Console.WriteLine($"Array Length: {nullableArray?.Length ?? 0}");
               nullableArray = new int?[] { 1, 2, null, 4 };
               Console.WriteLine($"Array Length after initialization: {nullableArray?.Length}");
               Console.WriteLine();
           }
        }
        }*/




        /*  Day of the Week
                static void Main()
          {
              Console.WriteLine(" Day of the Week Mapping");
              Console.Write("Enter a day of the week: ");
              string day = Console.ReadLine()?.Trim() ?? string.Empty;
              int dayNumber = day.ToLower() switch
              {
                  "monday" => 1,
                  "tuesday" => 2,
                  "wednesday" => 3,
                  "thursday" => 4,
                  "friday" => 5,
                  "saturday" => 6,
                  "sunday" => 7,
                  _ => 0
              };
              if (dayNumber > 0)
                  Console.WriteLine($"The corresponding number for {day} is {dayNumber}.");
              else
                  Console.WriteLine("Invalid day entered.");
              Console.WriteLine();
          }
        }
        }*/




        /*  SumArray Method
                 static void Main()
           {
               Console.WriteLine(" SumArray Method");
               int sum1 = SumArray(1, 2, 3, 4, 5); 
               Console.WriteLine($"Sum of individual values: {sum1}");
               int[] numbers = { 10, 20, 30 };
               int sum2 = SumArray(numbers); 
               Console.WriteLine($"Sum of array values: {sum2}");
           }

           static int SumArray(params int[] numbers)
           {
               int sum = 0;
               foreach (int num in numbers)
               {
                   sum += num;
               }
               return sum;
           }
        }
        }*/


        /* Print Numbers in a Range
         static void Main()
         {

             Console.WriteLine(" Print Numbers in a Range");
             Console.Write("Enter a positive integer: ");
             if (int.TryParse(Console.ReadLine(), out int rangeNumber) && rangeNumber > 0)
             {
                 Console.Write("Output: ");
                 for (int i = 1; i <= rangeNumber; i++)
                 {
                     if (i == rangeNumber)
                         Console.Write($"{i}");
                     else
                         Console.Write($"{i}, ");
                 }
                 Console.WriteLine();
             }
             else
             {
                 Console.WriteLine("Please enter a valid positive integer.");
             }
             Console.WriteLine();

         }
        }
        }*/

        /*   Display Multiplication Table
                static void Main()
            {
                Console.WriteLine(" Display Multiplication Table");
                Console.Write("Enter an integer: ");
                if (int.TryParse(Console.ReadLine(), out int tableNumber))
                {
                    Console.Write("Output: ");
                    for (int i = 1; i <= 12; i++)
                    {
                        if (i == 12)
                            Console.Write($"{tableNumber * i}"); 
                            Console.Write($"{tableNumber * i}, ");
                    }
                    Console.WriteLine(); 
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
                Console.WriteLine();
            }
        }
        }*/

        /*  // List Even Numbers
          static void Main()
          {
              Console.WriteLine(" List Even Numbers");
              Console.Write("Enter a number: ");
              if (int.TryParse(Console.ReadLine(), out int evenRangeNumber) && evenRangeNumber > 0)
              {
                  Console.Write("Output: ");
                  bool printed = false;
                  for (int i = 2; i <= evenRangeNumber; i += 2)
                  {
                      if (i > 2)
                          Console.Write(", ");
                      Console.Write(i);
                      printed = true;
                  }

                  if (!printed)
                      Console.Write("No even numbers found in the range.");
                  Console.WriteLine(); 
              }
              else
              {
                  Console.WriteLine("Please enter a valid positive integer.");
              }
          }
        }
        }*/


        /*Write a program that takes two integers,  
           static void Main()
           {

               Console.WriteLine(": Compute Exponentiation");
               Console.Write("Enter the base number: ");
               int baseNumber = int.Parse(Console.ReadLine());
               Console.Write("Enter the exponent: ");
               int exponent = int.Parse(Console.ReadLine());
               Console.WriteLine($"Output: {Math.Pow(baseNumber, exponent)}");
               Console.WriteLine();
           }
        }
        }*/

        /* : Reverse a Text String
                 static void Main()
             {
                 Console.WriteLine(" Reverse a Text String");
       Console.Write("Enter a string: ");
       string inputString = Console.ReadLine();
       string reversedString = new string(inputString.Reverse().ToArray());
       Console.WriteLine($"Output: {reversedString}");
       Console.WriteLine();
     }
     }
     }*/

        /*  Reverse an Integer Value
        static void Main()
        {
            Console.WriteLine(" Reverse an Integer Value");
            Console.Write("Enter an integer: ");
            string integerInput = Console.ReadLine();
            string reversedInteger = new string(integerInput.Reverse().ToArray());
            Console.WriteLine($"Output: {reversedInteger}");
            Console.WriteLine();
        }
    }
}*/




        /*   static void Main()
           {
               Console.WriteLine(" Find Longest Distance Between Matching Elements");
               Console.Write("Enter array elements separated by spaces: ");
               int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
               int maxDistance = 0;
               for (int i = 0; i < array.Length; i++)
               {
                   for (int j = i + 1; j < array.Length; j++)
                   {
                       if (array[i] == array[j])
                       {
                           int distance = j - i;
                           if (distance > maxDistance)
                               maxDistance = distance;

                           Console.WriteLine($"Longest Distance: {maxDistance}");
                           Console.WriteLine();

                       }
                   }
               }
           }
       }
   }*/

       /* //  : Reverse Words in a Sentence
        static void Main()
        {
            Console.WriteLine(" Reverse Words in a Sentence");
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string reversedSentence = string.Join(" ", sentence.Split(' ').Reverse());
            Console.WriteLine($"Output: {reversedSentence}");
        }
    }
}*/







