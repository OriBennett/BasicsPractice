namespace FightingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor", 100, 26, 10);
            MagicWarrior loki = new MagicWarrior(50, "Loki", 75, 20, 10);
            Battle.StartFight(thor, loki);
        }
    }
}
