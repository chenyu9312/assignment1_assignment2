using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class SuperHero:Hero
    {
        private string[] superPowers;

        //constructor
        public SuperHero(string name):
            base(name)
        {
            this.generateRandomPowers();
        }

        private void generateRandomPowers()
        {
            string[] power={"Super Speed","Super Strength","Body Armour","Flight","Fire Generation","Weather Control"};
            this.superPowers = new string[3];
            int count = 0;
            while (count < superPowers.Length)
            {
                Random rnd = new Random();
                int number = rnd.Next(6);
                if (power[number] != "chosen")
                {
                    
                    superPowers[count] = power[number];
                    power[number] = "chosen";
                    count++;
                }
                
            }
             
        }

        public void showPowers()
        {
            for (int count = 0; count < this.superPowers.Length; count++)
            {
                Console.WriteLine("the hero's superpower is {0}",superPowers[count]);
            }
        }

    

    
    
    }
}
