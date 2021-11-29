using Module2HW6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Services
{
    public class SortService : IComparer<TaxiAvto>
    {

        public int Compare(TaxiAvto x, TaxiAvto y)
        {
            if (x.CarConsume > y.CarConsume)
                return 1;
            else if (x.CarConsume < y.CarConsume)
                return -1;
            else
                return 0;
        }

        public TaxiAvto[] Sort()
        {
            Service sr = new Service();
            TaxiAvto[] pl = sr.GetAll();
            Array.Sort(sr.GetAll(), new SortService());

            return sr.GetAll();
        }
    }
}
