class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Give me a name");
        string name = Console.ReadLine();
        int healthPoints = 100;
        float attackPower = 30;
        bool isParalyzed = true;
        string currency = "150.3333333";
        float experiance = 250;
        
        //conversions
        double doubleHealthPoints = healthPoints;
        int intAttackPower = (int)attackPower;
        int intExperiance = Convert.ToInt32(experiance);
        if (double.TryParse(currency, out double doubleCurrency))
        {
            //Console.WriteLine("Gold Coins (parsed from string): 150.3333333");
        }

        Console.WriteLine($"Character Name: {name}");
        Console.WriteLine($"Health as double (implicit conversion): {doubleHealthPoints}");
        Console.WriteLine($"Attack Power as int (explicit conversion): {intAttackPower}"); 
        Console.WriteLine($"Experience as int (using Convert): {intExperiance}");
        Console.WriteLine($"Gold Coins (parsed from string): {doubleCurrency}");
    }
}