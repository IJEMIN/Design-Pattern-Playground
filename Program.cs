public static class Program
{
    public static void Main()
    {
        // select pattern to demonstrate
        Console.WriteLine("Select pattern to demonstrate:");
        Console.WriteLine("1. Memento");
        Console.WriteLine("2. Iterator");

        IDemo demoRunner;

        switch (Console.ReadKey().KeyChar)
        {
            case '1':
                // demoRunner = new MementoPattern.Demo();
                throw new NotImplementedException();
                break;
            case '2':
                demoRunner = new IteratorPattern.Demo();
                break;
            default:
                Console.WriteLine("Invalid selection");
                return;
        }

        demoRunner.Run();
    }
}
