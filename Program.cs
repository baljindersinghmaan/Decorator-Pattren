namespace DecoratorPattern;

class Program
{
    static void Main(string[] args)
    {
        IComponent<string> baseComponent = new ConcreteComponent();

        // Create decorators
        IComponent<string> plainDecorated = new PlainDecorator(baseComponent);
        IComponent<string> upperCaseDecorated = new UpperCaseDecorator(baseComponent);
        IComponent<string> colorDecorated = new ColorDecorator(baseComponent);

        // Print results of GetText() for each component
        Console.WriteLine("Base Component: " + baseComponent.GetText());
        Console.WriteLine("Plain Decorator: " + plainDecorated.GetText());
        Console.WriteLine("Uppercase Decorator: " + upperCaseDecorated.GetText());
        Console.WriteLine("Color Decorator: " + colorDecorated.GetText());
    }
}
