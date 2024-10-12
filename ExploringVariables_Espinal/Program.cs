using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploringVariables_Espinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string heroFirstName = "Mariana";
            string heroLastName = "Espinal";
            string heroFullName = heroFirstName + " " + heroLastName;
            string villianTitle = "Overlord of Evil";
            string minionTitle = "Just a Little Guy";
            string villianName = "Goomba";
            string minion1Name = "Bowser";
            string minion2Name = "Metropoles";

            int heroHealth = 100
            int heroStrength = 50
            int bossHealth = 100
            int bossStrength = 25
            int minion1Health = 50
            int minion2Health = 50
            int minionStrength = 5


            Console.WriteLine("The fighters enter the room!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);


            Console.WriteLine("Behold the legendary hero of programming" +
                " whose name is: " + heroFullName " " !");
            Console.WriteLine(heroFullName + "'s" + "Archrival is" +  villianName + "the" + villianTitle);
            Console.WriteLine(villianName + "the" + villianTitle + "is helped out by" + minionTitle + minion1Name
                "and" +  minionTitle + minion2Name);

            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
           
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
           
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStrength + " damage!");
           
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");

      
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

   
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats an apple to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
        
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");
           
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
         
            Console.WriteLine(heroFullName + " attacks " + villianName + " the " + villianTitle + " for " + heroStrength + " damage!");
           
            bossHealth = bossHealth - heroStrength;
        
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health!");

            //Results
            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and cake to the winner!");

        }
    }
}
