using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class IceCube: Ingredients
    {
        public override void IngredientName()
        {
            Console.WriteLine("ice cube");
        }
    }
}
