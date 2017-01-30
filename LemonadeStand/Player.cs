using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public string choice;
        public Wallet money;
        public Inventory ingredient;

        public Player()
        {
            money = new Wallet();
            ingredient = new Inventory();
        }

        public string SetPlayerName()
        {
            Console.WriteLine("Please enter your name so the IRS knows who to tax for this operation.");
            name = Console.ReadLine();
            return name;
        }
        public string GreetPlayer()
        {
            Console.WriteLine("");
            Console.WriteLine("Hello " +name+ ". Good luck in this new endeavor. Hit enter to begin.");
            name = Console.ReadLine();
            return name;
        }
        public string AskDecision()
        {
            Console.WriteLine("It's time to decide if you want to  order supplies or go to work. \n");
            Console.WriteLine("1 Purchase supplies to stock up for the day.");
            Console.WriteLine("2 Set lemonade price.");
            Console.WriteLine("3 Go to work.");
            choice = Console.ReadLine();

             if (!(choice == "1" || choice == "2" || choice == "3"))
            {
                Console.WriteLine("");
                Console.WriteLine("Please choose 1, 2 or 3");
                Console.ReadKey();
                return AskDecision();
            }
            else
            {
                return choice;
            }

        }
        //public void SetRecipe()
        //{
        //    Recipe recipe = new Recipe();
        //    recipe.MakeRecipe();
        //}
    }
}
