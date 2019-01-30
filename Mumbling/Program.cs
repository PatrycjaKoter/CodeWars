using System;

namespace Mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Accumul.Accum("alaKaaal"));
            Console.ReadKey();

        }
    }

    public class Accumul
    {
        public static String Accum(string s)
        {
            string newString = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (j==i)
                    {
                        newString = newString + s[i].ToString().ToUpper();
                    }
                    else
                    {
                        newString = newString + s[i].ToString().ToLower();
                    }
                }

                if (i<(s.Length-1))
                {
                    newString += "-";
                }
            }
            return newString;
        }
    }
}
