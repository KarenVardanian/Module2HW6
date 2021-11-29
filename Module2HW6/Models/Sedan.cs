namespace Module2HW6.Models
{
    public class Sedan : DvsEngine
    {
        public double MaxWeight { set; get; }
        public Sedan(string autoName, double vEngine, double maxWeight, double carPrice, double carConsume) :
            base(autoName, vEngine, carPrice, carConsume)
        {
            MaxWeight = maxWeight;
        }
    }
}
