using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入第二个数字");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入运算符号");
            string op = Console.ReadLine();

            int result = 0;

            Computer com = null;

            Factory factory = null;

            switch (op)
            {
                case "+":
                    factory = new FactoryAdd();
                    break;
                case "-":
                    factory = new FactoryJian();
                    break;
                case "*":
                    factory = new FactoryCheng();
                    break;
                case "/":
                    factory = new FactoryChu();
                    break;
                default:
                    factory = new FactoryAdd();
                    break;
            }

            com = factory.CreateComputer();

            com.NumberA = a;
            com.NumberB = b;

            result = com.Result;

            Console.WriteLine("{0}{1}{2}={3}", a, op, b, result);

            Console.ReadKey();
        }
    }


    public abstract class Factory
    {
        public abstract Computer CreateComputer();
    }

    public class FactoryAdd : Factory
    {
        public override Computer CreateComputer()
        {
            return new AddComputer();
        }
    }

    public class FactoryJian : Factory
    {
        public override Computer CreateComputer()
        {
            return new JianComputer();
        }
    }
    public class FactoryCheng : Factory
    {
        public override Computer CreateComputer()
        {
            return new ChengComputer();
        }
    }
    public class FactoryChu : Factory
    {
        public override Computer CreateComputer()
        {
            return new ChuComputer();
        }
    }

    /// <summary>
    /// 运算类
    /// </summary>
    public abstract class Computer
    {
        protected int _NumberA;
        protected int _NumberB;

        public int NumberA
        {
            get { return _NumberA; }
            set { _NumberA = value; }
        }

        public int NumberB
        {
            get { return _NumberB; }
            set { _NumberB = value; }
        }

        /// <summary>
        /// 子类必须完成的功能：计算并返回结果
        /// </summary>
        public abstract int Result { get; }
    }

    public class AddComputer : Computer
    {
        public override int Result
        {
            get { return base._NumberA + base._NumberB; }
        }
    }

    public class JianComputer : Computer
    {
        public override int Result
        {
            get { return base._NumberA - base._NumberB; }
        }
    }
    public class ChengComputer : Computer
    {
        public override int Result
        {
            get { return base._NumberA * base._NumberB; }
        }
    }
    public class ChuComputer : Computer
    {
        public override int Result
        {
            get
            {
                if (base._NumberB == 0)
                {
                    throw new ArgumentException("被除数不能为0");
                }
                return base._NumberA / base._NumberB;
            }
        }
    }
}
