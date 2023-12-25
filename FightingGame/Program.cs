namespace FightingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            Warrior hulk = new Warrior("Hulk", 100, 26, 10);
            Battle.StartFight(thor, hulk);
        }
    }
}
