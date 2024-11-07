class Program
{
    static void Main(string[] args)
    {
        int enemyNumber = 1;
        int waveNumber = 1;
        
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Wave {waveNumber} is starting!");
                
            for (int e = 0; e < 4; e++)
            {
                Console.WriteLine($"Enemy #{enemyNumber} has spawned.");
                enemyNumber++;
            }
            Console.WriteLine("");
            
            Console.WriteLine($"Wave {waveNumber} completed. Preparing for the next wave...");
            waveNumber++;
        }
        
        Console.WriteLine("");
        Console.WriteLine("All waves completed! Victory is yours!");
        
    }
}