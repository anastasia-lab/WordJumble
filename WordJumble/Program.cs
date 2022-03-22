using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordJumble
{
    class Program
    {
        static string[] GetStringSplit(string inputString)
        {
            char[] separators = new char[] { ' ', '.', ',' };
            string[] ArrayStringSplit = inputString.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return ArrayStringSplit;
        }

        static void ReversWord(string inputPhrase)
        {
            string[] ArrayString = GetStringSplit(inputPhrase);
            string ResultString="";

            Console.WriteLine("\nРезультат:");

            //Array.Reverse(ArrayString);
            for (int i = 0; i < ArrayString.Length / 2; i++) //перестановка слов в предложении
            {
                string temp = ArrayString[i];
                ArrayString[i] = ArrayString[ArrayString.Length - i - 1];
                ArrayString[ArrayString.Length - i - 1] = temp;
            }

            for(int i =0; i< ArrayString.Length; i++) // вывод нового сообщения
            {
                ResultString += ArrayString[i] + " ";
            }
            Console.WriteLine($">>> {ResultString}");

        }

        static void Main(string[] args)
        {
            Console.Write("Предложение: ");
            string UserString = Console.ReadLine();
            ReversWord(UserString);

            Console.ReadLine();
        }
    }
}
