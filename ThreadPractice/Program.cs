namespace ThreadPractice
{
    internal class Program
    {
        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(Print1 );
            thread.Start();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
            int num = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num);
                Thread.Sleep(1000);
                num++;
            }

            
        }
    }
}
