using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        private static void buyItems(int cups, int lemons, int sugarCubes, int iceCubes, double money, int demand)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("WELCOME TO THE STORE");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Let's buy some supplies...");
            Console.WriteLine("");
            Console.WriteLine("You have ${0} in petty cash.", money);
            Console.WriteLine("");
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1: cups");
            Console.WriteLine("2: lemons");
            Console.WriteLine("3: sugar cubes");
            Console.WriteLine("4: ice cubes");

            int buy = Convert.ToInt16(Console.ReadLine());
            switch (buy)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("How many paper cups would you like to buy?");
                    int buyCups = Convert.ToInt16(Console.ReadLine());
                    if (money >= buyCups * .40)
                    {
                        money = Math.Round((money - (buyCups * .40)), 2);
                        cups = cups + buyCups;
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your supply cart", buyCups, cups);
                        Console.WriteLine("You have ${0} in cash.", money);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            buyItems(cups, lemons, sugarCubes, iceCubes, money, demand);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        buyItems(cups, lemons, sugarCubes, iceCubes, money, demand);
                    }
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("How many lemons would you like to buy?");
                    int buylemons = Convert.ToInt16(Console.ReadLine());
                    if (money >= (buylemons * .30))
                    {
                        money = Math.Round((money - (buylemons * .30)), 2);
                        lemons = lemons + buylemons;
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} Lemons and have {1} in your inventory", buylemons, lemons);
                        Console.WriteLine("You have ${0} in cash.", money);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            buyItems(cups, lemons, sugarCubes, iceCubes, money, demand);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        buyItems(cups, lemons, sugarCubes, iceCubes, money, demand);
                    }
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("How many cups of water would you like to buy?");
                    int buysugarCubes = Convert.ToInt16(Console.ReadLine());
                    if (money >= (buysugarCubes * .15))
                    {
                        money = Math.Round((money - (buysugarCubes * .15)), 2);
                        sugar = sugar + buysugarCubes;
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} sugar cubes and have {1} in your inventory", buysugarCubes, sugarCubes);
                        Console.WriteLine("You have ${0} in cash.", money);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {
                            buyItems(cups, lemons, sugarCubes, iceCubes, money, demand);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy that.");
                        Console.ReadKey();
                        buyItems(cups, lemons, sugarCubes, iceCubes, money, demand);
                    }
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("How many cups of water would you like to buy?");
                    int buyiceCubes = Convert.ToInt16(Console.ReadLine());
                    if (money >= (buyiceCubes * .10))
                    {
                        money = Math.Round((money - (buyiceCubes * .10)), 2);
                        ice = ice + buyiceCubes;
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} sugar cubes and have {1} in your inventory", buyiceCubes, iceCubes);
                        Console.WriteLine("You have ${0} in cash.", money);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to buy anything else?");

                        string buyMore = Console.ReadLine();
                        if (buyMore == "yes")
                        {

                            buyItems(cups, lemons, sugarCubes, iceCubes, money, demand);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you do not have enough money to buy all those items together.");
                        Console.ReadKey();
                        buyItems(cups, lemons, sugarCubes, iceCubes, money, demand);
                    }
                    Console.WriteLine("");
                    break;
            }
            Console.ReadKey();
        }
    }
}
