using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public void BuyItems(double money, Inventory ingredient)
        {
            int buy = int.Parse(BuyItemMenu());
           
            switch (buy)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("How many cups would you like to buy?");
                    int buyCups = Convert.ToInt16(Console.ReadLine());
                    ingredient.AddCups(buyCups);
                    if (money >= buyCups * .40)
                    {
                        money = Math.Round((money - (buyCups * .40)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your supply cart", buyCups, ingredient);
                        Console.WriteLine("You have ${0} in cash.", money);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(money, ingredient);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        BuyItems(money, ingredient);
                    }
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("How many lemons would you like to buy?");
                    int buyLemons = Convert.ToInt16(Console.ReadLine());
                    if (money >= (buyLemons * .30))
                    {
                        money = Math.Round((money - (buyLemons * .30)), 2);
                        Console.WriteLine("");
                        //Console.WriteLine("You just purchased {0} lemons and have {1} in your inventory", buyLemons, lemons);
                        Console.WriteLine("You have ${0} in cash.", money);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(money, ingredient);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        BuyItems(money, ingredient);
                    }
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("How many cups of water would you like to buy?");
                    int buySugarCubes = Convert.ToInt16(Console.ReadLine());
                    if (money >= (buySugarCubes * .15))
                    {
                        money = Math.Round((money - (buySugarCubes * .15)), 2);
                        Console.WriteLine("");
                        //Console.WriteLine("You just purchased {0} sugar cubes and have {1} in your inventory", buySugarCubes, sugarCubes);
                        Console.WriteLine("You have ${0} in cash.", money);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            BuyItems(money, ingredient);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        BuyItems(money, ingredient);
                    }
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("How many cups of water would you like to buy?");
                    int buyIceCubes = Convert.ToInt16(Console.ReadLine());
                    if (money >= (buyIceCubes * .10))
                    {
                        money = Math.Round((money - (buyIceCubes * .10)), 2);
                        Console.WriteLine("");
                        //Console.WriteLine("You just purchased {0} sugar cubes and have {1} in your inventory", buyIceCubes, iceCubes);
                        Console.WriteLine("You have ${0} in cash.", money);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {

                            BuyItems(money, ingredient);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        BuyItems(money, ingredient);
                    }
                    Console.WriteLine("");
                    break;
            }
            Console.ReadKey();
        }

         
        private string BuyItemMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("WELCOME TO THE STORE");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Let's buy some supplies...");
            Console.WriteLine("");
            Console.WriteLine("You have ${0} in cash.");//,money);
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
