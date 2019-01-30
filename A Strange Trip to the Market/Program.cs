using System;

namespace A_Strange_Trip_to_the_Market
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }
        public static class Kata
        {
            public static bool IsLockNessMonster(string sentence)
            {
                if (sentence.Contains("3.50") || sentence.Contains("three fifty"))
                {
                    return true;
                 }
                return false;
            }
        }
    }
}
