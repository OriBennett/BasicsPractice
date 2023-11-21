namespace BasicBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ////variables
            //int x;
            //x = 123;

            //int y = 321;
            //double height = 175.3;
            //Console.WriteLine(x+y);
            //Console.WriteLine("y is: " + y);
            //Console.WriteLine("x is: " + x);
            //Console.WriteLine("Height is: " + height);

            //int num = 3;
            //double dot = 3.5;
            //bool trueOrFalse = false;
            //char symbol = '@';
            //string? name = Console.ReadLine();
            //Console.WriteLine(name);
            //String name2 = Console.ReadLine();
            //Console.WriteLine(name2);

            ////constants
            //const double pi = 3.14159;
            //Console.WriteLine(pi);
            ////type casting
            //int newPi = Convert.ToInt32(pi); //Convert
            //Console.WriteLine(newPi);
            //Console.WriteLine(newPi.GetType());
            //String newPiStr = newPi.ToString(); //ToString method
            //Console.WriteLine(newPiStr);
            //int newPI2 = (int)pi; //casting
            //Console.WriteLine(newPI2);

            //Arithmatic
            int friends = 5;
            friends = friends + 1;
            Console.WriteLine(friends);
            friends += 2;
            Console.WriteLine(friends);
            friends++;
            Console.WriteLine(friends);

            friends = friends - 1;
            Console.WriteLine(friends);
            friends -= 2;
            Console.WriteLine(friends);
            friends--;
            Console.WriteLine(friends);

            friends = friends * 2;
            Console.WriteLine(friends);
            friends *= 2;
            Console.WriteLine(friends);

            friends = friends / 2;
            Console.WriteLine(friends);
            friends /= 2;
            Console.WriteLine(friends);

            friends = friends % 3;
            Console.WriteLine(friends);
            friends %= 2;
            Console.WriteLine(friends);
            


        }
    }
}
