using System;

namespace Ice_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt the user for the input of values
            Console.WriteLine("Input the first number to multiply: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            int c = int.Parse(Console.ReadLine());
            
            // Calculate total by multiplying the values input by user 
            int total = a * b * c;

            // Display the equation and total 
            Console.WriteLine(a +" x "+ b +" x "+ c +" = "+ total);
            Console.ReadLine();

        }
    }
}
