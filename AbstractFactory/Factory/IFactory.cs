﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstractFactory.Product;
namespace AbstractFactory.Factory
{
    public interface IFactory
    {
        ICar ProduceJeep();
        ICar ProduceRunning();
    }
}
