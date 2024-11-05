class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me a name");
        string name = Console.ReadLine();
        int healthPoints = 100;
        float attackPower = 15.5f;
        bool isParalyzed = true;
        double currency = 24.75;
        
        Console.WriteLine($"Character Name: {name} \n " +
                          $"Health Points: {healthPoints} \n " +
                          $"Attack Power: {attackPower} \n " +
                          $"Is Paralyzed: {isParalyzed} \n " +
                          $"Gold Coins: {currency}");
    }
}