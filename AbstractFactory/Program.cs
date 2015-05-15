using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AbstractFactory.Factory;
using AbstractFactory.Product;
/*
 *目的: 抽象工厂模式
 *理解：每个抽象工厂可以生产一个产品族,
 * 
 */


namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //生产Benz
            IFactory benzFactory = new BenzFactory();
            
            ICar benzJeep = benzFactory.ProduceJeep();
            ICar benzRunning = benzFactory.ProduceRunning();

            benzJeep.Run();
            benzRunning.Run();
        }
    }
}
