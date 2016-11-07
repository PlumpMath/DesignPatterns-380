using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例._4.静态初始化
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = null;

        static Singleton()
        {
            _instance = new Singleton();
        }

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
