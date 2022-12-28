/*
System.IO.IOException
Handles I/O errors.

System.IndexOutOfRangeException
Handles errors generated when a method refers to an array index out of range.

System.ArrayTypeMismatchException
Handles errors generated when type is mismatched with the array type.
	
System.NullReferenceException
Handles errors generated from referencing a null object.

System.DivideByZeroException
Handles errors generated from dividing a dividend with zero.
	
System.InvalidCastException
Handles errors generated during typecasting.
	
System.OutOfMemoryException
Handles errors generated from insufficient free memory.
	
System.StackOverflowException
Handles errors generated from stack overflow.

source: https://www.tutorialspoint.com/csharp/csharp_exception_handling.htm
*/

using System;
 
class Program {
 
    static void Main(string[] args)
    {
        int[] arr = {19, 0, 75, 52};
 
        try {
 
            // Try to generate an exception
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i] / arr[i + 1]);
            }
        }
 
        // Catch block for invalid array access
        catch (IndexOutOfRangeException e) {
 
            Console.WriteLine("An Exception has occurred : {0}", e.Message);
        }
 
        // Catch block for attempt to divide by zero
        catch (DivideByZeroException e) {
 
            Console.WriteLine("An Exception has occurred : {0}", e.Message);
        }
 
        // Catch block for value being out of range
        catch (ArgumentOutOfRangeException e) {
 
            Console.WriteLine("An Exception has occurred : {0}", e.Message);
        }
 
        // Finally block
        // Will execute irrespective of the above catch blocks
        finally {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(" {0}", arr[i]);
            }
        }
    }
}//source https://www.geeksforgeeks.org/exception-handling-in-c-sharp/