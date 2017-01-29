using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        public List<Cup> cups = new List<Cup>();
        public List<Lemon> lemons = new List<Lemon>();
        public List<SugarCube> sugarCubes = new List<SugarCube>();
        public List<IceCube> iceCubes = new List<IceCube>();


        public void InventoryReport()
        {
            Console.WriteLine("Ice cubes on hand are\t\t[" + (iceCubes.Count) + "]" + "\nLemons on hand are\t\t[" + (lemons.Count) + "]" + "\nPaper cups on hand are\t\t[" + (cups.Count) + "]" + "\nCups of Sugar on hand are\t[" + (sugarCubes.Count) + "]");
        }
        public void AddCups(double amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
    }
}
