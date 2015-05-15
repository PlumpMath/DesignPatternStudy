using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *目的： 工厂方法模式
 *理解：工厂方法模式，我认为是一种比较灵活，扩展性非常好的设计模式，当添加一个产品时，只需要相应的添加一个产品类和一个工厂类，然后再Client调用即可，符合“开闭原则” “里氏替换原则”
 *      缺点是，有多少个产品就需要多少个工厂
 */


namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory jeepFactory = new JeepCarFactory();
            ICar jeep = jeepFactory.CreateProduct();

            jeep.ShowSelf();
        }
    }
}
