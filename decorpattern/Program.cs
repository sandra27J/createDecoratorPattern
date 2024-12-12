class Program
{
    static void Main(string[] args)
    {
        IComponent<string> component = new ConcreteComponent();

        IComponent<string> plainDecorator = new PlainDecorator(component);
        IComponent<string> upperCaseDecorator = new UpperCaseDecorator(plainDecorator);
        IComponent<string> colorDecorator = new ColorDecorator(upperCaseDecorator);

        Console.WriteLine(component.GetText());
        Console.WriteLine(plainDecorator.GetText());
        Console.WriteLine(upperCaseDecorator.GetText());
        Console.WriteLine(colorDecorator.GetText());
    }
}
