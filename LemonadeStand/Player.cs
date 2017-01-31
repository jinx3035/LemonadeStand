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
        public void GreetPlayer()
        {
            Console.WriteLine("");
            Console.WriteLine("Hello " +name+ " and good luck running your Lemonade Stand. \n Remember to keep in mind that the weather affects customer turn out so make sure not to order too much.");
            name = Console.ReadLine();
          
        }
        public string AskDecision()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("It's time to decide if you want to  order supplies or go to work. \n");
            Console.WriteLine("1 Purchase supplies to stock up for the day.");
            Console.WriteLine("2 Set lemonade price.");
            Console.WriteLine("3 Go to work.");
            Console.WriteLine("4 Restart");
            choice = Console.ReadLine();

             if (!(choice == "1" || choice == "2" || choice == "3" || choice == "4"))
            {
                Console.WriteLine("");
                Console.WriteLine("Please choose 1, 2, 3 or 4");
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
