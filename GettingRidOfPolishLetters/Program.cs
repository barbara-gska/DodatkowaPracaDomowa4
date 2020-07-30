using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GettingRidOfPolishLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Twoja szansa na pozbycie się udziwnionych polskich liter z danego wyrażenia");
            
            do
            {
                Console.WriteLine("Wpisz tekst, który chcesz zmienić: ");
                var phrase = Console.ReadLine();

                Console.WriteLine("Poprawiony tekst to: ");
                Console.WriteLine(ReplacingPolishLetters.MakeItNormal(phrase));

                Console.WriteLine("Kolejny tekst do zmiany [t/n]?");
                var gameOn = Console.ReadLine().ToLower();
                if (gameOn == "t")
                    continue;
                else if (gameOn == "n")
                {
                    Console.WriteLine("Zakończono żmudną pracę polegającą na zamianie liter polskich na normalne.");
                    Console.WriteLine("See you again next time");
                    break;
                }
                else
                {
                    Console.WriteLine("Nie wiem co chciałbys zrobić. W związku z tym kończę pracę.");
                    break;
                }

            } while (true);



            Console.ReadLine();
        }
    }
}
