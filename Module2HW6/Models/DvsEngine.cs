namespace Module2HW6.Models
{
    public class DvsEngine : TaxiAvto
    {
        public double VEndgine { get; set; }

        public DvsEngine(string autoName, double vEngine, double carPrice, double carConsume)
            : base(autoName, carPrice, carConsume)
        {
            VEndgine = vEngine;
        }
    }
}
