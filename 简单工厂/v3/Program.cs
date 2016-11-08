using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v3
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

            switch (op)
            {
                case "+":
                    AddComputer com = new AddComputer();
                    com.NumberA = a;
                    com.NumberB = b;
                    result = com.Result;
                    break;
                case "-":
                    JianComputer com2 = new JianComputer();
                    com2.NumberA = a;
                    com2.NumberB = b;
                    result = com2.Result;
                    break;
                case "*":
                    ChengComputer com3 = new ChengComputer();
                    com3.NumberA = a;
                    com3.NumberB = b;
                    result = com3.Result;
                    break;
                case "/":
                    ChuComputer com4 = new ChuComputer();
                    com4.NumberA = a;
                    com4.NumberB = b;
                    result = com4.Result;
                    break;
                default:
                    break;
            }

            Console.WriteLine("{0}{1}{2}={3}", a, op, b, result);

            Console.ReadKey();
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
