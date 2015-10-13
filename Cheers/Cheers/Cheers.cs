using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Cheers
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            foreach(char letter in name)
            {
                Output(letter);
                string input = System.Console.ReadLine();
                char givenLetter = input[0];
                if (System.Char.ToUpper(givenLetter) != System.Char.ToUpper(letter))
                {
                    System.Console.WriteLine("Let's try that again");
                    Output(letter);
                    input = System.Console.ReadLine();
                    givenLetter = input[0];
                }
            }
            System.Console.WriteLine(Capitalize(name) + " is the best!!!!");
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }

        static string Capitalize(string name)
        {
            return Char.ToUpper(name[0]) + name.Substring(1);
        }

        static bool NeedAn(char letter)
        {
            string AnLetters = "HALFNORSEMIX";
            return AnLetters.IndexOf(letter) != -1;
        }

        static void Output(char c)
        {
            if (NeedAn(c))
            {
                System.Console.WriteLine("Give me an " + System.Char.ToUpper(c));
            }
            else
            {
                System.Console.WriteLine("Give me a " + System.Char.ToUpper(c));
            }
        }
    }
}
