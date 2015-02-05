/*
 * Author's Name: Chenyu Zhao
 * Date: 29 Jan
 * A Hero Class that has random properties and may cause damage 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Popeye");
            hero.show();
            hero.fight();

            SuperHero superHero = new SuperHero("Ironman");
            superHero.showPowers();
            superHero.fight();
        }
    }
}
