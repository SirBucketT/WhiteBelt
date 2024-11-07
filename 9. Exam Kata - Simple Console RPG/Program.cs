class Program
{
    static void Main(string[] args)
    {
        int playerHealth = 80;
        int attackPower = 25;
        int healAbility = 20;
        int giblinHealth = 50;

        Console.WriteLine("Welcome to the simple console RPG game!");
        
        bool gameIsOver = false;
        while(playerHealth > 0)
        {
            Console.WriteLine($"Hero's health: {playerHealth}");
            Console.WriteLine($"Goblin's health: {giblinHealth}");
            Console.WriteLine();
            
            Console.WriteLine("What is thee move ?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Hero attacks the Goblin!");
                Console.WriteLine($"Goblin takes {attackPower} damage!");
                giblinHealth = giblinHealth - attackPower;
            }
            else
            {
                playerHealth = healAbility + playerHealth;
                Console.WriteLine($"Here uses heal and heals its HP by 20!");
            }
            
            if(giblinHealth <= 0)
            {
                Console.WriteLine("Congratulations! Hero has defeated the Goblin!");
                gameIsOver = true;
                return;
            }
            else
            {
                Console.WriteLine("Goblin attacks Hero!");
                Console.WriteLine("Hero takes 10 damage.");
                Console.WriteLine(". . .");
                playerHealth = playerHealth - 10;
            }
            
        }
    }
}