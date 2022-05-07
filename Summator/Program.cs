using System;

namespace Summator
{
    internal class Program
    {
            static void Main(string[] args)
        {
            int result = Summator.Sum(new int[] { 1, 2, 3 , 4, 5, 6});
            if (result == 21)
            {
                Console.WriteLine("TEST PASS");
            }
            else { Console.WriteLine("TEST FAIL"); }
            {

            }
        } 

    }
}