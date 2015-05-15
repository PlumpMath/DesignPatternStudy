using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SuvCar:ICar
    {
        public void ShowSelf()
        {
            Console.WriteLine("I am Suv");
        }
    }
}
