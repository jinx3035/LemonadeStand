using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public decimal numberOfCustomers;
        private int type;
        private decimal buyProbability;

        public decimal CustomerPopulation()
        {
            Random rand = new Random();

            decimal temp = 0;
            if (temp >= 30 && temp <= 70)
            {
                numberOfCustomers = rand.Next(126, 200);
            }
            else if (temp > 70 && temp < 90)
            {
                numberOfCustomers = rand.Next(201, 300);
            }
            else
            {
                numberOfCustomers = rand.Next(50, 125);
            }
            return numberOfCustomers;
        }

        public void CustomerType()
        {
            Random rand = new Random();
            type = rand.Next(1, 6);
            switch(type)
            {
                case 1:
                    Random randBuy1 = new Random();
                    buyProbability = rand.Next(80, 100);
                    break;
                case 2:
                    Random randBuy2 = new Random();
                    buyProbability = rand.Next(60, 85);
                    break;
                case 3:
                    Random randBuy3 = new Random();
                    buyProbability = rand.Next(40, 65);
                    break;
                case 4:
                    Random randBuy4 = new Random();
                    buyProbability = rand.Next(20, 45);
                    break;
                case 5:
                    Random randBuy5 = new Random();
                    buyProbability = rand.Next(5, 25);
                    break;
            }
        }

        public void BuyProbability(List<Customer> dailyCustomers)
        {
            if (numberOfCustomers >= 126 && numberOfCustomers <= 200)
            {
                MakeCustomers(dailyCustomers);
            }
            else if (numberOfCustomers >= 201 && numberOfCustomers <= 300)
            {
                MakeCustomers(dailyCustomers);
            }
            else
            {
                MakeCustomers(dailyCustomers);               
            }
        }

        public int DetermineBuyPercentage()
        {
            decimal multipliedResult = numberOfCustomers * (buyProbability / 100);
            decimal roundedResult = Math.Round(multipliedResult, 0);
            int endResult = Decimal.ToInt32(roundedResult);           
            return endResult;
        }
        private void MakeCustomers(List<Customer> dailyCustomers)
        {
            int totalBuyers = DetermineBuyPercentage();
            for (int i = 0; i < totalBuyers; i++)
            {
                Customer customer = new Customer();
                dailyCustomers.Add(customer);
            }
        }

    }
}
