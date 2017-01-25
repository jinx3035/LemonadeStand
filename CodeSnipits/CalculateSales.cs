    public class Stand : IUpdate
    {

        public int days = 0;
        public float cash;
        public string location;
        protected List<Lemon> lemonList = new List<Lemon> { };
        protected List<Sugar> sugarList = new List<Sugar> { };
        protected List<Ice> iceList = new List<Ice>() { };
        protected List<Cups> cupList = new List<Cups> { };


        public void update()
        {
            days += 1;
            
            List<int> lemonListIndex = new List<int> { };
            for (int i = 0; i< lemonList.Count(); i++)
            {
                lemonList[i].subtractDay();
                if (lemonList[i].daysExpire <= 0)
                {
                    lemonListIndex.Add(i);
                }
            }
            foreach (int index in lemonListIndex)
            {
                lemonList.RemoveAt(0);
            }

                foreach (Sugar sugar in sugarList)
                {
                    sugar.subtractDay();
                    if (sugar.daysExpire == 0)
                    {
                        sugarList.Remove(sugar);
                    }
                }

            foreach (Ice ice in iceList)
            {
                ice.subtractDay();
                if (ice.daysExpire == 0)
                {
                    iceList.Remove(ice);
                }
            }

            foreach (Cups cup in cupList)
            {
                cup.subtractDay();
                if (cup.daysExpire == 0)
                {
                    cupList.Remove(cup);
                }
            }

        }

        public float getCash()
        {
            return cash;
        }

        public float calculateTotal(int customers, float price)
        {

            int cupsAvailable = getMinimumAvailable();
            float total;
            
            
            if (customers > cupsAvailable)
            {
                
                total = cupsAvailable * price;
                addCash(total);
                
            }
            else
            {
                total = customers * price;
                addCash(total);
                int lastItem = customers - cupsAvailable;
                int cupsSold = customers;
            }

            for (int i = 0; i < cupsAvailable; i++)
            {
                lemonList.RemoveAt(0);
                sugarList.RemoveAt(0);
                iceList.RemoveAt(0);
                cupList.RemoveAt(0);
            }

            return total;  
        }

        public int calculateTotalSold(int customers)
        {

            int cupsAvailable = getMinimumAvailable();
            int totalSold;


            if (customers > cupsAvailable)
            {
                totalSold = cupsAvailable;
            }
            else
            {
                totalSold = customers;
            }

            return totalSold;
        }

        public int getMinimumAvailable()
        {
            List<int> minList = new List<int> { };
            minList.Add(getLemonCount());
            minList.Add(getSugarCount());
            minList.Add(getIceCount());
            minList.Add(getCupCount());

            return minList.Min();
        }