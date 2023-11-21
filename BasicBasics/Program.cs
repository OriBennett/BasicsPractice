namespace BasicBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x;
            x = 123;

            int y = 321;
            double height = 175.3;
            Console.WriteLine(x+y);
            Console.WriteLine("y is: " + y);
            Console.WriteLine("x is: " + x);
            Console.WriteLine("Height is: " + height);

            int num = 3;
            double dot = 3.5;
            bool trueOrFalse = false;
            char symbol = '@';
            string? name = Console.ReadLine();
            Console.WriteLine(name);
            String name2 = Console.ReadLine();
            Console.WriteLine(name2);

        }
    }
}
