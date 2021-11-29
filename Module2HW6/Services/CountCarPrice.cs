using Module2HW6.Models;

namespace Module2HW6.Services
{
    public class CountCarPrice : ICountPrice
    {
        public double CountPrice()
        {
            var sr = new Service(); 
            TaxiAvto[] pl = sr.GetAll();
            double result = 0;
            foreach (var item in pl)
            {
                result += item.CarPrice;
            }
            
            return result;
        }
    }
}
