namespace Kata1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome, brave adventurer! What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Greetings, {name}! Your journey begins now...");
        Console.WriteLine("On a scale of 1 to 10, how excited are you to start this quest?");
        int exceitement = Convert.ToInt32(Console.ReadLine());
        if (exceitement >= 7)
        {
            Console.WriteLine("Fantastic! You seem ready to take on any challenge!");
        }
        else
        {
            Console.WriteLine("Aw have some confidence in yourself.");
        }
    }
}