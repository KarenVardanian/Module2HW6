using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class Service
    {
        private readonly TaxiAvto[] _data;
        public Service()
        {
            _data = new TaxiAvto[] {
                new ElectroCar("Nissan",50,2020,25000,50),
                new Luxe("Lexus",3.5,800,2018,150000,15),
                new StandartTypeCar("Lanos",2.2,2001,true,3000,4),
                new StandartTypeCar("BMW",2.2,1991,false,2001,6.2)
                };

        }

        public TaxiAvto[] GetAll()
        {
            return _data;
        }


        public void Show()
        {
            foreach (var item in _data)
            {
                Console.WriteLine(item.AutoName);
            }
        }

    }
}
