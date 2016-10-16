namespace 抽象工厂1
{
    public class NanChangFactory:AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new NanChangYaBo();      
        }

        public override YaJia CreateYaJia()
        {
            return new NanChangYaJia();
        }
    }
}