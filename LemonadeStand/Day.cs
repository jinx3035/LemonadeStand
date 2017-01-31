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
        public int rain;
        public List<Customer> dailyCustomers = new List<Customer>();
        public void CreateDay()
        {
            CreateWeather();
            ChanceofRain();
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

        public void ChanceofRain()
        {
            Random rand = new Random();
            int rain = rand.Next(5, 95);
            percipitation = "with a " + rain + "% chance of rain...";
        }

        public void DisplayForcast()
        {
            ChanceofRain();
            Console.WriteLine("Today's forecast is a high of " + temperature + " degrees outside " + percipitation);
            //PotentialCustomers();
            Console.ReadLine();
        }


    }
}
