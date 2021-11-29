
namespace Module2HW6.Models
{
    class StandartTypeCar : Sedan
    {
        public bool IsHasBagagePlace { set; get; }
        public StandartTypeCar(string autoName, double vEngine, double maxWeight, bool isHasBagage, double carPrice, double carConsume)
            : base(autoName, vEngine, maxWeight, carPrice, carConsume)
        {
            IsHasBagagePlace = isHasBagage;
        }
    }
}
