using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Product;

namespace AbstractFactory.Factory
{
    
    public class BenzFactory:IFactory
    {
        public ICar ProduceJeep()
        {
            return new JeepCar("Benz");
        }

        public ICar ProduceRunning()
        {
            
            return new RunningCar("Benz");
        }
    }
}
