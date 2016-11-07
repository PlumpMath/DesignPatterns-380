using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例._1.简单实现
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get { return _instance ?? (_instance = new Singleton()); }
        }
    }
}
