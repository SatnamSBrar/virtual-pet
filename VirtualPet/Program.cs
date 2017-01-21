using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object
            Roscoe vPet = new Roscoe();

            //sets initial values for pet status
            vPet.Hunger = 0;
            vPet.Thirst = 0;
            vPet.Potty = 0;
            vPet.Energy = 20;
            vPet.Tired = 0;
            vPet.Health = 0;

            //sets bool for window maximize prompt
            bool first = true;

            do
            {
                //asks user to maximize console window for optimal experience the first time program is used
                Console.WriteLine("\n\n\n\n   >>>>>>>>>>   PLEASE MAXIMIZE WINDOW FOR OPTIMAL EXPERIENCE   <<<<<<<<<<\n\n\n");

                //asks user to press enter to begin game
                Console.WriteLine("     Welcome to Virtual Pet!\n");
                Console.WriteLine(@"     I hope you enjoy taking care of Roscoe as much as I do :)");
                Console.WriteLine("\n\n\n     Press ENTER to continue\n");

                Console.WriteLine("\n\n\n\n   >>>>>>>>>>   PLEASE MAXIMIZE WINDOW FOR OPTIMAL EXPERIENCE   <<<<<<<<<<\n\n\n");

                Console.ReadKey();

                first = false;

            } while (first == true);


            while (true)
            {
                //displays pet status
                Console.WriteLine("Roscoe's Health:");
                Console.WriteLine("Hunger:      " + vPet.Hunger);
                Console.WriteLine("Thirst:      " + vPet.Thirst);
                Console.WriteLine("Potty        " + vPet.Potty);
                Console.WriteLine("Energy:      " + vPet.Energy);
                Console.WriteLine("Sleepiness:  " + vPet.Tired);
                Console.WriteLine("Health:      " + vPet.Health);

                //prompts user for action
                Console.Write("\nWhat would you like to do?");
                Console.WriteLine("\tEnter a number 1-8");
                Console.WriteLine("\t\t\t\t1 - Feed");
                Console.WriteLine("\t\t\t\t2 - Give water");
                Console.WriteLine("\t\t\t\t3 - Take outside to potty");
                Console.WriteLine("\t\t\t\t4 - Play");
                Console.WriteLine("\t\t\t\t5 - Tuck into bed");
                Console.WriteLine("\t\t\t\t6 - Take to vet");
                Console.WriteLine("\t\t\t\t7 - Quit");
                Console.WriteLine("\t\t\t\t8 - Restart");

                //random image to be displayed 
                Random pic = new Random();
                int image = pic.Next(4);

                switch (image)
                {
                    case (0):
                        Console.WriteLine("    ___");
                        Console.WriteLine(" __/_  `.  .-\"\"\" -.");
                        Console.WriteLine(@" \_,` | \-'  /   )`-')");
                        Console.WriteLine("  \"\") `\"`    \\  ((`\"`");
                        Console.WriteLine(" ___Y  ,    .'7 /|");
                        Console.Write("(_,___/...-` (_/_/\t\t\t\t\t\t");
                        break;
                    case (1):
                        Console.WriteLine("    _____^_");
                        Console.WriteLine(@"   |    |    \");
                        Console.WriteLine(@"    \   /  ^ |");
                        Console.WriteLine(@"   / \_/   0  \");
                        Console.WriteLine(@"  /    ____     0");
                        Console.Write(" /     /  \\___ _/\t\t\t\t\t\t");
                        break;
                    case (2):
                        Console.WriteLine(@"     |\_/|");
                        Console.WriteLine(@"     | @ @   Woof!");
                        Console.WriteLine(@"     |   <>              _ ");
                        Console.WriteLine(@"     |  _/\------____ ((| |))");
                        Console.WriteLine(@"     |               `--' | ");
                        Console.WriteLine(@" ____|_       ___|   |___.'");
                        Console.Write("/_/_____/____/_______|\t\t\t\t\t\t");
                        break;
                    case (3):
                        Console.WriteLine(@"   __");
                        Console.WriteLine(@"o-''|\_____/)");
                        Console.WriteLine(@" \_/|_)     )");
                        Console.WriteLine(@"    \  __  /");
                        Console.Write("    (_/ (_/\t\t\t\t\t\t");
                        break;
                    case (4):
                        Console.WriteLine("             .--~~,__");
                        Console.WriteLine(":-....,-------`~~'._.'");
                        Console.WriteLine(" `-,,,  ,_      ;'~U'");
                        Console.WriteLine("  _,-' ,'`-__; '--.");
                        Console.Write(" (_/'~~      ''''(;\t\t\t\t\t\t");
                        break;
                }

                //stores user input as string
                string userInput = Console.ReadLine();

                //bypasses error if user presses enter without entering value
                while (userInput == "")
                {
                    Console.WriteLine("Please enter a valid number");
                    string userInput2 = Console.ReadLine();
                    userInput = userInput2;
                }

                //stores user input as integer
                int input = int.Parse(userInput);

                //prevents user from entering values out of range
                while (input < 0 || input > 8)
                {
                    Console.WriteLine("Please enter a valid number");
                    int input2 = int.Parse(Console.ReadLine());
                    input = input2;
                }

                //quit/restart program
                if (input == 7)
                {
                    Console.Clear();
                    break;
                }
                else if (input == 8)
                {
                    Console.Clear();
                    Main(args);
                }
                else
                {
                    switch (input)          //performs specific methods based on user input
                    {
                        case (1):
                            vPet.Feed();    //decreases hunger, increases thirst, increases potty
                            vPet.Tick();    //randomly increases a specific field
                            Console.Clear();
                            break;
                        case (2):
                            vPet.Water();
                            vPet.Tick();    //randomly increases a specific field
                            Console.Clear();
                            break;
                        case (3):
                            vPet.Poop();
                            vPet.Tick();    //randomly increases a specific field
                            Console.Clear();
                            break;
                        case (4):
                            vPet.Play();
                            vPet.Tick();    //randomly increases a specific field
                            Console.Clear();
                            break;
                        case (5):
                            vPet.Sleep();
                            vPet.Tick();    //randomly increases a specific field
                            Console.Clear();
                            break;
                        case (6):
                            vPet.Vet();
                            vPet.Tick();    //randomly increases a specific field
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                }
                //ALERTS

                //alerts if pet is fed too much
                if (vPet.Hunger < 0 && vPet.Hunger >= -10)
                {
                    Console.WriteLine("            ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet does not need any more food!   *****************\n");
                }
                else if (vPet.Hunger < -10 && vPet.Hunger >= -15)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs a doctor!   *****************\n");

                    Random num = new Random();  //pet becomes sick if it is fed too much
                    int sickUpdate = num.Next(1, 3);
                    vPet.Health -= sickUpdate;
                }
                else if (vPet.Hunger < -15)
                {
                    Random num = new Random();  //pet becomes sick if it is fed too much
                    int sickUpdate = num.Next(5, 9);
                    vPet.Health -= sickUpdate;
                }

                //alerts user to take pet to the vet
                if (vPet.Health < 0 && vPet.Health >= -15)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs a doctor!   *****************\n");
                }
                else if (vPet.Health < -15)
                {
                    break;
                }

                //alerts user pet needs to potty
                if (vPet.Potty > 15 && vPet.Potty <= 20)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs to potty!   *****************\n");
                }
                else if (vPet.Potty > 20)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*********   Your pet has eaten its poop and is now sick!   *********\n");
                    Random num = new Random();  //pet becomes sick if it eats poop
                    int sickUpdate = num.Next(5, 9);
                    vPet.Health -= sickUpdate;
                }

                //alerts user if pet is too tired
                if (vPet.Tired > 15 && vPet.Tired <= 25)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet is getting tired!   *****************\n");
                }
                else if (vPet.Tired > 25)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet has fallen asleep!   *****************\n");
                    Random num = new Random();  //pet falls asleep if too tired
                    int tiredUpdate = num.Next(10, 20);
                    vPet.Tired -= tiredUpdate;
                }

                //alerts user if pet has too much energy
                if (vPet.Energy > 20 && vPet.Energy <= 30)
                {
                    Console.WriteLine("      ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs to play!   *****************\n");
                }
                else if (vPet.Energy > 30)
                {
                    Console.WriteLine("     ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet hurt itself!   *****************\n");
                    Random num = new Random();  //pet gets hurt if it runs around too much
                    int sickUpdate = num.Next(4);
                    vPet.Health -= sickUpdate;
                }

                //alerts if pet needs to be fed
                if (vPet.Hunger > 20 && vPet.Hunger <=30)
                {
                    Console.WriteLine("      ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs to eat!   *****************\n");
                }
                else if (vPet.Hunger > 30)
                {
                    Console.WriteLine("    ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet is sick!   *****************\n");
                    Random num = new Random();  //pet gets sick if it doesn't eat
                    int sickUpdate = num.Next(5, 11);
                    vPet.Health -= sickUpdate;
                }

                //alerts if pet needs water
                if (vPet.Hunger > 20 && vPet.Hunger <= 30)
                {
                    Console.WriteLine("      ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs water!   *****************\n");
                }
                else if (vPet.Hunger > 30)
                {
                    Console.WriteLine("    ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet is sick!   *****************\n");
                    Random num = new Random();  //pet gets sick if deprived of water
                    int sickUpdate = num.Next(5, 11);
                    vPet.Health -= sickUpdate;
                }
            }
            //random message to be displayed if user quits program
            Random conclude = new Random();
            int conclusion = conclude.Next(4);

            switch(conclusion)
            {
                case (0):
                    Console.WriteLine("\nYou have lost your virtual pet.\n");
                    Console.WriteLine(@"      _    _");
                    Console.WriteLine(@"     / )__/ )");
                    Console.WriteLine(@"    /      _\ __");
                    Console.WriteLine(@"   (______( |/  \");
                    Console.WriteLine(@"   (/      \|xx--o");
                    Console.WriteLine(@"             vv");
                    Console.WriteLine("\n");
                    break;
                case (1):
                    Console.WriteLine("\nYou need to be more responsble.\n");
                    Console.WriteLine(@"      _    _");
                    Console.WriteLine(@"     / )__/ )");
                    Console.WriteLine(@"    /      _\ __");
                    Console.WriteLine(@"   (______( |/  \");
                    Console.WriteLine(@"   (/      \|xx--o");
                    Console.WriteLine(@"             vv");
                    Console.WriteLine("\n");
                    break;
                case (2):
                    Console.WriteLine("\nYour poor virtual pet :(\n");
                    Console.WriteLine(@"      _    _");
                    Console.WriteLine(@"     / )__/ )");
                    Console.WriteLine(@"    /      _\ __");
                    Console.WriteLine(@"   (______( |/  \");
                    Console.WriteLine(@"   (/      \|xx--o");
                    Console.WriteLine(@"             vv");
                    Console.WriteLine("\n");
                    break;
                case (3):
                    Console.WriteLine("\nGame Over.\n");
                    Console.WriteLine(@"      _    _");
                    Console.WriteLine(@"     / )__/ )");
                    Console.WriteLine(@"    /      _\ __");
                    Console.WriteLine(@"   (______( |/  \");
                    Console.WriteLine(@"   (/      \|xx--o");
                    Console.WriteLine(@"             vv");
                    Console.WriteLine("\n");
                    break;
                case (4):
                    Console.WriteLine("\nYour virtual pet as died as a consequence of your ineptitude.\n");
                    Console.WriteLine(@"      _    _");
                    Console.WriteLine(@"     / )__/ )");
                    Console.WriteLine(@"    /      _\ __");
                    Console.WriteLine(@"   (______( |/  \");
                    Console.WriteLine(@"   (/      \|xx--o");
                    Console.WriteLine(@"             vv");
                    Console.WriteLine("\n");
                    break;
            }
            
        }
    }
}
