using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例._2.线程安全的
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object Padlock = new object();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }

                }
                return _instance;
            }
        }
    }
}
