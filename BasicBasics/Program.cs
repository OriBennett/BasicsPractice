﻿using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

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

            ////Math Class

            //double a = 3;
            //double b = 5;
            //double sq = Math.Pow(a, 3);
            //Console.WriteLine(sq);
            //double rt = Math.Sqrt(a);
            //a = -a;
            //double ab = Math.Abs(a);
            //Console.WriteLine(ab);
            //a += 0.14;
            //double round = Math.Round(a);
            //Console.WriteLine(round);
            //double ceiling = Math.Ceiling(a);
            //Console.WriteLine(ceiling);
            //double floor = Math.Floor(a);
            //Console.WriteLine(floor);
            //double max = Math.Max(a, b);
            //Console.WriteLine(max);
            //double min = Math.Min(a, b);
            //Console.WriteLine(min);

            ////Random

            //Random random = new Random();
            //Console.WriteLine(random.Next());
            //Console.WriteLine(Random.Shared.Next());
            //Console.WriteLine(random.NextDouble());

            ////RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();  //Don't do this!!!
            ////Cryptographically secure randomness RandomNumberGenerator

            //Console.WriteLine(RandomNumberGenerator.GetInt32(0,int.MaxValue));

            ////IN .NET8 there are now new uses for both Random and RandomNumberGenerator:
            ////Shuffle for shuffleing arrays or spans
            ////GetItems for retriving an item from an array (with Generics) (can also be used to get a single Item)
            ////RandomNumberGenerator now has GetHexString and GetString for returning cryptographically secure strings.

            ////Hypotenues Calculator Program

            //Console.WriteLine("Hypotenuse Calculator");
            //Console.Write("Enter side A: ");
            //double A = Convert.ToDouble(Console.ReadLine()); //I'll deal with checking inputs at a later time
            //Console.Write("Enter side B: ");
            //double B = Convert.ToDouble(Console.ReadLine());

            //double C = Math.Sqrt((A*A) + (B*B));
            //Console.WriteLine("The hypotenuse, side C is: " + C);


            ////Strings

            ////Remember, Strings are immutable. If you need to play around with them a lot, you should probably use StringBuilder

            //string testString = "tHis iS tHe FBI Calling!";
            //string result;

            //result = testString.ToLower();
            //Console.WriteLine(result);

            //result = testString.ToUpper();
            //Console.WriteLine(result);

            //TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            //result = currentTextInfo.ToTitleCase(testString);
            //Console.WriteLine(result);

            //TextInfo englishTextInfo = new CultureInfo("en-US", false).TextInfo;
            //result = englishTextInfo.ToTitleCase(testString);
            //Console.WriteLine(result);

            //Console.WriteLine("cool");

            //testString = "Bennett";
            //for (int i = 0; i < testString.Length; i++)  //Playing with strings as arrays
            //{
            //    Console.WriteLine(testString[i]);
            //}

            //testString = "This is a \"test\" String"; //escape chars
            //Console.WriteLine(testString);

            //testString = "C:\\Demo\\Test.txt"; //escaping escape chars
            //Console.WriteLine(testString);

            //testString = @"C:\Demo\test.txt"; //String literal
            //Console.WriteLine(testString);

            //string firstName = "Ori";
            //string lastName = "Bennett";

            //result = "My name is " + lastName + ", " + firstName + " " + lastName;
            //Console.WriteLine(result);

            //result = String.Format("My name is {0}, {1} {0}", lastName, firstName);
            //Console.WriteLine(result);

            //result = $"My name is {lastName}, {firstName} {lastName}";
            //Console.WriteLine(result);

            ////These three are the same

            //result = $@"C:\Demo\{firstName}{lastName}\test.txt";  //interpolation and string literal, cool
            //Console.WriteLine(result);

            //result = $@"C:\Demo\{firstName}{lastName}\{"\""}test.txt{"\""}";  //interpolation and string literal and escape character, cool
            //Console.WriteLine(result);

            ////This is why stringbuilder is so important:

            //Stopwatch StringStopWatch = new Stopwatch();
            //StringStopWatch.Start();
            //string test = "";
            //for (int i = 0; i < 100000; i++)
            //{
            //    test += i;
            //}
            //StringStopWatch.Stop();
            //Console.WriteLine($"String Stopwatch: {StringStopWatch.ElapsedMilliseconds}ms"); //This took around 6 seconds


            //Stopwatch BuilderStopWatch = new Stopwatch();
            //BuilderStopWatch.Start();
            //StringBuilder builderTest = new();
            //for (int i = 0; i < 100000; i++)
            //{
            //    builderTest.Append(i);
            //}
            //BuilderStopWatch.Stop();
            //Console.WriteLine($"Builder Stopwatch: {BuilderStopWatch.ElapsedMilliseconds}ms"); //this didn't even get to 1ms

            //int[] ages = { 6, 7, 8, 3, 5, 4, 5, 6, 7, };
            //string result;

            //result = String.Concat(ages);
            //Console.WriteLine(result);

            //result = string.Join(",", ages);
            //Console.WriteLine(result);

            //string testString = "John,Tim,Mary,Sue,Bob,Jane";
            //string[] resultArray = testString.Split(',');
            //Array.ForEach(resultArray, x => Console.WriteLine(x)); //also practicing lambda, nice.
            //Console.WriteLine();

            //testString = "John, Tim, Mary, Sue, Bob, Jane";
            //resultArray = testString.Split(", ");
            //Array.ForEach(resultArray, x => Console.WriteLine(x));
            //Console.WriteLine();

            ////Trim and Pad
            //testString = "       Hello World         ";
            //result = testString.TrimStart();
            //Console.WriteLine($"'{result}'");

            //result = testString.TrimEnd();
            //Console.WriteLine($"'{result}'");

            //result = testString.Trim();
            //Console.WriteLine($"'{result}'");

            //testString = "1.15";
            //result = testString.PadLeft(10, '0');
            //Console.WriteLine(result );

            //result = testString.PadRight(10, '0');
            //Console.WriteLine(result );

            //result = testString.PadRight(10);
            //Console.WriteLine($"'{result}'");


            ////Searchhing Strings

            //testString = "This is a test of the search. Let's see how its testing works out.";
            //bool resultsBoolean = false;
            //int resultsInt = 0;

            //Console.WriteLine(testString);

            //resultsBoolean = testString.StartsWith("This is");
            //Console.WriteLine($"Starts with \"This is\": {resultsBoolean}");

            //resultsBoolean = testString.StartsWith("ThIs is");
            //Console.WriteLine($"Starts with \"ThIs is\": {resultsBoolean}");

            //resultsBoolean = testString.EndsWith("works out.");
            //Console.WriteLine($"Ends with \"works out.\": {resultsBoolean}");

            //resultsBoolean = testString.StartsWith("work out.");
            //Console.WriteLine($"Ends with \"work out.\": {resultsBoolean}");

            //resultsBoolean = testString.Contains("test");
            //Console.WriteLine($"Contains \"test\": {resultsBoolean}");

            //resultsBoolean = testString.Contains("tests");
            //Console.WriteLine($"Contains \"tests\": {resultsBoolean}");

            //resultsInt = testString.IndexOf("test");
            //Console.WriteLine($"Index of \"test\" is: {resultsInt}");

            //resultsInt = testString.IndexOf("test", 11);
            //Console.WriteLine($"Index of \"test\" after 11 is: {resultsInt}");

            //resultsInt = testString.IndexOf("test", 49);
            //Console.WriteLine($"Index of \"test\" after 48 is: {resultsInt}"); //returns -1 which is "not found"

            //resultsInt = testString.LastIndexOf("test");
            //Console.WriteLine($"Last Index of \"test\" is: {resultsInt}");

            //resultsInt = testString.LastIndexOf("test", 11);
            //Console.WriteLine($"Last Index of \"test\" before 10 is: {resultsInt}");

            //resultsInt = testString.LastIndexOf("test", 49);
            //Console.WriteLine($"LastIndex of \"test\" before 48 is: {resultsInt}");


            ////went over ifs, switches, logical operators (&&, ||), while loops, for loops


            ////Number guessing game

            //Console.WriteLine("Number gussing game:");
            //Console.WriteLine("Please guess a number between 1-100, What's your guess?");
            //int guess;
            //int answer = Random.Shared.Next(1, 101);

            //guess = Convert.ToInt32(Console.ReadLine());

            //while (guess != answer)
            //{
            //    if (guess < answer)
            //    {
            //        Console.WriteLine($"{guess} is too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{guess} is too high");
            //    }
            //    Console.WriteLine("Guess a new number between 1-100:");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Well done! You guessed the number.");


            ////Rock,Paper,Scissors 

            //Console.WriteLine("Rock, Paper, Scissors:");

            //string playerGuess;
            //string[] optionsRPS = { "ROCK", "PAPER", "SCISSORS" };
            //int computerGuess;
            //bool playAgain = true;
            ////string playAgainSTR;
            //while (playAgain)
            //{
            //    computerGuess = Random.Shared.Next(0, 3);
            //    Console.WriteLine("Please enter ROCK, PAPER or SCISSORS:");
            //    playerGuess = Console.ReadLine().ToUpper();
            //    Console.WriteLine($"Your play: {playerGuess}");
            //    Console.WriteLine($"Computer played: {optionsRPS[computerGuess]}");

            //    switch (computerGuess)
            //    {
            //        case 0: //ROCK
            //            if (playerGuess == "PAPER")
            //            {
            //                Console.WriteLine($"{playerGuess} beats {optionsRPS[computerGuess]}, You win!");
            //            }
            //            else if (playerGuess == "SCISSORS")
            //            {
            //                Console.WriteLine($"{optionsRPS[computerGuess]} beats {playerGuess}, You Lose.");
            //            }
            //            else if(playerGuess == "ROCK")
            //            {
            //                Console.WriteLine($"{optionsRPS[computerGuess]} ties with {playerGuess}");
            //            }
            //            else { Console.WriteLine("You lose by default, next time, please choose ROCK, PAPER or SCISSORS."); }
            //            break;
            //        case 1: //PAPER
            //            if (playerGuess == "PAPER")
            //            {
            //                Console.WriteLine($"{optionsRPS[computerGuess]} ties with {playerGuess}");
            //            }
            //            else if (playerGuess == "SCISSORS")
            //            {
            //                Console.WriteLine($"{playerGuess} beats {optionsRPS[computerGuess]}, You win!");
            //            }
            //            else if (playerGuess == "ROCK")
            //            {
            //                Console.WriteLine($"{optionsRPS[computerGuess]} beats {playerGuess}, You Lose.");
            //            }
            //            else { Console.WriteLine("You lose by default, next time, please choose ROCK, PAPER or SCISSORS."); }
            //            break;
            //        case 2: //Scissors
            //            if (playerGuess == "PAPER")
            //            {
            //                Console.WriteLine($"{playerGuess} beats {optionsRPS[computerGuess]}, You win!");
            //            }
            //            else if (playerGuess == "SCISSORS")
            //            {
            //                Console.WriteLine($"{optionsRPS[computerGuess]} ties with {playerGuess}");
            //            }
            //            else if (playerGuess == "ROCK")
            //            {
            //                Console.WriteLine($"{optionsRPS[computerGuess]} beats {playerGuess}, You Lose.");
            //            }
            //            else { Console.WriteLine("You lose by default, next time, please choose ROCK, PAPER or SCISSORS."); }
            //            break;



            //    }
            //    Console.WriteLine("Would you like to play again? (Y/N)");
            //    //playAgainSTR = Console.ReadLine().ToUpper();
            //    //if (Console.ReadLine().ToUpper() == "Y")
            //    //{
            //    //    playAgain = true;
            //    //}
            //    //else { playAgain = false; }
            //    playAgain = (Console.ReadLine().ToUpper() == "Y") ? true : false; //same as the if above, cool
            //}
            //Console.WriteLine("Thanks for playing.");


            //Lists

            List<string> food = new List<string>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("sushi");
            food.Add("fries");
            food.Add("steak");

            food.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(food.BinarySearch("steak"));//doesn't work because not sorted (gives the location of it if it were sorted?)
            food.Sort();
            Console.WriteLine(food.BinarySearch("steak"));//works because sorted
            Console.WriteLine(food.Count());
            Console.WriteLine(food.Capacity);
            Console.WriteLine(food.IndexOf("sushi"));
            Console.WriteLine(food);


            //threading
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main";
            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));
            thread1.Start();
            thread2.Start();

            //CountDown("Timer#1");
            //CountUp("Timer #2");

            Console.WriteLine(mainThread.Name + " is complete");

        }

        public static void CountUp(string name)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{name}: {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{name} is complete");

        }
        public static void CountDown(string name)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"{name}: {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{name} is complete"); 
        }
    }
}
