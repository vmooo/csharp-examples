class Task2
{
    static int SumEvenNumbers(int[] numbers)
    {
        int sum = 0;
        foreach(int num in numbers)
        {
            sum += (num % 2 == 0) ? num : 0;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int[] test = [1, 2, 3, 4, 5, 6];

        Console.WriteLine("Sum of even numbers in array [1,2,3,4,5,6]:");
        Console.WriteLine(SumEvenNumbers(test));
    }
}