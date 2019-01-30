using System;

namespace KanaKonverter_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KanaKonverter.vowels("aoeiouyEAE", "romaji"));
            Console.WriteLine(KanaKonverter.vowels("AEEOIEAE", "katakana"));
            Console.WriteLine(KanaKonverter.vowels("AEEOIEAE", "hiragana"));

            Console.ReadKey();


        }

        public class KanaKonverter
        {
            public static string vowels(string input, string output)
            {
                string romajiDictLow = "aeiou";
                string romajiDictUp = "AEIOU";
                string hiraDict = "あえいおう";
                string kataDict = "アエイオウ";

                if (input == "")
                {
                    return "";
                }

                return translator( input, output);
            }

            private static string translator( string input, string output)
            {
                string transtaledWord = "";

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 'ア')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'あ';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'ア';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'a';
                        }
                    }
                    if (input[i] == 'エ')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'え';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'エ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'e';
                        }
                    }
                    if (input[i] == 'イ')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'い';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'イ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'i';
                        }
                    }
                    if (input[i] == 'ウ')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'う';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'ウ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'u';
                        }
                    }
                    if (input[i] == 'オ')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'お';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'オ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'o';
                        }
                    }
                    if (input[i] == 'あ')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'あ';
                        }
                        if (output == "katakana")
                        {
                            transtaledWord += 'ア';
                        }
                        if (output == "romaji")
                        {
                            transtaledWord += 'a';
                        }
                    }
                    if (input[i] == 'え')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'え';
                        }
                        if (output == "katakana")
                        {
                            transtaledWord += 'エ';
                        }
                        if (output == "romaji")
                        {
                            transtaledWord += 'e';
                        }
                    }
                    if (input[i] == 'い')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'い';
                        }
                        if (output == "katakana")
                        {
                            transtaledWord += 'イ';
                        }
                        if (output == "romaji")
                        {
                            transtaledWord += 'i';
                        }
                    }
                    if (input[i] == 'う')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'う';
                        }
                        if (output == "katakana")
                        {
                            transtaledWord += 'ウ';
                        }
                        if (output == "romaji")
                        {
                            transtaledWord += 'u';
                        }
                    }
                    if (input[i] == 'お')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'お';
                        }
                        if (output == "katakana")
                        {
                            transtaledWord += 'オ';
                        }
                        if (output == "romaji")
                        {
                            transtaledWord += 'o';
                        }
                    }


                    if (input[i] == 'a')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'あ';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'ア';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'a';
                        }
                    }
                    if (input[i] == 'A')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'あ';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'ア';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'A';
                        }
                    }
                    if (input[i] == 'e')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'え';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'エ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'e';
                        }
                    }
                    if (input[i] == 'E')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'え';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'エ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'E';
                        }
                    }
                    if (input[i] == 'i')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'い';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'イ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'i';
                        }
                    }
                    if (input[i] == 'I')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'い';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'イ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'I';
                        }
                    }
                    if (input[i] == 'U')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'う';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'ウ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'U';
                        }
                    }
                    if (input[i] == 'u')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'う';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'ウ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'u';
                        }
                    }
                    if (input[i] == 'O')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'お';
                        }
                        else if (output == "katakana")
                        {
                            transtaledWord += 'オ';
                        }
                        else if (output == "romaji")
                        {
                            transtaledWord += 'O';
                        }
                    }
                    if (input[i] == 'o')
                    {
                        if (output == "hiragana")
                        {
                            transtaledWord += 'お';
                        }
                        if (output == "katakana")
                        {
                            transtaledWord += 'オ';
                        }
                        if (output == "romaji")
                        {
                            transtaledWord += 'o';
                        }
                    }
                }
                return transtaledWord;
            }
        }
    }
}
