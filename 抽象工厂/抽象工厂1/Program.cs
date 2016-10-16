using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



/*
 * 参考文章地址：http://learninghard.blog.51cto.com/6146675/1297704
 * 
 */

namespace 抽象工厂1
{
    class Program
    {
        static void Main(string[] args)
        {
            //南昌
            AbstractFactory nanChangFactory=new NanChangFactory();
            YaBo nanChangYaBo = nanChangFactory.CreateYaBo();
            nanChangYaBo.Print();

            YaJia nanChangYaJia = nanChangFactory.CreateYaJia();
            nanChangYaJia.Print();

            //上海
            AbstractFactory shangHaiFactory=new ShangHaiFactory();
            YaBo shangHaiYaBo = shangHaiFactory.CreateYaBo();
            shangHaiYaBo.Print();

            YaJia shangHaiYaJia = shangHaiFactory.CreateYaJia();
            shangHaiYaBo.Print();

            //湖南
            AbstractFactory huNanFactory=new HuNanFactory();
            YaBo huNanYaBo = huNanFactory.CreateYaBo();
            huNanYaBo.Print();

            YaJia huNanYaJia = huNanFactory.CreateYaJia();
            huNanYaJia.Print();

            Console.ReadKey();
        }
    }
}
