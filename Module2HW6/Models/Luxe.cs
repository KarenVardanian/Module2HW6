
namespace Module2HW6.Models
{
    public class Luxe : Sedan
    {
        public double ArrivalPrice { set; get; }
        public Luxe(string autoName, double vEngine, double maxWeight, double arrivalPrice, double carPrice, double carConsume)
            : base(autoName, vEngine, maxWeight, carPrice, carConsume)
        {
            ArrivalPrice = arrivalPrice;
        }
    }
}
