using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class JeepCarFactory: IFactory
    {
        public ICar CreateProduct()
        {
            return new JeepCar();
        }
    }
}
