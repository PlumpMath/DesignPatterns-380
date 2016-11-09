using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            //鞋子和帽子，具有不同的品牌，耐克和李宁

            Shoes shoes = null;
            Hat hat = null;

            SportsShop sportsShop = null;

            sportsShop=new LiNingShop();

            shoes = sportsShop.SellShoes();
            hat = sportsShop.SellHat();

            Console.WriteLine("鞋：{0}，帽子：{1}",shoes,hat);

            Console.ReadKey();
        }
    }

    /// <summary>
    /// 抽象产品A
    /// </summary>
    public abstract class Shoes
    {

    }

    /// <summary>
    /// 抽象产品B
    /// </summary>
    public abstract class Hat
    {
    }

    /// <summary>
    /// 抽象工厂，负责创建产品
    /// </summary>
    public abstract class SportsShop
    {
        /// <summary>
        /// 创建产品A
        /// </summary>
        /// <returns></returns>
        public abstract Shoes SellShoes();

        /// <summary>
        /// 创建产品B
        /// </summary>
        /// <returns></returns>
        public abstract Hat SellHat();
    }

    /// <summary>
    /// Nike产品A(系列1产品A)
    /// </summary>
    public class NikeShose : Shoes
    {

    }

    /// <summary>
    /// LiNing产品A（系列2产品B）
    /// </summary>
    public class LiNingShose : Shoes
    {

    }

    /// <summary>
    /// Nike产品B（系列1产品B）
    /// </summary>
    public class NikeHat : Hat
    {

    }

    /// <summary>
    /// LiNing产品B（系列2产品B）
    /// </summary>
    public class LiNingHat : Hat
    {

    }

    public class NikeShop : SportsShop
    {
        public override Shoes SellShoes()
        {
            
            return new NikeShose();
        }

        public override Hat SellHat()
        {
            return new NikeHat();
        }
    }

    public class LiNingShop : SportsShop
    {

        public override Shoes SellShoes()
        {
           return new LiNingShose();
        }

        public override Hat SellHat()
        {
            return new LiNingHat();
        }
    }
}
