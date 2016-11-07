using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 单例._1.简单实现;

namespace 单例
{
    class Program
    {
        static void Main(string[] args)
        {
            _1.简单实现.Singleton singleton = Singleton.Instance;
            _1.简单实现.Singleton singleton2 = Singleton.Instance;
            _1.简单实现.Singleton singleton3 = Singleton.Instance;

            Console.WriteLine(singleton==singleton2);//true
            Console.WriteLine(object.Equals(singleton2, singleton3));//true
            Console.WriteLine(object.ReferenceEquals(singleton2, singleton3));//true

            Console.ReadKey();
        }
    }
}
