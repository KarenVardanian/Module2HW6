
namespace Module2HW6.Models
{
    public class Jeep : DvsEngine
    {
        public int PlaceAmount { set; get; }

        public Jeep(string autoName, double vEngine, int placeAmount, int yearBought, double carPrice, double carConsume)
            : base(autoName, vEngine, carPrice, carConsume)
        {
            PlaceAmount = placeAmount;
        }
    }
}
