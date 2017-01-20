using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Roscoe
    {
        //fields
        //enumerators converted to integers
        private int hunger;
        private int thirst;
        private int energy;
        private int potty;
        private int tired;
        private int health;

        //properties 
        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }
        public int Thirst
        {
            get { return thirst; }
            set { thirst = value; }
        }
        public int Energy
        {
            get { return energy; }
            set { energy = value; }
        }
        public int Potty
        {
            get { return potty; }
            set { potty = value; }
        }
        public int Tired
        {
            get { return tired; }
            set { tired = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        //methods
        public void Tick()
        {
            //randomly updates fields
            Random num = new Random();

            int n1 = num.Next(3);   //randomly updates hunger by a value of 0, 1, or 2
            hunger += n1;

            int n2 = num.Next(3);   //randomly updates thirst by a value of 0, 1, or 2
            thirst += n2;

            int n3 = num.Next(3);   //randomly updates energy by a value of 0, 1, or 2
            energy += n3;

            int n4 = num.Next(3);   //randomly updates potty by a value of 0, 1, or 2
            potty += n4;

            int n5 = num.Next(3);   //randomly updates tired by a value of 0, 1, or 2
            tired += n5;

            int n6 = num.Next(1);   //randomly updates hunger by a value of 0, or 1
            hunger += n6;
        }
        public void Feed()
        {
            //creates arbitrary random variable
            Random num = new Random();

            //updates hunger by random num ranging from 5-10
            int hungerUpdate = num.Next(5, 11);
            hunger -= hungerUpdate;

            //updates thirst by random num ranging from 1-2
            int thirstUpdate = num.Next(1, 3);
            thirst += thirstUpdate;

            //updates potty by random number ranging from 5-10
            int pottyUpdate = num.Next(5, 11);
            potty += pottyUpdate;

            //updates sleepiness by random num ranging from 1-2
            int tiredUpdate = num.Next(1, 3);
            tired += tiredUpdate;
        }
        public void Water()
        {
            //creates arbitrary random variable
            Random num = new Random();

            //updates thirst by random num ranging from 5-10
            int thirstUpdate = num.Next(5, 11);
            thirst -= thirstUpdate;

            //updates potty by random number ranging from 5-10
            int pottyUpdate = num.Next(5, 11);
            potty += pottyUpdate;

            //updates sleepiness by random num ranging from 1-2
            int tiredUpdate = num.Next(1, 3);
            tired += tiredUpdate;
        }
        public void Poop()
        {
            //creates arbitrary random variable
            Random num = new Random();

            //updates potty by random number ranging from 5-10
            int pottyUpdate = num.Next(5, 11);
            potty -= pottyUpdate;

            //updates energy by random number ranging from 5-10
            int energyUpdate = num.Next(5, 11);
            energy += energyUpdate;

            //updates sleepiness by random num ranging from 1-2
            int tiredUpdate = num.Next(1, 3);
            tired += tiredUpdate;
        }
        public void Play()
        {
            //creates arbitrary random variable
            Random num = new Random();

            //updates potty by random number ranging from 1-2
            int pottyUpdate = num.Next(1, 3);
            potty += pottyUpdate;

            //updates energy by random number ranging from 5-10
            int energyUpdate = num.Next(5, 11);
            energy -= energyUpdate;

            //updates thirst by random num ranging from 1-5
            int thirstUpdate = num.Next(1, 6);
            thirst += thirstUpdate;

            //updates sleepiness by random num ranging from 1-5
            int tiredUpdate = num.Next(1, 6);
            tired += tiredUpdate;
        }
        public void Sleep()
        {
            //resets sleepiness
            tired = 0;
            
            //creates arbitrary random variable
            Random num = new Random();

            //updates energy by random num ranging from 1-10
            if (energy > 10)
            {
                int energyUpdate = num.Next(1, 11);
                energy -= energyUpdate;
            }
            else
            {
                energy = 0;
            }

            //updates potty by random number ranging from 1-2
            int pottyUpdate = num.Next(1, 3);
            potty += pottyUpdate;

            //updates thirst by random num ranging from 1-3
            int thirstUpdate = num.Next(1, 4);
            thirst += thirstUpdate;

            //updates health by random num ranging from 1-2
            int healthUpdate = num.Next(1, 3);
            health += healthUpdate;
        }
        public void Vet()
        {
            hunger = 0;
            thirst = 0;
            energy = 0;
            potty = 0;
            health = 0;
            tired = 10;
        }
    }
}
