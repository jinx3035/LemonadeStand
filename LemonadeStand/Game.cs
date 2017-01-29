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
        Day weather;
        Inventory supply;
        Store goShopping;

        private double money;


        public void StartGame()
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome young aspiring entrepreneur! \n\nCongratulations on choosing a lemonade stand to gain your riches. ");
            Console.WriteLine("Pay attention now. There are decisions to be made that will decide your success or failure.\n");
            Console.WriteLine("You must aquire supplies consisting of cups, lemons, sugars, and ice, then set a recipe.");
            Console.WriteLine("I have provided you my last $20 to help you establish an inventory so don't let me down.\n");
            Console.WriteLine("Pay attention to the weather because it will directly affect how many customers come out to buy your product.");
            Console.WriteLine("So adjust your price accordingly and pay attention to your inventory as some of it has experation dates. \n");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            player = new Player();
            player.SetPlayerName();
            player.GreetPlayer();
        }

        public void CurrentSituation()
        {
            Console.WriteLine("This is your current inventory along with todays weather forcast.\n");
            weather = new Day();
            weather.CreateWeather();
            supply = new Inventory();
            supply.InventoryReport();
            Console.WriteLine("");

        }

        
        //"Now create a switch to decide between ordering suplies and running the day."
        public void BuyOrPlay()
        {
            string decision = player.AskDecision();
            switch (decision)
            {
                case "1":
                    Store goShopping = new Store();
                    goShopping.BuyItems(money);


                    break;
                case "2":
                    Console.WriteLine("set price");
                    Console.ReadLine();

                    break;
                case "3":
                    Console.WriteLine("Go to work");
                    Console.ReadLine();

                    break;
                default: Console.WriteLine("");
                    Console.ReadLine();
                    break;
            }              
        } 
    }
}
