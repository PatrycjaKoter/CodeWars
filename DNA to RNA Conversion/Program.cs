using System;

namespace DNA_to_RNA_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Converter.DnaToRna("GCAUUUUUUUUUUUUUUUUUUUUUUUU"));
            Console.ReadKey();


        }

       

        public class Converter
        {
            public static string DnaToRna(string dna)
            {
                string rna = "";
                for (int i = 0; i < dna.Length; i++)
                {
                    if (dna[i] == 'U')
                    {
                        rna += "T";
                    }
                    else
                    {
                        rna += dna[i];
                    }
                }
                return rna;
            }
        }



    }
}
