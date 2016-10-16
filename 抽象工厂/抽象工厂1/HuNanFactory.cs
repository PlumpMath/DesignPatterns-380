namespace 抽象工厂1
{
    public class HuNanFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new HuNanYaBo();

        }

        public override YaJia CreateYaJia()
        {
            return new HuNanYajia();
        }
    }
}