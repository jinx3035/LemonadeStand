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
        Recipe recipe;
        public string SetPlayerName()
        {
            Console.WriteLine("Please enter your name so the IRS knows who to tax for this operation.");
            name = Console.ReadLine();
            return name;
        }
        public string GreetPlayer()
        {
            Console.WriteLine("");
            Console.WriteLine("Hello " +name+ ". Good luck in this new endeavor. Lets begin.");
            name = Console.ReadLine();
            return name;
        }
        public void SetRecipe()
        {
            Recipe recipe = new Recipe();
            recipe.MakeRecipe();
        }
    }
}
