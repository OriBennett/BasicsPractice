namespace FileSystemDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string rootPath = @"C:\Users\USER\Documents\Homework\Basics Practice\FileSystemDemo";

            string[] dirs = Directory.GetDirectories(rootPath);

            foreach (string dir in dirs )
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine();
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //Console.WriteLine(Path.GetFullPath(file));
                //Console.WriteLine(Path.GetDirectoryName(file));
            }

            bool directoryExists = Directory.Exists($@"{rootPath}\SubFolderC");
            Console.WriteLine(directoryExists);
            Directory.CreateDirectory($@"{rootPath}\SubFolderC\SubSubFolderD"); //will create if doesn't exist also doesnt writ over existing files.
            Console.WriteLine();
            Console.WriteLine();
            files = Directory.GetFiles(rootPath);
            string destinationFolder;
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            //decimal myDecimal = 1.0m; checking some accuracy stuff
            //double myDouble = 1.0d;

            //Console.WriteLine($"Decimal: {myDecimal}"); // Output: Decimal: 1.0
            //Console.WriteLine($"Double: {myDouble}");   // Output: Double: 1
            //Console.WriteLine($"Decimal: {myDecimal+myDecimal}"); // Output: Decimal: 2.0
            //Console.WriteLine($"Double: {myDouble+myDouble}");   // Output: Double: 2
            //Console.WriteLine($"Decimal: {myDecimal / myDecimal}"); // Output: Decimal: 1
            //Console.WriteLine($"Double: {myDouble / myDouble}");   // Output: Double: 1


        }
    }
}
