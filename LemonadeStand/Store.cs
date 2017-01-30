using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        decimal cupPrice = .40m;
        decimal lemonPrice = .30m;
        decimal sugarCubePrice = .15m;
        decimal iceCubePrice = .10m;
        public void BuyItems(Player player, Inventory ingredient)
        {
            int buy = int.Parse(BuyItemMenu(player));
           
            switch (buy)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("How many cups would you like to buy?");
                    decimal buyCups = Convert.ToDecimal(Console.ReadLine());
                    ingredient.AddCups(buyCups);
                    decimal cupCost = Decimal.Multiply(buyCups, cupPrice);
                    if (player.money.CheckBalance(cupCost) == true) 
                    {
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (cupCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your supply cart", buyCups, ingredient);
                        Console.WriteLine("You have ${0} in cash.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(player, ingredient);
                        }
                        else
                        {
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        BuyItems(player, ingredient);
                    }
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("How many lemons would you like to buy?");
                    decimal buyLemons = Convert.ToDecimal(Console.ReadLine());
                    ingredient.AddLemons(buyLemons);
                    decimal lemonCost = Decimal.Multiply(buyLemons, lemonPrice);
                    if (player.money.CheckBalance(lemonCost) == true)
                    {
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (lemonCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} lemons and have {1} in your inventory", buyLemons, ingredient);
                        Console.WriteLine("You have ${0} in cash.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(player, ingredient);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        BuyItems(player, ingredient);
                    }
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("How many sugar cubes would you like to buy?");
                    decimal buySugarCubes = Convert.ToDecimal(Console.ReadLine());
                    ingredient.AddCups(buySugarCubes);
                    decimal sugarCubeCost = Decimal.Multiply(buySugarCubes, sugarCubePrice);
                    if (player.money.CheckBalance(sugarCubeCost) == true)
                    {
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (sugarCubeCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} sugar cubes and have {1} in your inventory", buySugarCubes, ingredient);
                        Console.WriteLine("You have ${0} in cash.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(player, ingredient);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        BuyItems(player, ingredient);
                    }
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("How many cups of water would you like to buy?");
                    decimal buyIceCubes = Convert.ToDecimal(Console.ReadLine());
                    ingredient.AddIceCubes(buyIceCubes);
                    decimal iceCubeCost = Decimal.Multiply(buyIceCubes, iceCubePrice);
                    if (player.money.CheckBalance(iceCubeCost) == true)
                    {
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (iceCubeCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} sugar cubes and have {1} in your inventory", buyIceCubes, ingredient);
                        Console.WriteLine("You have ${0} in cash.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {

                            BuyItems(player, ingredient);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        BuyItems(player, ingredient);
                    }
                    Console.WriteLine("");
                    break;
            }
            Console.ReadKey();
        }

         
        private string BuyItemMenu(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("WELCOME TO THE STORE");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Let's buy some supplies...");
            Console.WriteLine("");
            Console.WriteLine("You have ${0} in cash.", player.money.WalletBalance);
            Console.WriteLine("");
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1: cups");
            Console.WriteLine("2: lemons");
            Console.WriteLine("3: sugar cubes");
            Console.WriteLine("4: ice cubes");
            string menu = Console.ReadLine();
            return  menu; 
        }
    }
}
