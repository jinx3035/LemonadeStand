    public class Shipment : IUpdate
    {
        public List<object> lemonList = new List<object>();
        public List<object> sugarList = new List<object>();
        public List<object> iceList = new List<object>();
        public List<object> cupList = new List<object>();

        protected int daysToDelivery;

        protected bool shipmentDelayed = false;
        protected bool shipmentLost = false;

        public void AddLemons(object lemon)
        {
            this.lemonList.Add(lemon);
        }

        public void AddSugar(object sugar)
        {
            this.sugarList.Add(sugar);
        }

        public void AddIce(object ice)
        {
            this.iceList.Add(ice);
        }

        public void AddCup(object cup)
        {
            this.cupList.Add(cup);
        }

        public int DaysToDelivery
        {
            get
            {
                return daysToDelivery;
            }
            set
            {
                this.daysToDelivery = value;
            }
        }

        public void update()
        {
            this.daysToDelivery -= 1;
        }