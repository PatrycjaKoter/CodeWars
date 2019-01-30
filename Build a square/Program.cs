using System;

namespace Build_a_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GenerateShape(5));
            Console.ReadKey();
        }
    }

    public static class Kata
    {
        public static string GenerateShape(int n)
        {
            string kaja = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kaja += "+";

                    if (i != (n - 1))
                    {
                        if (j == (n - 1))
                        {
                            kaja += "";
                        }
                    }
                }
            }
            return kaja;
        }
    }
}
