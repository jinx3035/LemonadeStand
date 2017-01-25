using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Player player;
        public void PlayGame()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome aspiring entrepreneurs! \n\nCongratulations on choosing a lemonade stand to gain your riches. \n");
            Console.WriteLine("Pay attention now. There are decisions to be made that will decide your success or failure.");
            Console.WriteLine("You must aquire supplies consisting of cups, lemons, sugars, and ice, then set a recipe.\n");
            Console.WriteLine("Pay attention to the weather because it will affect the willingness of your customers to buy your product,");
            Console.WriteLine("so adjust your price accordingly. \n\n Press enter to continue.");
            Console.ReadLine();

            player = new Player();
            player.SetPlayerName();
            player.GreetPlayer();
        }
    }
}
