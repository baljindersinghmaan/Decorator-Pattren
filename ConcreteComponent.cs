namespace DecoratorPattern;
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Baljinder Singh Maan";
        }
    }
