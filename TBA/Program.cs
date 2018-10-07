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
            int Arraycount = 0;


            //Strings
            string gender;
            string Race;
            string Class;
            string[] Inventory = new string[20];
            string Input;


            //Character Creation
            do
            {
                Console.WriteLine("Choose a gender:");
                Console.WriteLine("Male / Female");
                gender = Console.ReadLine().ToLower();
                if (gender == "male")
                {
                    correct = 1;
                }
                if (gender == "female")
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
                Console.WriteLine("One Handed: +1");
                Console.WriteLine("Two Handed: +1");
                Console.WriteLine("Ranged: +1");
                Console.WriteLine("Magic: +1");
                Console.WriteLine("");
                Console.WriteLine("Dwarf");
                Console.WriteLine("One Handed: +2");
                Console.WriteLine("Two Handed: +2");
                Console.WriteLine("Ranged: +1");
                Console.WriteLine("");
                Console.WriteLine("Elf");
                Console.WriteLine("Magic: +2");
                Console.WriteLine("Ranged: +2");
                Console.WriteLine("");
                Console.WriteLine("Orc");
                Console.WriteLine("One Handed: +2");
                Console.WriteLine("Two Handed: +2");
                Console.WriteLine("");

                Race = Console.ReadLine().ToLower();

                if (Race == "human")
                {
                    Console.WriteLine("Is this the race you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
                }

                if (Race == "dwarf")
                {
                    Console.WriteLine("Is this the race you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
                }

                if (Race == "elf")
                {
                    Console.WriteLine("Is this the race you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
                }

                if (Race == "orc")
                {
                    Console.WriteLine("Is this the race you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Class Selection
            do
            {
                Console.Clear();
                Console.WriteLine("Choose a Class:");
                Console.WriteLine("");
                Console.WriteLine("Hunter");
                Console.WriteLine("One Handed: +2");
                Console.WriteLine("Ranged: +2");
                Console.WriteLine("");
                Console.WriteLine("Mage");
                Console.WriteLine("One Handed: +2");
                Console.WriteLine("Magic: +2");
                Console.WriteLine("");
                Console.WriteLine("Fighter");
                Console.WriteLine("One Handed: +2");
                Console.WriteLine("Two Handed: +2");
                Console.WriteLine("");
                Console.WriteLine("Rogue");
                Console.WriteLine("One Handed: +2");
                Console.WriteLine("Ranged: +2");
                Console.WriteLine("");
                Console.WriteLine("Paladin");
                Console.WriteLine("Two Handed: +2");
                Console.WriteLine("Magic: +2");
                Class = Console.ReadLine().ToLower();
                if (Class == "hunter")
                {
                    Console.WriteLine("Is this the class you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
                }

                if (Class == "rogue")
                {
                    Console.WriteLine("Is this the class you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
                }

                if (Class == "fighter")
                {
                    Console.WriteLine("Is this the class you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
                }

                if (Class == "mage")
                {
                    Console.WriteLine("Is this the class you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
                }

                if (Class == "paladin")
                {
                    Console.WriteLine("Is this the class you wish to play?");
                    Input = Console.ReadLine().ToLower();
                    if (Input == "yes")
                    {
                        correct = 1;
                    }
                    if (Input == "no")
                    {
                        correct = 0;
                    }
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

            Console.Clear();
            Console.WriteLine("Stats:");
            Console.WriteLine("One Handed:" + " " + One_Handed.ToString());
            Console.WriteLine("Two Handed:" + " " + Two_Handed.ToString());
            Console.WriteLine("Ranged:" + " " + Ranged.ToString());
            Console.WriteLine("Magic:" + " " + Magic.ToString());



            Console.WriteLine("Inventory Test: Inventory Below");
            Input = Console.ReadLine().ToUpper();
            //Inventory System:
            if (Input == "INVENTORY")
            {
                Console.Clear();
                Console.WriteLine("Your Inventory Contains:");
                for (Arraycount = 0; Arraycount < 20; Arraycount++)
                {
                    Console.SetCursorPosition(0, Arraycount);
                    Console.WriteLine("{0}", Inventory[Arraycount]);
                }
            }
            else { }
            Console.ReadLine ();
        }
    }
}
