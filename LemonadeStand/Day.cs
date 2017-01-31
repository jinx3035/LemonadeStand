using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {

        public string percipitation;
        public int temperature;
        public List<Customer> dailyCustomers = new List<Customer>();
        public void CreateDay()
        {
            CreateWeather();
            ChanceOfRain();
            DisplayForcast();
            Customer population = new Customer();
            population.CustomerPopulation();
            population.CustomerType();
            population.DetermineBuyPercentage();
            population.BuyProbability(dailyCustomers);
        }

        public void CreateWeather()
        {
            //Console.ForegroundColor = ConsoleColor.Blue;

            Random rand = new Random();
            temperature = rand.Next(5, 105);
            if (temperature <= 25)
            {
                DisplayForcast();
            }
                if (temperature >= 26 && temperature <= 50)
            {
                DisplayForcast();
            }
            else if (temperature > 51 && temperature < 75)
            {
                DisplayForcast();
            }
            else
            {
                DisplayForcast();
            }
        }

        public void ChanceOfRain()
        {
            Random rand = new Random();
            int rain = rand.Next(5, 95);
            percipitation = "with a " + rain + "% chance of rain...";
        }

        public void DisplayForcast()
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
