using System;

namespace Basic_CSharp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Types();
            Operations();
            ConcatenationInterpolation();
            Convertation();
        }

        static void Types()
        {
            //Main Types of Variables: int | uint | float | string

            //Integers (Целочисленные)
            byte b;         // from 0 to 255
            sbyte sb;       // from -128 to 127, can have sign minus (negative number)
            short sh;       // from -32768 to 32767
            ushort ush;     // from 0 to 65535 (unsigned)
            int i;          // from -2147483648 to 2147483647
            uint ui;        // from 0 to 4294967295
            long lnMin = long.MinValue; // see the value
            long lnMax = long.MaxValue; // see the value
            ulong ulnMin = ulong.MinValue; // see the value
            ulong ulnMax = ulong.MaxValue; // see the value

            //Floating Point Numbers (числа с плавающей точкой)
            float fl = 5.7f;       // 7 signs after point
            double db;      // 15 signs after point

            //Symbol Type
            char cr = '@';   //using single quotes for char and can contain just one symbol

            //String Type
            string str = ""; //string can be empty

            //Boolean
            bool bl = true; // can contain true or false
        }

        static void Operations()
        {

            // Arithmetic operators
            // + - * / % (as usual)
            
            int resultInt = 5 / 2; // 2, because we use two integer
            float resultFloat = 5 / 2.0f; // 2.5, and assign it to type float (or 5.0 / 2) must be one of float number

            // one more variant (convert type)
            int x = 5;
            int y = 2;
            float result = Convert.ToSingle(x) / y;

            // Logical operators (as usual)
        }

        static void ConcatenationInterpolation()
        {
            // Concatenation string + string = string, number + string = numberstring, etc...
            // Interpolation
            string name = "Jeckill";
            string job = "doctor";
            int age = 48;

            string result = $"My name is {name}. I am a {job} and my age is {age} years"; // similar JS with ``
        }

        static void Convertation()
        {
            int age;
            string num = "15";

            age = Convert.ToInt32(num);
            Console.WriteLine(age);
        }
    }
}
