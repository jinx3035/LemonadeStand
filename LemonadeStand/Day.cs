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
        public int probabilityOfRain;
        public int numberOfCustomers;
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
        public void ChanceofRain()
        {
            Random rand = new Random();
            int forecast = rand.Next(1, 6);

            switch (forecast)
            {
                case 1:
                    probabilityOfRain = rand.Next(40, 80);
                    percipitation = "cloudy and miserable with a " + probabilityOfRain + "% chance of rain...";
                    if (temperature >= 50 && temperature <= 70)
                    {
                        numberOfCustomers = rand.Next(40, 80);
                    }
                    break;
                case 2:
                    probabilityOfRain = rand.Next(0, 2);
                    percipitation = "absolutely beautiful outside with " + probabilityOfRain + "% chance of rain...";
                    break;
                case 3:
                    probabilityOfRain = rand.Next(15, 25);
                    percipitation = "slightly overcast with a " + probabilityOfRain + "% chance of rain...";
                    break;
                case 4:
                    probabilityOfRain = rand.Next(1, 30);
                    percipitation = "breezy with a " + probabilityOfRain + "% chance of rain...";
                    break;
                case 5:
                    probabilityOfRain = rand.Next(20, 50);
                    percipitation = "hazy with a " + probabilityOfRain + "% chance of rain...";
                    break;
            }
        }
        public void DisplayForcast()
        {
            ChanceofRain();
            Console.WriteLine("Today's forecast is a high of " + temperature + " degrees outside and " + percipitation);
            //PotentialCustomers();
            Console.ReadLine();
        }
    }
}
