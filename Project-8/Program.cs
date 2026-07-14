class Program
{
    string Greeting (string name)
    {
        return $"Hello {name}!";
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program greeting = new Program();
        Console.WriteLine(greeting.Greeting("Eren"));
    }
}
