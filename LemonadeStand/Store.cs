using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        decimal cupPrice = .40m;
        decimal lemonPrice = .30m;
        decimal sugarCubePrice = .15m;
        decimal iceCubePrice = .10m;
        //public Inventory ingredient;

        public void BuyItems(Player player, Ingredients name)
        {
            int buy = int.Parse(BuyItemMenu(player));           
            switch (buy)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Cups are $.40 a piece. How many cups would you like to buy?");
                    decimal buyCups = Convert.ToDecimal(Console.ReadLine());
                    ingredient.AddCups(buyCups);
                    decimal cupCost = Decimal.Multiply(buyCups, cupPrice);
                    if (player.money.CheckBalance(cupCost) == true) 
                    {
                        player.money.walletBalance = Math.Round((player.money.walletBalance - (cupCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your supply cart", buyCups, name);
                        Console.WriteLine("You have ${0} in cash.", player.money.walletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(player, name);
                        }
                        else
                        {
                            Console.Clear();
                            player.AskDecision();                                
                        }
                    }
                    else
                    {
                        InsufficientFunds("cups", player, name);
                    }
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Lemons are $.30 a piece. How many lemons would you like to buy?");
                    decimal buyLemons = Convert.ToDecimal(Console.ReadLine());
                    ingredient.AddLemons(buyLemons);
                    decimal lemonCost = Decimal.Multiply(buyLemons, lemonPrice);
                    if (player.money.CheckBalance(lemonCost) == true)
                    {
                        player.money.walletBalance = Math.Round((player.money.walletBalance - (lemonCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} lemons and have {1} in your inventory", buyLemons, name);
                        Console.WriteLine("You have ${0} in cash.", player.money.walletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(player, name);
                        }
                        else
                        {
                            Console.Clear();
                            player.AskDecision();
                        }
                    }
                    else
                    {
                        InsufficientFunds("lemons", player, name);
                    }
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Sugar cubes are $.15 a piece. How many sugar cubes would you like to buy?");
                    decimal buySugarCubes = Convert.ToDecimal(Console.ReadLine());
                    ingredient.AddCups(buySugarCubes);
                    decimal sugarCubeCost = Decimal.Multiply(buySugarCubes, sugarCubePrice);
                    if (player.money.CheckBalance(sugarCubeCost) == true)
                    {
                        player.money.walletBalance = Math.Round((player.money.walletBalance - (sugarCubeCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} sugar cubes and have {1} in your inventory", buySugarCubes, name);
                        Console.WriteLine("You have ${0} in cash.", player.money.walletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(player, name);
                        }
                        else
                        {
                            Console.Clear();
                            player.AskDecision();
                        }
                    }
                    else
                    {
                        InsufficientFunds("sugar cubes", player, name);
                    }
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Ice cubes are $.10 a piece. How many ice cubes would you like to buy?");
                    decimal buyIceCubes = Convert.ToDecimal(Console.ReadLine());
                    ingredient.AddIceCubes(buyIceCubes);
                    decimal iceCubeCost = Decimal.Multiply(buyIceCubes, iceCubePrice);
                    if (player.money.CheckBalance(iceCubeCost) == true)
                    {
                        player.money.walletBalance = Math.Round((player.money.walletBalance - (iceCubeCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} ice cubes and have {1} in your inventory", buyIceCubes, name);
                        Console.WriteLine("You have ${0} in cash.", player.money.walletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(player, name);
                        }
                        else
                        {
                            Console.Clear();
                            player.AskDecision();
                        }
                    }
                    else
                    {
                        InsufficientFunds("ice cubes", player, name);
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
            Console.WriteLine("You have ${0} in cash.", player.money.walletBalance);
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

        private void InsufficientFunds(string item, Player player, Ingredients name)
        {
            Console.WriteLine("Sorry, you do not have enough money to buy that many " + item);
            Console.ReadKey();
            BuyItems(player, name);
        }
    }
}
