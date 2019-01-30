using System;
using System.Linq;
using System.Net.Http.Headers;

namespace Maximum_Length_Difference
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };

            Console.WriteLine(MaxDiffLength.Mxdiflg(s1, s2));
            Console.ReadKey();
        }
    }

    public class MaxDiffLength
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0)
            {
                return -1;
            }

            string[] s3 = new string[a1.Length + a2.Length];

            for (int i = 0; i < a1.Length; i++)
            {
                s3[i] = a1[i];
            }

            int j = 0;

            for (int i = a1.Length; i < (a1.Length + a2.Length); i++)
            {

                s3[i] = a2[j];
                j++;
            }

            int theLongest = s3[0].Length;
            int theShortest = s3[0].Length;

            for (int i = 0; i < s3.Length; i++)
            {
                if (theShortest > s3[i].Length)
                {
                    theShortest = s3[i].Length;
                }
                if (theLongest < s3[i].Length)
                {
                    theLongest = s3[i].Length;
                }
            }
            return theLongest - theShortest;
        }

    }
}
