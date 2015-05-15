using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using AbstractFactory.Factory;
using AbstractFactory.Product;
/*
 *目的: 抽象工厂模式
 *理解：每个抽象工厂可以生产一个产品族,我认为抽象工厂是工厂方法的扩展，虽然在添加一个产品，不需要重新新建一个工厂，但是会破坏已有结构，必须修改接口，然后再工厂中添加生产方法
 *
 *区别：工厂方法是产品与工厂 是一一对应的关系，但是抽象工厂中 工厂与产品是一对多的关系（每个工厂生产一个产品族）。
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
