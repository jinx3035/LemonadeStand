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
        public int ProbabilityOfRain;
        public int numberOfCustomers;
        //public void CreateDay()
        //{

        //}

        public void CreateWeather()
        {
            //Console.ForegroundColor = ConsoleColor.Blue;

            Random rand = new Random();
            temperature = rand.Next(60, 100);

            if (temperature <= 75)
            {
                ChanceofRain();
                Console.WriteLine("Today's forecast is a high of " + temperature + " degrees outside and " + percipitation);
                //PotentialCustomers();
                Console.ReadLine();
            }
            else if (temperature > 75 && temperature < 90)
            {
                ChanceofRain();
                Console.WriteLine("Today's forecast is a high of " + temperature + " degrees outside and " + percipitation);
                //PotentialCustomers();
                Console.ReadLine();
            }
            else
            {
                ChanceofRain();
                Console.WriteLine("Today's forecast is a high of " + temperature + " degrees outside and " + percipitation);
                //PotentialCustomers();
                Console.ReadLine();
            }
        }
        public void ChanceofRain()
        {
            Random rand = new Random();
            int forecast = rand.Next(1, 6);

            switch (forecast)
            {
                case 1:
                    ProbabilityOfRain = rand.Next(40, 80);
                    percipitation = "cloudy and miserable with a " + ProbabilityOfRain + "% chance of rain...";
                    if (temperature >= 50 && temperature <= 70)
                    {
                        numberOfCustomers = rand.Next(40, 80);
                    }
                    break;
                case 2:
                    ProbabilityOfRain = rand.Next(0, 2);
                    percipitation = "absolutely beautiful outside with " + ProbabilityOfRain + "% chance of rain...";
                    break;
                case 3:
                    ProbabilityOfRain = rand.Next(15, 25);
                    percipitation = "slightly overcast with a " + ProbabilityOfRain + "% chance of rain...";
                    break;
                case 4:
                    ProbabilityOfRain = rand.Next(1, 30);
                    percipitation = "breezy with a " + ProbabilityOfRain + "% chance of rain...";
                    break;
                case 5:
                    ProbabilityOfRain = rand.Next(20, 50);
                    percipitation = "hazy with a " + ProbabilityOfRain + "% chance of rain...";
                    break;
            }
        }
    }
}
