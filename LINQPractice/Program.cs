using System.Collections;

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
            Animal[] farmAnimals = new[]
            {
                new Animal{Name="Heidi", Height=80, Weight=18, AnimalID=1},
                new Animal{Name="Shrek", Height=40, Weight=65, AnimalID=2},
                new Animal{Name="Congo", Height=3.8, Weight=90, AnimalID=1},
                new Animal{Name="Bongo", Height=4.8, Weight=60, AnimalID=2},
                new Animal{Name="Bingo", Height=5.8, Weight=70, AnimalID=3},
                new Animal{Name="Dingo", Height=6.8, Weight=80, AnimalID=2}
            };
            Owner[] owners = new[]{new Owner{Name = "Sally Sale", OwnerID = 1}, new Owner { Name = "David Dale", OwnerID = 2 }, new Owner { Name = "Garson Gale", OwnerID = 3 } };
            var famAnimalsEnum = farmAnimals.OfType<Animal>();
            var smallAnimals = from animal in famAnimalsEnum
                               where animal.Weight <= 65
                               orderby animal.Name
                               select animal;
            foreach (var animal in smallAnimals)
            {
                Console.WriteLine($"{animal.Name} weighs {animal.Weight}kgs");
            }

            var dogSpaces = from dog in dogs where dog.Contains(" ") orderby dog descending select dog;
            foreach (var item in dogSpaces)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            var innerJoin = from animal in farmAnimals
                            join owner in owners on animal.AnimalID
                            equals owner.OwnerID
                            select new {OwnerName = owner.Name, AnimalName = animal.Name};

            foreach (var i in innerJoin)                
            {
                Console.WriteLine("{0} owns {1}",i.OwnerName,i.AnimalName);
            }
        }
    }
}
