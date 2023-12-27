namespace LINQPractice
{
    internal class Program
    {
        static int[] QueryIntArray()
        {
            int[] nums = {5, 10, 15, 20, 25, 30, 35};

            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;
            foreach (var num in gt20)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"Get Type : {gt20.GetType()}");
            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();
            nums[0] = 40;
            foreach (var num in gt20) // gt20 auto updates 
            {
                Console.WriteLine(num);
            }
            return arrayGT20;
        }
        static void Main(string[] args)
        {
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy" };
            int[] ints = QueryIntArray();
            
            var dogSpaces = from dog in dogs where dog.Contains(" ") orderby dog descending select dog;
            foreach (var item in dogSpaces)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
