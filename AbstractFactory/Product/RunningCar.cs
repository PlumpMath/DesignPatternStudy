using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product
{
    public class RunningCar:ICar
    {
        private string producerName;

        public string ProduceName
        {
            get
            {
                return this.producerName;
            }
            set
            {
                producerName = value;
            }
        }

        public RunningCar(string producerName)
        {
            this.producerName = producerName;
        }

        public void Run()
        {
            Console.WriteLine(producerName + "'s Running Car");
        }
    }
}
