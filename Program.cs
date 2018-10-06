using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ints
            int correct = 0;

            //Strings
            string gender;
            string Race;
            //Character Creation
            do
            {
                Console.WriteLine("Choose a gender:");
                Console.WriteLine("Male / Female");
                gender = Console.ReadLine().ToUpper();
                if (gender == "MALE")
                {
                    correct = 1;
                }
                if (gender == "FEMALE")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Race Creation
            do
            {
                Console.Clear();
                Console.WriteLine("Choose a Race:");
                Console.WriteLine("Human");
                Console.WriteLine("Dwarf");
                Console.WriteLine("Elf");
                Console.WriteLine("Orc");
                Console.WriteLine("Sips Fiend");
                Race = Console.ReadLine().ToUpper();
                if (Race == "Human" || Race == "Dwarf" || Race == "Elf" || Race == "Orc" || Race == "Sips Fiend")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0);
            correct = 0;
        }
    }
}
