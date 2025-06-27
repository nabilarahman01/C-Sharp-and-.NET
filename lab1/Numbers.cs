using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Numbers
    {
        public void PlayWithNumbers()
        {
            //32 bit signed integer   (range -2,147,483,648 to +2,147,483,647)

            int max = Int32.MaxValue;
            int min = Int32.MinValue;

            Console.WriteLine($"Min value: {min} and Max value {max}");
            Console.WriteLine($"Min value: {min - 1} and Max value {max + 1}");

            // Type Casting
            Console.WriteLine("\nnumber 1: ");
            int num1= Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine() );

            Console.WriteLine($"\nthe sum of two numbers is {num1+num2}");
            Console.WriteLine($"the subtraction of two numbers is {num1 - num2}");
            Console.WriteLine($"the multiplication of two numbers is {num1 * num2}");
            Console.WriteLine($"the division of two numbers is {num1 / num2} \n");

            int integerNumber = 10;
            double doubleNumber = 10.5;

            Console.WriteLine("Int to Double Conversion: " + Convert.ToDouble(integerNumber));
            Console.WriteLine("Double to Int Conversion: " + Convert.ToInt32(doubleNumber));

            // Calculate Area of a Circle

            double radius = 2.5;
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Area of the circle: {area}");

            Console.ReadLine();
        }
    }
}
