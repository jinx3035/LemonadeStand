using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory//: IUpDate
    {
        //public void UpDate(decimal amount)
        //{
        //    for (int i = 0; i < amount; i++)
        //    {
        //        Ingredients item = new Ingredients();
        //        item.Add();
        //    }
        //}



        // Player player;
        Ingredients name;
        public List<Cup> cups = new List<Cup>();
        public List<Lemon> lemons = new List<Lemon>();
        public List<SugarCube> sugarCubes = new List<SugarCube>();
        public List<IceCube> iceCubes = new List<IceCube>();
        
        public void InventoryReport()
        {
            Console.WriteLine("Ice cubes on hand are\t\t[" + (iceCubes.Count) + "]" + "\nLemons on hand are\t\t[" + (lemons.Count) + "]" + "\nPaper cups on hand are\t\t[" + (cups.Count) + "]" + "\nCups of Sugar on hand are\t[" + (sugarCubes.Count) + "]");
        }

        public void AddCups(decimal buyCups)
        {
            for (int i = 0; i < buyCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
        //public void RemoveCups(decimal soldCups)
        //{
        //    for (int i = 0; i < soldCups; i++)
        //    { 
        //        cups.RemoveAt(0);
        //    }
        //}

        public void AddLemons(decimal buyLemons)
        {
            for (int i = 0; i < buyLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubes(decimal buySugarCubes)
        {
            for (int i = 0; i < buySugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }
        public void AddIceCubes(decimal buyIceCubes)
        {
            for (int i = 0; i < buyIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }
    }
}
