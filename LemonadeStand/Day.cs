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
        public List<Customer> customers = new List<Customer>();
        //public void CreateDay()
        //{

        //}

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
        public void DisplayForcast()
        {
            ChanceofRain();
            Console.WriteLine("Today's forecast is a high of " + temperature + " degrees outside " + percipitation);
            //PotentialCustomers();
            Console.ReadLine();
        }
        public void ChanceofRain()
        {
            Random rand = new Random();
            int forecast = rand.Next(1, 6);

            switch (forecast)
            {
                case 1:
                    
                    break;
                case 2:
                    rain = rand.Next(0, 15);
                    percipitation ="with a " + rain + "% chance of rain...";
                    break;
                case 3:
                    rain = rand.Next(15, 45);
                    percipitation = "with a " + rain + "% chance of rain...";
                    break;
                case 4:
                    rain = rand.Next(40, 70);
                    percipitation = "with a " + rain + "% chance of rain...";
                    break;
                case 5:
                    rain = rand.Next(20, 90);
                    percipitation = "with a " + rain + "% chance of rain...";
                    break;
            }
        }

    }
}
