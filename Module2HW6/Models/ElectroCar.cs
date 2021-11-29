namespace Module2HW6.Models
{
    public class ElectroCar : TaxiAvto
    {
        public double EngineVoltage { set; get; }
        public ElectroCar(string autoName, double engineVoltage, int yearBought, double carPrice, double carConsume)
            : base(autoName,carPrice, carConsume)
        {
            EngineVoltage = engineVoltage;
        }
    }
}
