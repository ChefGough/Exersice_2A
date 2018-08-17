using System;

namespace Calculating_Averages_2
{
    class Program
    {
        static void Main()
        {
            
            //This program is for both basic dificulty problems.
            Console.WriteLine("Enter any number between 0 and 100, Enter your 1st number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 2nd number: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 3rd number: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 4th number: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 5th number: ");
            double e = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 6th number: ");
            double f = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 7th number: ");
            double g = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 8th number: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 9th number: ");
            double i = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your 10th nuber: ");
            double j = Double.Parse(Console.ReadLine());

            double average = (a + b + c + e + f + g + h + i + j) / 10;
            Console.WriteLine("The average sum of the 10 numbers is {0}", average);

            if (average >= 90)
            {
                Console.WriteLine("Grade: A");
            }

            else if (average < 90 && average >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            
             else if (average < 80 && average >= 70)
            {
                Console.WriteLine("Grade: C");
            }

            else if (average < 70 && average >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            
            else
            {
                Console.WriteLine("Grade: F");
            }
            Console.ReadLine();
        }
    }
}
