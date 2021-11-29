using Module2HW6.Models;
using Module2HW6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6
{
    public class Starter
    {
        public void Run()
        {
            Service ss = new Service();
            SortService sort = new SortService();
            CountCarPrice count = new CountCarPrice();
            TaxiAvto[] auto = ss.GetAll();
            TaxiAvto[] b;
            double v = count.CountPrice();

            b = auto.SearchByConsume(3, 38);
            auto = sort.Sort();
        }
    }
}
