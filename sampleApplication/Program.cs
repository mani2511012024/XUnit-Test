using System;

namespace sampleApplications
{
    public class Program
    {
        public static long calculateFactorial(int value)
        {
            if(value < 0)
            {
                Console.WriteLine("Invalid Input");
                return -1;
            }

            if(value == 0 || value == 1)
            {
                return 1;
            }

            long result = 1;
            for(int i = 2; i<=value; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}