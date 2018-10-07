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
            int One_Handed = 0;
            int Two_Handed = 0;
            int Ranged = 0;
            int Magic = 0;


            //Strings
            string gender;
            string Race;
            string Class;

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
                Race = Console.ReadLine().ToLower();
                if (Race == "human" || Race == "dwarf" || Race == "elf" || Race == "orc" || Race == "sips fiend")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Class Selection
            do
            {
                Console.Clear();
                Console.WriteLine("Choose a Class:");
                Console.WriteLine("Hunter");
                Console.WriteLine("Mage");
                Console.WriteLine("Fighter");
                Console.WriteLine("Rogue");
                Console.WriteLine("Paladin");
                Class = Console.ReadLine().ToUpper();
                if (Class == "HUNTER" || Class == "MAGE" || Class == "FIGHTER" || Class == "ROGUE" || Class == "PALADIN" || Class == "SIPS MERCHANT")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Racial Bonuses
            if (Race == "Human")
            {
                One_Handed++;
                Two_Handed++;
                Ranged++;
                Magic++;
            }
            if (Race == "Elf")
            {
                One_Handed++;
                Ranged = Ranged + 2;
                Magic = Magic + 2;
            }

            if (Race == "Dwarf")
            {
                One_Handed++;
                Two_Handed = Two_Handed + 2;
                Ranged++;
            }

            if (Race == "Orc")
            {
                One_Handed = One_Handed + 2;
                Two_Handed = Two_Handed + 2;
            }

            if (Race == "Sips Fiend")
            {
                One_Handed = One_Handed + 2;
                Two_Handed = Two_Handed + 2;
                Ranged = Ranged + 2;
                Magic = Magic + 2;
            }
             
            //Class Bonuses
            if (Class == "Hunter")
            {
                One_Handed = One_Handed + 2;
                Two_Handed++;
                Ranged = Ranged + 2;

            }

            if (Class == "Fighter")
            {
                One_Handed = One_Handed + 2;
                Two_Handed = Two_Handed + 2;
            }

            if (Class == "Paladin")
            {
                Two_Handed = Two_Handed + 2;
                Magic = Magic + 2;
            }

            if (Class == "Mage")
            {
                One_Handed = One_Handed + 2;
                Magic = Magic + 2;
            }

            if (Class == "Rogue")
            {
                One_Handed = One_Handed + 2;
                Ranged = Ranged + 2;
            }

            if (Class == "Sips Merchant")
            {
                One_Handed = One_Handed + 2;
                Two_Handed = Two_Handed + 2;
                Ranged = Ranged + 2;
                Magic = Magic + 2;
            }

        }




w
    }
}
