using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 目的：简单工厂模式
 * 模式理解：简单工厂模式是非常简单的设计模式，将product的生产都集中到工厂中，当要添加一个产品是，需要添加一个产品类（实现ICar接口），并且需要在工厂类中修改代码，违背“开闭原则”，可扩展性较差
 */

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string jeepCar = "Jeep";
            IFactory carFactory = new CarFactory();

            ICar jeepCarObj = carFactory.CreateProduct(jeepCar);

            if (jeepCar != null)
            {
                jeepCarObj.ShowSelf();
            }

        }
    }
}
