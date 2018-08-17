using System;

namespace Calculating_averages
{
    class Program
    {
      static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            string inp = null;
            while (inp != "end")
            {
                Console.Write("Scores ");
                inp = Console.ReadLine();
                int num = 0;
                if (int.TryParse(inp, out num)) ;
                {
                    sum = sum + num;
                    n++;
                }
            }
            int average = sum / n;
            Console.WriteLine("Score: " + average);
            Console.ReadLine();

        }
       

    }
}
