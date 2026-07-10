using System.Linq;

namespace task4_1
{
    internal class Task0
    {
        private static void Main(string[] args)
        {
            var numbers = new List<int>();

            for (int i = 1; i <= 20; ++i)
            {
                numbers.Add(i);
            }
            
            var selectedNumbers = (from n in numbers
                                    where n % 2 == 0
                                    orderby n descending 
                                    
                                    select n).Take(5);

            foreach (var a in selectedNumbers)
            {
                Console.WriteLine(a);
            }
        }
    } 
}

