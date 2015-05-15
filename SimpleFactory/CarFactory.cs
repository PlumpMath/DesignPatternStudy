using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class CarFactory: IFactory
    {
        public ICar CreateProduct(string carName)
        {
            if ("Jeep".Equals(carName))
            {
                return new JeepCar();
            }
            else if ("Suv".Equals(carName))
            {
                return new SuvCar();
            }
            else
            {
                return null;
            }
        }
    }
}
