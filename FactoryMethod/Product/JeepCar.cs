using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class JeepCar:ICar
    {
        public void ShowSelf()
        {
            Console.WriteLine("I am Jeep ");
        }
    }
}
