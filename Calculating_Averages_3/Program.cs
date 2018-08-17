using System;

namespace Calculating_Averages_3
{
    class Program
    {
        static void Main()
        {
            double sum = 0, average = 0;
            Console.WriteLine("How many scores would you like to enter? : ");
            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }
            average = sum / numbers.Length;
            Console.WriteLine("{0}", average);
            
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
