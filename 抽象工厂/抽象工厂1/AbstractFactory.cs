using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 抽象工厂1
{
    public abstract class AbstractFactory
    {
        public abstract YaBo CreateYaBo();
        public abstract YaJia CreateYaJia();
    }
}
