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

                //alerts if pet is fed too much
                if (vPet.Hunger < 0 && vPet.Hunger >= -10)
                {
                    Console.WriteLine("ALERT!\nYour pet does not need any more food!");
                }
                else if (vPet.Hunger < -10 && vPet.Hunger >= -15)
                {
                    Console.WriteLine("ALERT!\nYour pet needs a doctor!");

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
                    Console.WriteLine("ALERT!\nYour bet needs a doctor!");
                }
                else if (vPet.Health < -15)
                {
                    break;
                }
            }
            //message to be displayed if user quits program
            Console.WriteLine("You have lost your virtual pet.\n");
        }
    }
}
