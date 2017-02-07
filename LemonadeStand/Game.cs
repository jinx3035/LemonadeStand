using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Player player;
        Day weather;
        Inventory supply;

        public void StartGame()
        {
            ShowGameMenu();
            player = new Player();
            player.SetPlayerName();
            player.GreetPlayer();
            weather = new Day();
            supply = new Inventory();
            for (int i = 0; i < 7; i++)
            {
                BuyOrPlay();                
            }
        }
                   
        //"Now create a switch to decide between ordering suplies and running the day."
        public void BuyOrPlay()
        {
            string decision = player.AskDecision();
            switch (decision)
            {
                case "1":
                    Store goShopping = new Store();
                    goShopping.BuyItems(player, inventory);
                    BuyOrPlay();

                    break;
                case "2":
                    Console.WriteLine("set lemonade price");
                    Console.ReadLine();

                    break;
                case "3":
                    weather.CurrentSituation(weather, supply);
                    //Run the days calculations

                    break;

                default: Console.WriteLine("The game will be restarted");
                    Console.ReadKey();
                    StartGame();
                    break;
            }              
        }

        public void ShowGameMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Congratulations on choosing a lemonade stand to gain your riches. ");
            Console.WriteLine("Pay attention now. There are decisions to be made that will decide your success or failure.\n");
            Console.WriteLine("You must aquire supplies consisting of cups, lemons, sugars, and ice, then set a recipe.");
            Console.WriteLine("I have provided you my last $20 to help you establish an inventory so don't let me down.\n");
            Console.WriteLine("Pay attention to the weather because it will directly affect how many customers come out to buy your product.");
            Console.WriteLine("So adjust your price accordingly and pay attention to your inventory as some of it may have experation dates. \n");
        }
    }
}
