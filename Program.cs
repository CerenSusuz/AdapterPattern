using AdapterExample;

class Program
{
    static void Main(string[] args)
    {
        IElements<User> users = new UserElements();

        IContainer<User> container = new ElementsAdapter<User>(users);

        var printer = new Printer();
        printer.Print(container);

        Console.WriteLine($"\nTotal User: {container.Count}");
    }
}
