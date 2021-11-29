namespace Module2HW6.Models
{
    public class TaxiAvto
    {
        public string AutoName { set; get; }

        public double CarPrice { set;get; }

        public double CarConsume { set; get; }

        public TaxiAvto(string autoName, double carPrice, double carConsume)
        {
            AutoName = autoName;
            CarPrice = carPrice;
            CarConsume = carConsume;
        }
    }
}
