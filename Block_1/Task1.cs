class Task1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("name is null");
        }

        Console.WriteLine("Enter your age: ");
        string ageString = Console.ReadLine();

        if (string.IsNullOrEmpty(ageString))
        {
            Console.WriteLine("age is null");
        }

        int age = int.Parse(ageString);

        Console.WriteLine($"Привет, {name}! Через 5 лет тебе будет {age + 5} лет.");
    }
}