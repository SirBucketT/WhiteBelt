class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello User please enter a number between 1-10."); 
        int playerLuck = int.Parse(Console.ReadLine());

        if (playerLuck <= 0 || playerLuck > 10)
        {
            Console.WriteLine("Invalid input. ");
        }
        Console.WriteLine("You encounter an enemy! Do you want to attempt an attack? (yes/no)");
        string playerInput = Console.ReadLine();
        
        if (playerInput != "yes")
        { 
            Console.WriteLine("Player retreated.");
        }else
        {
            Console.WriteLine("Attempting to attack...");
        if (playerLuck > 7)
        {
            Console.WriteLine("Success! Your attack hits the enemy.");
        }

        if (playerLuck == 6)
        {
            Console.WriteLine("Attack barely succeeded.");
        }
        else
        {
            Console.WriteLine("Attack missed.");
        }
        }
    }    
}