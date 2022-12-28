using System;

namespace typeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit
            sbyte age=22;
            byte rank=1;
            short birtDay=311;
            int pin = rank+age+birtDay;

            string name="Umit";
            char surName='C';
            object player = name+surName+pin;
            Console.WriteLine("Player: "+ player);

            //Explicit
            double d = 1071.74;
            int i;

            // cast double to int.
            i = (int)d;
            Console.WriteLine(i);

            /*
            ToBoolean
            Converts a type to a Boolean value, where possible.

            ToByte
            Converts a type to a byte.

            ToChar
            Converts a type to a single Unicode character, where possible.

            ToDateTime
            Converts a type (integer or string type) to date-time structures.

            ToDecimal
            Converts a floating point or integer type to a decimal type.

            ToDouble
            Converts a type to a double type.

            ToInt16
            Converts a type to a 16-bit integer.

            ToInt32
            Converts a type to a 32-bit integer.

            ToInt64
            Converts a type to a 64-bit integer.

            ToSbyte
            Converts a type to a signed byte type.

            ToSingle
            Converts a type to a small floating point number.

            ToString
            Converts a type to a string.

            ToType
            Converts a type to a specified type.

            ToUInt16
            Converts a type to an unsigned int type.

            ToUInt32
            Converts a type to an unsigned long type.

            ToUInt64
            Converts a type to an unsigned big integer.
            
            source https://www.tutorialspoint.com/csharp/csharp_type_conversion.htm
            */

            int inToStringTest = 18;
            float floatToStringTest = 54.005f;
            double doubleToStringTest = 1547.7652;
            bool boolToStringTest = false;
            Console.WriteLine(inToStringTest.ToString());
            Console.WriteLine(floatToStringTest.ToString());
            Console.WriteLine(doubleToStringTest.ToString());
            Console.WriteLine(boolToStringTest.ToString());
        }


    }
}

