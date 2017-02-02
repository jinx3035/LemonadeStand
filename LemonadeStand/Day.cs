using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public int percipitation;
        public int temperature;
        public List<Customer> dailyCustomers = new List<Customer>();

        public void CurrentSituation(Day day, Inventory inventory)
        {
            inventory.InventoryReport();
            Console.WriteLine("");
            CreateDay();
        }

        public void CreateDay()
        {
            CreateWeather();
            ChanceOfRain();
            DisplayForcast(temperature, percipitation);
            Customer population = new Customer();
            population.CustomerPopulation();
            population.CustomerType();
            population.DetermineBuyPercentage();
            population.BuyProbability(dailyCustomers);
        }

        public void CreateWeather()
        {
            Random rand = new Random();
            temperature = rand.Next(15, 105);
            DisplayForcast(temperature, percipitation);           
        }

        public int ChanceOfRain()
        {
            Random rand = new Random();
            int rain = rand.Next(0, 80);
            return rain;
        }

        public void DisplayForcast(int temperature, int percipitation)
        {
            Console.Clear();
            ChanceOfRain();
            Console.WriteLine("Today's forecast is a high of " + temperature + " degrees outside " + percipitation );
            Console.WriteLine("");
            Console.WriteLine("Pay attention to the weather because it will directly affect how many customers come out to buy your product.");
            Console.WriteLine("So adjust your price accordingly and pay attention to your inventory as some of it may have experation dates. \n");
            Console.ReadLine();
        }
    }
}
