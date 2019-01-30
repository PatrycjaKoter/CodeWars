using System;

namespace Student_s_Final_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FinalGrade(100, 12));
            Console.WriteLine(FinalGrade(99, 0));
            Console.WriteLine(FinalGrade(10, 15));
            Console.WriteLine(FinalGrade(85, 5));
            Console.WriteLine(FinalGrade(55, 3));
            Console.WriteLine(FinalGrade(55, 0));
            Console.WriteLine(FinalGrade(20, 2));

            Console.ReadKey();
        }

        public static int FinalGrade(int exam, int projects)
        {
            if (exam > 90 || projects > 10)
            {
                return 100;
            }
            if (exam > 75 && projects >= 5)
            {
                return 90;
            }
            if (exam > 50 && projects >= 2)
            {
                return 75;
            }
            return 0;
        }




    }
}
