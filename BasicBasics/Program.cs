using System.Security.Cryptography;

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

            ////Arithmatic
            //int friends = 5;
            //friends = friends + 1;
            //Console.WriteLine(friends);
            //friends += 2;
            //Console.WriteLine(friends);
            //friends++;
            //Console.WriteLine(friends);

            //friends = friends - 1;
            //Console.WriteLine(friends);
            //friends -= 2;
            //Console.WriteLine(friends);
            //friends--;
            //Console.WriteLine(friends);

            //friends = friends * 2;
            //Console.WriteLine(friends);
            //friends *= 2;
            //Console.WriteLine(friends);

            //friends = friends / 2;
            //Console.WriteLine(friends);
            //friends /= 2;
            //Console.WriteLine(friends);

            //friends = friends % 3;
            //Console.WriteLine(friends);
            //friends %= 2;
            //Console.WriteLine(friends);

            //Math Class

            double a = 3;
            double b = 5;
            double sq = Math.Pow(a, 3);
            Console.WriteLine(sq);
            double rt = Math.Sqrt(a);
            a = -a;
            double ab = Math.Abs(a);
            Console.WriteLine(ab);
            a += 0.14;
            double round = Math.Round(a);
            Console.WriteLine(round);
            double ceiling = Math.Ceiling(a);
            Console.WriteLine(ceiling);
            double floor = Math.Floor(a);
            Console.WriteLine(floor);
            double max = Math.Max(a, b);
            Console.WriteLine(max);
            double min = Math.Min(a, b);
            Console.WriteLine(min);

            //Random

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(Random.Shared.Next());
            Console.WriteLine(random.NextDouble());
            
            //RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();  //Don't do this!!!
            //Cryptographically secure randomness RandomNumberGenerator

            Console.WriteLine(RandomNumberGenerator.GetInt32(0,int.MaxValue));

            //IN .NET8 there are now new uses for both Random and RandomNumberGenerator:
            //Shuffle for shuffleing arrays or spans
            //GetItems for retriving an item from an array (with Generics) (can also be used to get a single Item)
            //RandomNumberGenerator now has GetHexString and GetString for returning cryptographically secure strings.

            //Hypotenues Calculator Program

            Console.WriteLine("Hypotenuse Calculator");
            Console.Write("Enter side A: ");
            double A = Convert.ToDouble(Console.ReadLine()); //I'll deal with checking inputs at a later time
            Console.Write("Enter side B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            double C = Math.Sqrt((A*A) + (B*B));
            Console.WriteLine("The hypotenuse, side C is: " + C);


            //Strings

            //Remember, Strings are immutable. If you need to play around with them a lot, you should probably use StringBuilder




        }
    }
}
