using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cheers
{
    class Cheers
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            Console.WriteLine("What's your birthday? MM/DD");
            string birthday = System.Console.ReadLine();
            ValidateDate(birthday);
            foreach(char letter in name)
            {
                Output(letter);
                string input = System.Console.ReadLine();
                char givenLetter = input[0];
                if (System.Char.ToUpper(givenLetter) != System.Char.ToUpper(letter) || input == "")
                {
                    System.Console.WriteLine("Let's try that again");
                    Output(letter);
                    input = System.Console.ReadLine();
                    givenLetter = input[0];
                }
            }
            System.Console.WriteLine(Capitalize(name) + " is the best!!!!");
            calculateDays(date);
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }

        static void ValidateDate(string birthday)
        {
            Regex rgx = new Regex("^(0?[1-9]|1[0-2])/(0?[1-9]|[12][0-9]|3[01])$");
            if (rgx.IsMatch(birthday))
            {
                date = Convert.ToDateTime(birthday);
            }
            else
            {
                Console.WriteLine("Your date format was incorrect. Enter your birthday again: (MM/DD)");
                string newBirthday = Console.ReadLine();
                ValidateDate(newBirthday);
            }
            
        }

        static void calculateDays(DateTime birthday)
        {
            DateTime currentDate = DateTime.Today;
            DateTime next = new DateTime(currentDate.Year, birthday.Month, birthday.Day);

            if (next < currentDate)
            {
                next = next.AddYears(1);
            }

            if (next == currentDate)
            {
                Console.WriteLine("Today is your birthday!! HAPPY BIRTHDAY!!!");
            }
            else
            {
                Console.WriteLine("Your birthday is in " + (next - currentDate).Days + " days!!!! Happy Birthday in advance!");
            }

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

        static DateTime date;
    }
}
