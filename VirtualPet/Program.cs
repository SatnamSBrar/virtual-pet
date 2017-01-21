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

            while (true)
            {
                //displays pet status
                Console.WriteLine("\nHunger:      " + vPet.Hunger);
                Console.WriteLine("Thirst:      " + vPet.Thirst);
                Console.WriteLine("Potty        " + vPet.Potty);
                Console.WriteLine("Energy:      " + vPet.Energy);
                Console.WriteLine("Sleepiness:  " + vPet.Tired);
                Console.WriteLine("Health:      " + vPet.Health);

                //prompts user for action
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("Enter a number 1-8");
                Console.WriteLine("\t1 - Feed");
                Console.WriteLine("\t2 - Give water");
                Console.WriteLine("\t3 - Take outside to potty");
                Console.WriteLine("\t4 - Play");
                Console.WriteLine("\t5 - Tuck into bed");
                Console.WriteLine("\t6 - Take to vet");
                Console.WriteLine("\t7 - Quit");
                Console.WriteLine("\t8 - Restart\n\n\n\n");

                //stores user input
                int input = int.Parse(Console.ReadLine());

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
                            Console.WriteLine("Please enter a valid number");
                            break;
                    }
                }
                //ALERTS

                //alerts if pet is fed too much
                if (vPet.Hunger < 0 && vPet.Hunger >= -10)
                {
                    Console.WriteLine("            ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet does not need any more food!   *****************");
                }
                else if (vPet.Hunger < -10 && vPet.Hunger >= -15)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs a doctor!   *****************");

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
                    Console.WriteLine("*****************   Your pet needs a doctor!   *****************");
                }
                else if (vPet.Health < -15)
                {
                    break;
                }

                //alerts user pet needs to potty
                if (vPet.Potty > 15 && vPet.Potty <= 20)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs to potty!   *****************");
                }
                else if (vPet.Potty > 20)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*********   Your pet has eaten its poop and is now sick!   *********");
                    Random num = new Random();  //pet becomes sick if it eats poop
                    int sickUpdate = num.Next(5, 9);
                    vPet.Health -= sickUpdate;
                }

                //alerts user if pet is too tired
                if (vPet.Tired > 15 && vPet.Tired <= 25)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet is getting tired!   *****************");
                }
                else if (vPet.Tired > 25)
                {
                    Console.WriteLine("       ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet has fallen asleep!   *****************");
                    Random num = new Random();  //pet falls asleep if too tired
                    int tiredUpdate = num.Next(10, 20);
                    vPet.Tired -= tiredUpdate;
                }

                //alerts user if pet has too much energy
                if (vPet.Energy > 20 && vPet.Energy <= 30)
                {
                    Console.WriteLine("      ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs to play!   *****************");
                }
                else if (vPet.Energy > 30)
                {
                    Console.WriteLine("     ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet hurt itself!   *****************");
                    Random num = new Random();  //pet gets hurt if it runs around too much
                    int sickUpdate = num.Next(4);
                    vPet.Health -= sickUpdate;
                }

                //alerts if pet needs to be fed
                if (vPet.Hunger > 20 && vPet.Hunger <=30)
                {
                    Console.WriteLine("      ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs to eat!   *****************");
                }
                else if (vPet.Hunger > 30)
                {
                    Console.WriteLine("    ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet is sick!   *****************");
                    Random num = new Random();  //pet gets sick if it doesn't eat
                    int sickUpdate = num.Next(5, 11);
                    vPet.Health -= sickUpdate;
                }

                //alerts if pet needs water
                if (vPet.Hunger > 20 && vPet.Hunger <= 30)
                {
                    Console.WriteLine("      ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet needs water!   *****************");
                }
                else if (vPet.Hunger > 30)
                {
                    Console.WriteLine("    ********************   ALERT!   ********************");
                    Console.WriteLine("*****************   Your pet is sick!   *****************");
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
                    break;
                case (1):
                    Console.WriteLine("\nYou need to be more responsble.\n");
                    break;
                case (2):
                    Console.WriteLine("\nYour poor virtual pet :(\n");
                    break;
                case (3):
                    Console.WriteLine("\nGame Over.\n");
                    break;
                case (4):
                    Console.WriteLine("\nYour virtual pet as died as a consequence of your ineptitude.\n");
                    break;
            }
            
        }
    }
}
