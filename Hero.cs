﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Hero
    {
        //private property
        private int strength;
        
        private int speed;
        
        private int health;
        


        //public property
        public string name;
       
        //constuctor
        public Hero(string name)
        {
            this.name = name;
            this.generateAbilities();
        }

        private void generateAbilities()
        {
            Random number = new Random();
            this.strength =number.Next(100) + 1;
            this.speed = number.Next(100)+1;
            this.health = number.Next(100)+1; 
        }

        public void fight()
        {
            if (this.hitAttempt())
            {
                int damageRate =this.hitDamage();
                Console.WriteLine("damage done to enemy is {0}",damageRate);


            }
            
            
        }

        private bool hitAttempt()
        {
            Random rnd=new Random();
            int chance=rnd.Next(5)+1;
            if (chance == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int hitDamage()
        {
            Random rnd = new Random();
            int damage = this.strength * (rnd.Next(6) + 1);
            return damage;
        }

        public void show()
        {
            Console.WriteLine("{0}'s health {1}  strength {2}  speed {3}",this.name,this.health ,this.strength ,this.speed );
        }
    }
}
