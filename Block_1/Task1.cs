class Task1
{
    static void Main(string[] args)
    {
        string name;
        do
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
        } while(string.IsNullOrWhiteSpace(name));

        
        string ageString;
        int age;
        do
        {
            Console.WriteLine("Enter your age: ");
            ageString = Console.ReadLine();
            
        } while(!int.TryParse(ageString, out age));

        Console.WriteLine($"Привет, {name}! Через 5 лет тебе будет {age + 5} лет.");
    }
}