using System;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            byte languageValue;
            do
            {
                Console.Write("About which language do you want to know information? 1 - English, 2 - Spanish, 3 - Ukrainian ");
                line = Console.ReadLine();
            } while (CheckLine(byte.TryParse(line, out languageValue), languageValue));

            ShowInfo(languageValue);
        }
        public enum Language : byte
        {
            English = 1,
            Spanish = 2,
            Ukrainian = 3
        }
        static bool CheckLine(bool isParsed, byte languageValue)
        {
            if (isParsed && languageValue >= 1 && languageValue <= 3)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please follow the instructions and try again");
                return true;
            }
        }
        static void ShowInfo(byte languageValue)
        {
            Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
            Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
            Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");
        }
    }
}