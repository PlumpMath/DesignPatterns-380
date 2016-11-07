using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例._5.延迟初始化
{
    public sealed class Singleton
    {
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            internal static readonly Singleton instance = null;
            static Nested()
            {
                instance = new Singleton();
            }
        }

    }
}
